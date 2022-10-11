using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBQQuizMe.ViewModel
{
    /// <summary>
    /// A possible answer to a question
    /// </summary>
    public class Answer : ObservableObject
    {
        private string _text = null;
        /// <summary>
        /// Text for the answer
        /// </summary>
        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        private bool _isCorrect = false;
        /// <summary>
        /// True if this is the correct answer for a question, otherwise false
        /// </summary>
        public bool IsCorrect
        {
            get => _isCorrect;
            set => SetProperty(ref _isCorrect, value);
        }

        private bool _attempted = false;
        /// <summary>
        /// True if the answer selected as the possible correct answer, otherwise false
        /// </summary>
        public bool Attempted
        {
            get => _attempted;
            set
            {
                SetProperty(ref _attempted, value);
                OnPropertyChanged(nameof(NotAttempted));
            }
        }

        /// <summary>
        /// False if the answer selected as the possible correct answer, otherwise true
        /// </summary>
        public bool NotAttempted
        {
            get => !_attempted;
        }

        private bool _isReading = false;
        /// <summary>
        /// True if the answer is being read, otherwise false
        /// </summary>
        public bool IsReading
        {
            get => _isReading;
            set => SetProperty(ref _isReading, value);
        }

        #region Commands

        /// <summary>
        /// Command for when the answer is selected as the possible correct answer
        /// </summary>
        public IRelayCommand Clicked { get; set; }

        #endregion
    }
}
