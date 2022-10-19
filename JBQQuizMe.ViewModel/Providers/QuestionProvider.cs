using CommunityToolkit.Mvvm.Input;
using JBQQuizMe.Repository;
using JBQQuizMe.ViewModel.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBQQuizMe.ViewModel.Providers
{
    // Provider for JBQ questions to ask
    public class QuestionProvider
    {
        private readonly Random _random = new Random();

        private readonly Dictionary<int, int> _timesAsked = new Dictionary<int, int>();

        private readonly QuestionsRepository _repository = new QuestionsRepository();

        private readonly int _maxAnswers;

        private readonly int? _startQuestionNumber, _endQuestionNumber;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="maxAnswers">Maximum number of answers to provide with a question. One answer will be the correct one</param>
        /// <param name="startQuestionNumber">Starting question number. Null if no limit</param>
        /// <param name="endQuestionNumber">Ending question number. Null if no limit</param>
        /// <exception cref="ArgumentOutOfRangeException">One of the constructor arguments has an invalid value</exception>
        /// <remarks>Both start and end question number must be provided or both must be null.</remarks>
        public QuestionProvider(int maxAnswers, int? startQuestionNumber, int? endQuestionNumber)
        {
            if (maxAnswers <= 2)
            {
                new ArgumentOutOfRangeException(nameof(maxAnswers), "Two or more answers must be provided with a question");
            }

            _maxAnswers = maxAnswers;
            _startQuestionNumber = startQuestionNumber;
            _endQuestionNumber = endQuestionNumber;

            if (_startQuestionNumber.HasValue && _endQuestionNumber.HasValue)
            {
                for (int i = _startQuestionNumber.Value; i <= _endQuestionNumber.Value; i++)
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
        }

        /// <summary>
        /// Gets the next question
        /// </summary>
        /// <param name="correctAnswer">Command to associate with the correct answer</param>
        /// <param name="wrongAnswer">Command to associate with the wrong answers</param>
        /// <returns>A question with a correct answer and one or more wrong answers</returns>
        /// <exception cref="InvalidOperationException">Question was not found in question number tracking</exception>
        public AskedQuestion GetNextQuestion(Func<Task> correctAnswer, Func<Answer, Task> wrongAnswer)
        {
            var minTimesAsked = _timesAsked.Min(x => x.Value);

            var nextNumber = GetNextQuestionNumber();

            while (1 == 1)
            {
                int timesAsked = 0;
                if (_timesAsked.TryGetValue(nextNumber, out timesAsked))
                {
                    if (timesAsked <= minTimesAsked)
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

            retVal.CorrectAnswer.Clicked = new AsyncRelayCommand(async () => await correctAnswer());

            retVal.PossibleAnswers = new List<Answer>();
            if (question.Type != null)
            {
                var otherQuestions = _repository.GetByType(question.Type).Where(x => x.Number != question.Number);

                foreach (var item in otherQuestions.Where(x => FormatList(x.Answer) != retVal.CorrectAnswer.Text))
                {
                    var newAnswer = new Answer
                    {
                        Text = FormatList(item.Answer),
                        IsCorrect = false
                    };

                    newAnswer.Clicked = new RelayCommand(async () => await wrongAnswer(newAnswer));

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

                    newAnswer.Clicked = new RelayCommand(async () => await wrongAnswer(newAnswer));

                    retVal.PossibleAnswers.Add(newAnswer);
                }
            }

            retVal.PossibleAnswers.Shuffle();
            retVal.PossibleAnswers = retVal.PossibleAnswers.Take(_maxAnswers - 1).ToList();

            retVal.PossibleAnswers.Add(retVal.CorrectAnswer);
            retVal.PossibleAnswers.Shuffle();

            return retVal;
        }
        
        /// <summary>
        /// Format a list into a comma separated list string
        /// </summary>
        /// <param name="list">List to convert</param>
        /// <returns>Comma separated string</returns>
        public static string FormatList(IEnumerable<string> list)
        {
            return string.Join(", ", list);
        }

        private int GetNextQuestionNumber()
        {
            if (_startQuestionNumber.HasValue && _endQuestionNumber.HasValue)
            {
                return _random.Next(_startQuestionNumber.Value, _endQuestionNumber.Value + 1);
            }
            else
            {
                int max = _repository.GetMaxNumber();

                return _random.Next(1, max + 1);
            }
        }
    }
}
