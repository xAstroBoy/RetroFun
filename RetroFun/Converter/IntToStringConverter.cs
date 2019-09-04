using System;
using System.Globalization;

using RetroFun.Helpers;

namespace RetroFun.Converter
{
    public class IntToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) 
            => value.ToString();
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => int.TryParse((string)value, out int ret) ? ret : -1;
    }
}
