using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionImporterApp.Validations
{
    public interface IValidation
    {
        string Name { get; }

        IEnumerable<string> Validate(IEnumerable<QuestionSheetRow> rows);
    }
}
