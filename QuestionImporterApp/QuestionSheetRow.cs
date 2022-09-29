using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionImporterApp
{
    public class QuestionSheetRow
    {
        public int Number { get; set; }
        public string Question { get; set; }
        public string OriginalAnswer { get; set; }
        public bool IsOriginalAnswerList { get => OriginalAnswer.Contains('|'); }
        public string[] OriginalAnswersAsList() { return OriginalAnswer.Split('|'); }
        public string Answer { get; set; }
        public bool IsAnswerList { get => Answer.Contains('|'); }
        public string[] AnswersAsList() { return Answer.Split('|'); }
        public string WrongAnswers { get; set; }
        public bool HasWrongAnswers { get => !string.IsNullOrEmpty(WrongAnswers); }
        public string[] WrongAnswersAsList() { return string.IsNullOrEmpty(WrongAnswers) ? null : WrongAnswers.Split('|'); }
        public string Passage { get; set; }
        public string OTNT { get; set; }
        public string Theme { get; set; }
        public string Type { get; set; }
    }
}
