using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionImporterApp.Validations
{
    public class MinimumTypeSize : IValidation
    {
        public string Name { get => "Questions types must have at least four (4) questions"; }

        public IEnumerable<string> Validate(IEnumerable<QuestionSheetRow> rows)
        {
            var problems = rows.Where(x => !string.IsNullOrEmpty(x.Type)).GroupBy(x => x.Type).Where(x => x.Count() < 4);

            return problems.Select(x => $"Question type '{x.First().Type}' has fewer than four (4) questions asssocated with it").ToList();
        }
    }
}
