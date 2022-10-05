using System;

namespace JBQQuizMeApp.Converters
{
    public class TextLengthToFontSize : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var strVal = (string)value;
            var strValLen = strVal.Length;

            var fontSizeConverter = new FontSizeConverter();

            if (strValLen > 50)
            {
                return fontSizeConverter.ConvertFromString("Micro");

            }
            else if(strValLen > 25)
            {
                return fontSizeConverter.ConvertFromString("Small");

            }
            else
            {
                return fontSizeConverter.ConvertFromString("Medium");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
