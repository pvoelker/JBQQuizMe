﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using JBQQuizMe.Repository;
using JBQQuizMe.ViewModel.Providers;
using SkiaSharp.Extended.UI.Controls;
using SkiaSharp.Extended.UI.Controls.Converters;
using System;
using System.Diagnostics;

namespace JBQQuizMe.ViewModel
{
    // All the code in this file is included in all platforms.
    public class QuizPage : ObservableObject
    {
        private static readonly List<string> _congratMessages = new List<string>()
        {
            "Good job!",
            "Way to go!",
            "Excellent!",
            "Congratulations!",
            "You are awesome!",
            "Keep going!"
        };

        private static readonly List<string> _successLotties = new List<string>()
        {
            "111592-happy-pencil.json",
            "126974-blasting-confetti.json",
            "127094-confetti-falling.json",
            "128258-snake-confetti.json",
            "132379-heart-love-music.json",
            "132630-happy-star.json"
        };

        private static readonly List<string> _failLotties = new List<string>()
        {
            "133064-angry-cloud.json"
        };

        private const decimal COMPLETION_DELTA = 0.1m;

        private const int MAX_ANSWERS = 4;

        private Random _random = new Random();

        private Stopwatch _stopwatch = new Stopwatch();

        private SKLottieImageSourceConverter _lottieConverter = new SKLottieImageSourceConverter();

        private Task _speechTask = null;

        private CancellationTokenSource _speechCancellationToken = default;

        private QuestionProvider _questionProvider = null;

        public QuizPage()
        {
        }

        public async Task InitializeAsync()
        {
            _questionProvider = new QuestionProvider(new QuestionsRepository(), MAX_ANSWERS, StartQuestionNumber, EndQuestionNumber);

            CurrentQuestion = _questionProvider.GetNextQuestion(CorrectAnswerAsync, WrongAnswerAsync);

            Continue = new RelayCommand<bool>((readNewQuestion) =>
            {
                if (readNewQuestion)
                {
                    ReadCurrentQuestion();
                }
            });

            CancelAnimation = new RelayCommand(() => { LottieImage = null; });

            _stopwatch.Start();

            ElapsedTime = _stopwatch.Elapsed;

            ReadCurrentQuestion();
        }

        #region Commands

        public IRelayCommand MessageThump { get; set; }

        public IRelayCommand CandleSparkle { get; set; }

        public IRelayCommand CandleJiggle { get; set; }

        public IRelayCommand Celebration { get; set; }

        public IRelayCommand CorrectAnswerGiven { get; set; }

        public IRelayCommand WrongAnswerGiven { get; set; }

        public IRelayCommand Continue { get; private set; }

        public IRelayCommand CancelAnimation { get; private set; }

        #endregion

        public bool IsAnimationComplete
        {
            get
            {
                // This is to resolve a compile time XFC0045 error with compiled bindings on SkiaSharp.Extended.UI.Controls.SKLottieView
                throw new NotImplementedException($"The GET should not be used on {nameof(IsAnimationComplete)}");
            }
            set
            {
                // Detect when animation completes
                if (value == true)
                {
                    LottieImage = null;

                    if (StagedQuestion != null)
                    {
                        ElapsedTime = _stopwatch.Elapsed;

                        CurrentQuestion = StagedQuestion;
                        StagedQuestion = null;

                        Continue.Execute(true);
                    }
                    else
                    {
                        Continue.Execute(false);
                    }
                }
            }
        }

        private Answer _selectedAnswer = null;
        public Answer SelectedAnswer
        {
            get => _selectedAnswer;
            private set => SetProperty(ref _selectedAnswer, value);
        }

        private AskedQuestion _currentQuestion = null;
        public AskedQuestion CurrentQuestion
        {
            get => _currentQuestion;
            private set => SetProperty(ref _currentQuestion, value);
        }

        private AskedQuestion _stagedQuestion = null;
        public AskedQuestion StagedQuestion
        {
            get => _stagedQuestion;
            private set => SetProperty(ref _stagedQuestion, value);
        }

        private string _message = null;
        public string Message
        {
            get => _message;
            private set => SetProperty(ref _message, value);
        }

        private SKLottieImageSource _lottieImage = null;
        public SKLottieImageSource LottieImage
        {
            get => _lottieImage;
            set => SetProperty(ref _lottieImage, value);
        }

        private decimal _completion = 0;
        public decimal Completion
        {
            get => _completion;
            private set => SetProperty(ref _completion, value);
        }

        private int _correctAnswers = 0;
        public int CorrectAnswers
        {
            get => _correctAnswers;
            private set => SetProperty(ref _correctAnswers, value);
        }

        private int _wrongAnswers = 0;
        public int WrongAnswers
        {
            get => _wrongAnswers;
            private set => SetProperty(ref _wrongAnswers, value);
        }

        private int _candlesLit = 0;
        public int CandlesLit
        {
            get => _candlesLit;
            set
            {
                SetProperty(ref _candlesLit, value);
                OnPropertyChanged(nameof(AreCandlesLit));
            }
        }
        public bool AreCandlesLit
        {
            get => CandlesLit > 0;
        }

