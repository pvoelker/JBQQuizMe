using System;

namespace JBQQuizMeApp.Converters
{
    public class TextNotNullOrEmptyToBool : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var strVal = (string)value;

            return !string.IsNullOrEmpty(strVal);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
