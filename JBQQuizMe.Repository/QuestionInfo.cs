using System;
using System.Collections.Generic;

namespace JBQQuizMe.Repository
{
    public class QuestionInfo
    {
        public int Number { get; set; }
        public string Question { get; set; }
        public int AnswerHash { get; set; }
        public List<string> Answer { get; set; }
        public List<List<string>>? WrongAnswers { get; set; }
        public string? Passage { get; set; }
        public string? Type { get; set; }
    }
}
