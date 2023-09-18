using System;
using System.Collections.Generic;

namespace JBQQuizMe.Repository
{
    public class QuestionInfo
    {
        public int Number { get; set; }
        public bool IsQuotation { get; set; }
        public required string Question { get; set; }
        public int AnswerHash { get; set; }
        public required List<string> Answer { get; set; }
        public List<List<string>>? WrongAnswers { get; set; }
        public string? Passage { get; set; }
        public string? Type { get; set; }
    }
}
