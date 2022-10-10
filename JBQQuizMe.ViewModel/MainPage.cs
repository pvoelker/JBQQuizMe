using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using JBQQuizMe.Repository;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace JBQQuizMe.ViewModel
{
    // All the code in this file is included in all platforms.
    public class MainPage : ObservableValidator
    {
        public MainPage()
        {
            var repository = new QuestionsRepository();

            MaxQuestionNumber = repository.GetMaxNumber();

            ReadQuestions = Preferences.Default.Get(PreferenceKeys.ReadQuestions, true);

            try
            {
                var assembly = Assembly.GetEntryAssembly();

                if (assembly != null)
                {
                    Version = assembly.GetName().Version;
                    object[] attribs = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), true);
                    if (attribs.Length > 0)
                    {
                        Copyright = ((AssemblyCopyrightAttribute)attribs[0]).Copyright;
                    }
                    else
                    {
                        Copyright = "ERROR: Unable to get copyright";
                    }
                }
                else
                {
                    Version = null;
                    Copyright = null;
                }
            }
            catch
            {
                throw; // Ignore exception and move on, we will hit this on Android
            }
        }

        #region Commands

        #endregion

        public bool IsVersionInfoPresent
        {
            get => Version != null;
        }

        private Version _version;
        public Version Version
        {
            get => _version;
            private set
            {
                SetProperty(ref _version, value);
                OnPropertyChanged(nameof(IsVersionInfoPresent));
            }
        }

        private string _copyright;
        public string Copyright
        {
            get => _copyright;
            private set => SetProperty(ref _copyright, value);
        }

        private int _maxQuestionNumber;
        public int MaxQuestionNumber
        {
            get => _maxQuestionNumber;
            private set => SetProperty(ref _maxQuestionNumber, value);
        }

        private string _startQuestionNumber = null;
        [CustomValidation(typeof(MainPage), nameof(ValidateQuestionRange))]
        public string StartQuestionNumberStr
        {
            get => _startQuestionNumber;
            set
            {
                SetProperty(ref _startQuestionNumber, value, true);
                ValidateProperty(EndQuestionNumberStr, nameof(EndQuestionNumberStr));
                OnPropertyChanged(nameof(StartQuestionNumber));
            }
        }
        public int? StartQuestionNumber
        {
            get
            {
                if (int.TryParse(_startQuestionNumber, out int intVal))
                {
                    return intVal;
                }
                else
                {
                    return null;
                }
            }
        }

        private string _endQuestionNumber = null;
        [CustomValidation(typeof(MainPage), nameof(ValidateQuestionRange))]
        public string EndQuestionNumberStr
        {
            get => _endQuestionNumber;
            set
            {
                SetProperty(ref _endQuestionNumber, value, true);
                ValidateProperty(StartQuestionNumberStr, nameof(StartQuestionNumberStr));
                OnPropertyChanged(nameof(EndQuestionNumber));
            }
        }
        public int? EndQuestionNumber
        {
            get
            {
                if (int.TryParse(_endQuestionNumber, out int intVal))
                {
                    return intVal;
                }
                else
                {
                    return null;
                }
            }
        }

        private bool _readQuestions = true;
        public bool ReadQuestions
        {
            get => _readQuestions;
            set
            {
                Preferences.Default.Set(PreferenceKeys.ReadQuestions, value);
                SetProperty(ref _readQuestions, value);
            }
        }

        public static ValidationResult ValidateQuestionRange(string name, ValidationContext context)
        {
            var instance = (MainPage)context.ObjectInstance;

            if (instance.StartQuestionNumber.HasValue && (instance.StartQuestionNumber <= 0))
            {
                return new("Start question number must be greater than 0");
            }
            else if (instance.EndQuestionNumber.HasValue && (instance.EndQuestionNumber <= 0))
            {
                return new("End question number must be greater than 0");
            }
            else if (instance.StartQuestionNumber.HasValue && (instance.StartQuestionNumber > instance.MaxQuestionNumber))
            {
                return new($"Start question number must be equal to or less than {instance.MaxQuestionNumber}. This game only uses 10 point questions from the Bible Fact-Pak™.");
            }
            else if (instance.EndQuestionNumber.HasValue && (instance.EndQuestionNumber > instance.MaxQuestionNumber))
            {
                return new($"End question number must be equal to or less than {instance.MaxQuestionNumber}. This game only uses 10 point questions from the Bible Fact-Pak™.");
            }
            else if ((instance.StartQuestionNumber.HasValue && instance.StartQuestionNumber.Value != 0)
                ^ (instance.EndQuestionNumber.HasValue && instance.EndQuestionNumber.Value != 0))
            {
                return new($"If specifying a question range, both 'start' and 'end' must be provided");
            }
            else if(instance.StartQuestionNumber >= instance.EndQuestionNumber)
            {
                return new("Start question number must be less than the end question number");
            }
            else if((instance.EndQuestionNumber - instance.StartQuestionNumber + 1) < 10)
            {
                return new("Range of questions must be equal to or greater than 10");
            }

            return ValidationResult.Success;
        }
    }
}