using System;
using System.Collections.Generic;

namespace JBQQuizMe.Repository
{
    // Interface definition for quiz question repository
    public interface IQuestionRepository
    {
        /// <summary>
        /// Get minimum question number
        /// </summary>
        /// <returns>Minimum question number</returns>
        int GetMinNumber();

        /// <summary>
        /// Get maximum question number
        /// </summary>
        /// <returns>Maximum question number</returns>
        int GetMaxNumber();

        /// <summary>
        /// Get a single question by the question number
        /// </summary>
        /// <param name="number">The question number to retrieve</param>
        /// <returns>A question</returns>
        QuestionInfo? GetByNumber(int number);

        /// <summary>
        /// Get all questions by question type
        /// </summary>
        /// <param name="type">The question type to retrieve</param>
        /// <returns>An enumerable of questions</returns>
        IEnumerable<QuestionInfo> GetByType(string type);
    }
}
