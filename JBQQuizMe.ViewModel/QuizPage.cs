using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using JBQQuizMe.Repository;
using JBQQuizMe.ViewModel.Extensions;
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
            "You are awesome!"
        };

        private const decimal COMPLETION_DELTA = 0.05m;

        private const int MAX_QUESTIONS = 4;

        private QuestionsRepository _repository = new QuestionsRepository();

        private Random _random = new Random();

        private Dictionary<int, int> _timesAsked = new Dictionary<int, int>();

        public QuizPage()
        {
        }

        public void Initialize()
        {
            if (StartQuestionNumber.HasValue && EndQuestionNumber.HasValue)
            {
                for (int i = StartQuestionNumber.Value; i <= EndQuestionNumber.Value; i++)
                {
                    _timesAsked.Add(i, 0);
                }
            }
            else
            {
                int maxQuestionNumber = _repository.GetMaxNumber();

                for (int i = 1; i <= maxQuestionNumber; i++)
                {
                    _timesAsked.Add(i, 0);
                }
            }

            CurrentQuestion = GetNextQuestion();
        }

        #region Commands

        public IRelayCommand CandleJiggle { get; set; }

        public IRelayCommand Celebration { get; set; }

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

        private AskedQuestion GetNextQuestion()
        {
            if(_timesAsked.Count() < 0)
            {
                throw new InvalidOperationException($"'{nameof(Initialize)}' has not been called");
            }

            var minTimesAsked = _timesAsked.Min(x => x.Value);

            var nextNumber = GetNextQuestionNumber();

            while (1 == 1)
            {
                int timesAsked = 0;
                if(_timesAsked.TryGetValue(nextNumber, out timesAsked))
                {
                    if(timesAsked <= minTimesAsked)
                    {
                        _timesAsked[nextNumber] = timesAsked + 1;
                        break;
                    }
                    else
                    {
                        nextNumber = GetNextQuestionNumber();
                    }
                }
                else
                {
                    throw new InvalidOperationException("Question number not found in asked count tracking");
                }
            }

            var question = _repository.GetByNumber(nextNumber);

            var retVal = new AskedQuestion
            {
                Number = question.Number,
                Question = question.Question,
                Passage = question.Passage,
                CorrectAnswer = new Answer
                {
                    Text = FormatList(question.Answer),
                    IsCorrect = true,
                }
            };

            retVal.CorrectAnswer.Clicked = new RelayCommand(() => CorrectAnswer());

            retVal.PossibleAnswers = new List<Answer>();
            if (question.Type != null)
            {
                var otherQuestions = _repository.GetByType(question.Type);

                foreach(var item in otherQuestions.Where(x => FormatList(x.Answer) != retVal.CorrectAnswer.Text))
                {
                    var newAnswer = new Answer
                    {
                        Text = FormatList(item.Answer),
                        IsCorrect = false
                    };

                    newAnswer.Clicked = new RelayCommand(() => WrongAnswer(newAnswer));

                    retVal.PossibleAnswers.Add(newAnswer);
                }
            }
            else
            {
                foreach (var item in question.WrongAnswers)
                {
                    var newAnswer = new Answer
                    {
                        Text = FormatList(item),
                        IsCorrect = false
                    };

                    newAnswer.Clicked = new RelayCommand(() => WrongAnswer(newAnswer));

                    retVal.PossibleAnswers.Add(newAnswer);
                }
            }

            retVal.PossibleAnswers.Shuffle();
            retVal.PossibleAnswers = retVal.PossibleAnswers.Take(MAX_QUESTIONS - 1).ToList();

            retVal.PossibleAnswers.Add(retVal.CorrectAnswer);
            retVal.PossibleAnswers.Shuffle();

            return retVal;
        }

        private int GetNextQuestionNumber()
        {
            if (StartQuestionNumber.HasValue && EndQuestionNumber.HasValue)
            {
                return _random.Next(StartQuestionNumber.Value, EndQuestionNumber.Value + 1);
            }
            else
            {
                int max = _repository.GetMaxNumber();

                return _random.Next(1, max + 1);
            }
        }

        private void CorrectAnswer()
        {
            CurrentQuestion = GetNextQuestion();
            Message = null;
            CorrectAnswers += 1;

            if (CandleJiggle != null)
            {
                CandleJiggle.Execute(null);
            }

            Completion += COMPLETION_DELTA;

            if (Completion == 1m)
            {
                Message = GetCongratMessage();

                if(Celebration != null)
                {
                    Celebration.Execute(null);
                }

                Completion = 0m;
            }
        }

        private void WrongAnswer(Answer answer)
        {
            answer.Attempted = true;
            Message = "Try again!";
            WrongAnswers += 1;

            if(Completion > 0)
            {
                Completion -= COMPLETION_DELTA;
            }
        }

        private static string FormatList(IEnumerable<string> list)
        {
            return string.Join(", ", list);
        }

        private string GetCongratMessage()
        {
            var index = _random.Next(_congratMessages.Count);
            return _congratMessages[index];
        }
    }
}