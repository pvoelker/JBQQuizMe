using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using JBQQuizMe.Repository;
using JBQQuizMe.ViewModel.Extensions;
using JBQQuizMe.ViewModel.Providers;
using Microsoft.Maui.ApplicationModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

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

        private const decimal COMPLETION_DELTA = 0.1m;

        private const int MAX_ANSWERS = 4;

        private Random _random = new Random();

        private CancellationTokenSource _speechCancellationToken = default;

        private QuestionProvider _questionProvider = null;

        public QuizPage()
        {
        }

        public async Task Initialize()
        {
            _questionProvider = new QuestionProvider(MAX_ANSWERS, StartQuestionNumber, EndQuestionNumber);

            CurrentQuestion = _questionProvider.GetNextQuestion(CorrectAnswer, WrongAnswer);

            await ReadCurrentQuestion();
        }

        #region Commands

        public IRelayCommand MessageThump { get; set; }

        public IRelayCommand CandleSparkle { get; set; }

        public IRelayCommand CandleJiggle { get; set; }

        public IRelayCommand Celebration { get; set; }

        public IRelayCommand CorrectAnswerGiven { get; set; }

        public IRelayCommand WrongAnswerGiven { get; set; }

        public IRelayCommand ShowFrog { get; set; }

        public IRelayCommand ShowRainCloud { get; set; }

        #endregion

        private AskedQuestion _currentQuestion = null;
        public AskedQuestion CurrentQuestion
        {
            get => _currentQuestion;
            private set => SetProperty(ref _currentQuestion, value);
        }

        private string _message = null;
        public string Message
        {
            get => _message;
            private set => SetProperty(ref _message, value);
        }

        private string _largeMessage = null;
        public string LargeMessage
        {
            get => _largeMessage;
            set => SetProperty(ref _largeMessage, value);
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

        private void CancelQuestionRead()
        {
            if (_speechCancellationToken != default)
            {
                _speechCancellationToken.Cancel();
            }
        }

        private async Task ReadCurrentQuestion()
        {
            if (ReadQuestions == true)
            {
                if (CurrentQuestion != null)
                {
                    CancelQuestionRead();

                    _speechCancellationToken = new CancellationTokenSource();
                    await TextToSpeech.Default.SpeakAsync(CurrentQuestion.Question.ReplaceWithPhoneticSpellings(),
                        cancelToken: _speechCancellationToken.Token);

                    foreach (var item in CurrentQuestion.PossibleAnswers)
                    {
                        if (item.NotAttempted)
                        {
                            item.IsReading = true;
                            _speechCancellationToken = new CancellationTokenSource();
                            await TextToSpeech.Default.SpeakAsync(item.Text.ReplaceWithPhoneticSpellings(),
                                cancelToken: _speechCancellationToken.Token);
                            item.IsReading = false;
                        }
                    }
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"Question {CurrentQuestion.Number} not read due to user setting");
            }
        }

        private async Task CorrectAnswer()
        {
            // Prevent answer from being re-clicked
            foreach(var item in CurrentQuestion.PossibleAnswers)
            {
                item.Attempted = true;
            }

            CancelQuestionRead();

            Message = null;
            CorrectAnswers += 1;

            if (CandleSparkle != null)
            {
                CandleSparkle.Execute(null);
            }

            if (CandleJiggle != null)
            {
                CandleJiggle.Execute(null);
            }

            if(CorrectAnswerGiven != null)
            {
                CorrectAnswerGiven.Execute(null);
            }

            if (IsGoodRole(.3))
            {
                if (ShowRainCloud != null)
                {
                    LargeMessage = "Poke the rain cloud to keep it away from the candle!";
                    ShowRainCloud.Execute(null);
                }
            }

            Completion += COMPLETION_DELTA;

            if (Completion == 1m)
            {
                Message = GetCongratMessage();

                if (MessageThump != null)
                {
                    MessageThump.Execute(null);
                }

                if (Celebration != null)
                {
                    Celebration.Execute(null);
                }

                CandlesLit = CandlesLit + 1;
                Completion = 0m;
            }

            // Pause before putting up the new quetion to help prevent mis-clicks
            await Task.Delay(250);

            CurrentQuestion = _questionProvider.GetNextQuestion(CorrectAnswer, WrongAnswer);
            await ReadCurrentQuestion();
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private async Task WrongAnswer(Answer answer)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            answer.Attempted = true;
            Message = "Try again!";
            WrongAnswers += 1;

            if (WrongAnswerGiven != null)
            {
                WrongAnswerGiven.Execute(null);
            }

            if (Completion > 0)
            {
                Completion -= COMPLETION_DELTA;
            }

            if (IsGoodRole(.3))
            {
                if (ShowFrog != null)
                {
                    LargeMessage = "Poke the frog away!";
                    ShowFrog.Execute(null);
                }
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