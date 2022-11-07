using CommunityToolkit.Mvvm.Input;
using JBQQuizMe.Repository;
using JBQQuizMe.ViewModel.Extensions;
using System;
using System.Security.Cryptography;
using System.Text;

namespace JBQQuizMe.ViewModel.Providers
{
    /// <summary>
    /// Provider for JBQ questions to ask
    /// </summary>
    public class QuestionProvider
    {
        private const string _key = "B4A+hTqHIARBmwTiFODHqw==";

        private readonly Random _random = new Random();

        private readonly Dictionary<int, int> _timesAsked = new Dictionary<int, int>();

        private readonly IQuestionRepository _repository;

        private readonly int _maxAnswers;

        private readonly int? _startQuestionNumber, _endQuestionNumber;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository">An instance of the question repository interface</param>
        /// <param name="maxAnswers">Maximum number of answers to provide with a question. One answer will be the correct one</param>
        /// <param name="startQuestionNumber">Starting question number. Null if no limit</param>
        /// <param name="endQuestionNumber">Ending question number. Null if no limit</param>
        /// <exception cref="ArgumentNullException">An invalid constructor argument was given, see exeception information</exception>
        /// <exception cref="ArgumentOutOfRangeException">One of the constructor arguments has an invalid value</exception>
        /// <remarks>Both start and end question number must be provided or both must be null.</remarks>
        public QuestionProvider(IQuestionRepository repository, int maxAnswers, int? startQuestionNumber, int? endQuestionNumber)
        {
            if (repository == null)
            {
                throw new ArgumentNullException(nameof(repository), "A repository instance must be provided");
            }

            if (maxAnswers <= 2)
            {
                throw new ArgumentOutOfRangeException(nameof(maxAnswers), "Two or more answers must be provided with a question");
            }

            _repository = repository;
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
                Question = DecryptString(_key, question.Question),
                Passage = question.Passage,
                CorrectAnswer = new Answer
                {
                    Text = FormatList(question.Answer.Select(x => DecryptString(_key, x))),
                    IsCorrect = true,
                }
            };

            retVal.CorrectAnswer.Clicked = new AsyncRelayCommand(async () => await correctAnswer());

            retVal.PossibleAnswers = new List<Answer>();
            if (question.Type != null)
            {
                var otherQuestions = _repository.GetByType(question.Type)
                    .Where(x => x.Number != question.Number)
                    .DistinctBy(x => x.AnswerHash);

                foreach (var item in otherQuestions.Where(x => x.AnswerHash != question.AnswerHash))
                {
                    var newAnswer = new Answer
                    {
                        Text = FormatList(item.Answer.Select(x => DecryptString(_key, x))),
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
                        Text = FormatList(item.Select(x => DecryptString(_key, x))),
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

        private static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (var aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (var memoryStream = new MemoryStream(buffer))
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (var streamReader = new StreamReader(cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
