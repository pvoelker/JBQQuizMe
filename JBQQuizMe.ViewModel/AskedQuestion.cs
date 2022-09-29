using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBQQuizMe.ViewModel
{
    /// <summary>
    /// A question to ask
    /// </summary>
    public class AskedQuestion : ObservableObject
    {
        private int _number;
        /// <summary>
        /// JBQ Question Number
        /// </summary>
        public int Number
        {
            get => _number;
            set => SetProperty(ref _number, value);
        }

        private string _question;
        /// <summary>
        /// Question text
        /// </summary>
        public string Question
        {
            get => _question;
            set => SetProperty(ref _question, value);
        }

        private List<Answer> _possibleAnswers;
        /// <summary>
        /// List of possible answers
        /// </summary>
        public List<Answer> PossibleAnswers
        {
            get => _possibleAnswers;
            set => SetProperty(ref _possibleAnswers, value);
        }

        private Answer _correctAnswer;
        /// <summary>
        /// Correct answer text
        /// </summary>
        public Answer CorrectAnswer
        {
            get => _correctAnswer;
            set => SetProperty(ref _correctAnswer, value);
        }

        private string _passage;
        /// <summary>
        /// Passage reference for the question
        /// </summary>
        public string Passage
        {
            get => _passage;
            set
            {
                SetProperty(ref _passage, value);
                OnPropertyChanged(nameof(IsPassagePresent));
            }
        }

        public bool IsPassagePresent
        {
            get => Passage != null;
        }
    }
}
