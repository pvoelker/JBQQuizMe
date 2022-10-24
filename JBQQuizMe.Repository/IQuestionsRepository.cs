using System;
using System.Collections.Generic;

namespace JBQQuizMe.Repository
{
    // Inteface definition for quiz question repository
    public interface IQuestionRepository
    {
        /// <summary>
        /// Get maximum question number
        /// </summary>
        /// <returns>Maximum question number</returns>
        int GetMaxNumber();

        /// <summary>
        /// Get all questions
        /// </summary>
        /// <returns>An enumerable of all questions</returns>
        IEnumerable<QuestionInfo> GetAll();

        /// <summary>
        /// Get a single question by the question number
        /// </summary>
        /// <param name="number">The question number to retrieve</param>
        /// <returns>A question</returns>
        QuestionInfo GetByNumber(int number);

        /// <summary>
        /// Get all questions by question type
        /// </summary>
        /// <param name="type">The question type to retrieve</param>
        /// <returns>An enumerable of questions</returns>
        IEnumerable<QuestionInfo> GetByType(string type);
    }
}
