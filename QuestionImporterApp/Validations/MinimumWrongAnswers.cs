﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionImporterApp.Validations
{
    public class MinimumWrongAnswers : IValidation
    {
        public string Name { get => "Check for a minimum number of wrong answers provided"; }

        public IEnumerable<string> Validate(IEnumerable<QuestionSheetRow> rows)
        {
            var problems = rows.Where(x => x.HasWrongAnswers).Where(x => x.WrongAnswersAsList().Count() < 3);

            return problems.Select(x => $"Question '{x.Number}' has fewer than three (3) wrong answers asssocated with it").ToList();
        }
    }
}