        private int? _startQuestionNumber = null;
        public int? StartQuestionNumber
        {
            get => _startQuestionNumber;
            set => SetProperty(ref _startQuestionNumber, value);
        }

        private int? _endQuestionNumber = null;
        public int? EndQuestionNumber
        {
            get => _endQuestionNumber;
            set => SetProperty(ref _endQuestionNumber, value);
        }

        private bool _readQuestions = false;
        public bool ReadQuestions
        {
            get => _readQuestions;
            set => SetProperty(ref _readQuestions, value);
        }

        private TimeSpan _elapsedTime = default;
        public TimeSpan ElapsedTime
        {
            get => _elapsedTime;
            private set => SetProperty(ref _elapsedTime, value);
        }

        private void CancelQuestionRead()
        {
            SelectedAnswer = null;

            if (_speechCancellationToken != default)
            {
                try
                {
                    _speechCancellationToken.Cancel();

                    _speechTask.Wait();
                    _speechTask.Dispose();
                    _speechTask = null;
                }
                catch(Exception ex)
                {
                    Debug.WriteLine($"An error occurred while cancelling: { ex }");
                }

                _speechCancellationToken = default;
            }
        }

        public void ReadCurrentQuestion()
        {
            if (ReadQuestions == true)
            {
                if (CurrentQuestion != null)
                {
                    CancelQuestionRead();

                    if(_speechTask != null)
                    {
                        throw new Exception("Speech tasks are not cleaned up");
                    }

                    // Read the questions in a task that can be cancelled through the speech cancellation token
                    _speechTask = Task.Run(async () =>
                    {
                        _speechCancellationToken = new CancellationTokenSource();
                        try
                        {
                            await TextToSpeech.Default.SpeakAsync(CurrentQuestion.Question.ReplaceWithPhoneticSpellings(),
                                cancelToken: _speechCancellationToken.Token);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"An error occurred reading question: {ex}");
                        }

                        if (_speechCancellationToken.IsCancellationRequested == false)
                        {

                            foreach (var item in CurrentQuestion.PossibleAnswers)
                            {
                                if (item.NotAttempted)
                                {
                                    item.IsReading = true;
                                    _speechCancellationToken = new CancellationTokenSource();
                                    try
                                    {
                                        SelectedAnswer = item;

                                        await TextToSpeech.Default.SpeakAsync(item.Text.ReplaceWithPhoneticSpellings(),
                                            cancelToken: _speechCancellationToken.Token);
                                    }
                                    catch (Exception ex)
                                    {
                                        Debug.WriteLine($"An error occurred reading answers: {ex}");
                                    }
                                    finally
                                    {
                                        item.IsReading = false;
                                        SelectedAnswer = null;
                                    }

                                    if (_speechCancellationToken.IsCancellationRequested == true)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    });
                }
            }
            else
            {
                Debug.WriteLine($"Question {CurrentQuestion.Number} not read due to user setting");
            }
        }

        public void StopQuestion()
        {
            // PEV - 8/10/2023 - Do not set attempted to 'true' on all possible answers here. It disables the buttons and on Mac Catalyst, it messes up the button styles...

            CancelQuestionRead();
        }

        private async Task CorrectAnswerAsync()
        {
            StopQuestion();

            Message = null;
            CorrectAnswers += 1;

            CandleSparkle?.Execute(null);

            CandleJiggle?.Execute(null);

            CorrectAnswerGiven?.Execute(null);

            Completion += COMPLETION_DELTA;

            bool candleLit = false;
            if (Completion == 1m)
            {
                CandlesLit = CandlesLit + 1;
                Completion = 0m;
                candleLit = true;
            }

            if(candleLit)
            {
                Message = GetCongratMessage();

                MessageThump?.Execute(null);

                Celebration?.Execute(null);
            }

            // Pause before putting up the new quetion to help prevent mis-clicks
            await Task.Delay(250);

            if (!candleLit && IsGoodRole(.3))
            {
                StagedQuestion = _questionProvider.GetNextQuestion(CorrectAnswerAsync, WrongAnswerAsync);

                int index = _random.Next(_successLotties.Count);
                LottieImage = (SKLottieImageSource)_lottieConverter.ConvertFromString(_successLotties[index]);

                // Question is read after animation finishes
            }
            else
            {
                ElapsedTime = _stopwatch.Elapsed;

                CurrentQuestion = _questionProvider.GetNextQuestion(CorrectAnswerAsync, WrongAnswerAsync);

                ReadCurrentQuestion();
            }
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private async Task WrongAnswerAsync(Answer answer)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            answer.Attempted = true;
            Message = "Try again!";
            WrongAnswers += 1;

            WrongAnswerGiven?.Execute(null);

            if (Completion > 0)
            {
                Completion -= COMPLETION_DELTA;
            }

            if (IsGoodRole(.3))
            {
                int index = _random.Next(_failLotties.Count);
                LottieImage = (SKLottieImageSource)_lottieConverter.ConvertFromString(_failLotties[index]);
            }
        }

        private string GetCongratMessage()
        {
            var index = _random.Next(_congratMessages.Count);
            return _congratMessages[index];
        }

        private bool IsGoodRole(double chance)
        {
            return _random.NextDouble() < chance;
        }
    }
}