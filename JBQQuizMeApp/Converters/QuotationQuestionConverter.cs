using System;
using System.Globalization;

namespace JBQQuizMeApp.Converters
{
    public class QuotationQuestionConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var retVal = $"'{nameof(QuotationQuestionConverter)}' failed";

            if (values.Length == 2 || values[0] != null || values[1] != null)
            {
                var isQuotation = values[0] as bool?;
                var questionText = values[1] as string;
               
                if (isQuotation != null && questionText != null)
                {
                    if(isQuotation.Value)
                    {
                        retVal = "QUOTATION: " + questionText;
                    }
                    else
                    {
                        retVal = questionText;
                    }
                }
            }

            return retVal;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
