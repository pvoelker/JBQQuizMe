using System;

namespace JBQQuizMeApp.Converters
{
    public class TextLengthToFontSize : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var strVal = (string)value;
            var strValLen = strVal.Length;

            decimal origSize;
            if (strValLen > 50)
            {
                origSize = 16m;
            }
            else if(strValLen > 25)
            {
                origSize = 18m;
            }
            else if (strValLen > 10)
            {
                origSize = 22m;
            }
            else
            {
                origSize = 26m;
            }

            return AdjustFontSize(origSize);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private decimal AdjustFontSize(decimal value)
        {
            if (DeviceInfo.Current.Platform == DevicePlatform.MacCatalyst)
            {
                // On MacOS on Catalyst the fonts are artificially 30% smaller, correct for this...
                return value / 0.7m;
            }

            return value;
        }
    }
}
