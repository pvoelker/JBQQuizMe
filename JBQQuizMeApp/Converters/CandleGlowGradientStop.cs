using System;

namespace JBQQuizMeApp.Converters
{
    public class CandleGlowGradientStop : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var decimalVal = (decimal)value;

            return decimalVal + 0.25m;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
