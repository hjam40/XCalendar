﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace XCalendar.Forms.Converters
{
    public class StringCharLimitConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                string stringValue = value.ToString();
                int targetLength = System.Convert.ToInt32(parameter);

                if (targetLength == 0)
                {
                    return "";
                }
                else if (targetLength >= stringValue.Length)
                {
                    return stringValue;
                }
                else
                {
                    return stringValue.Substring(0, targetLength);
                }
            }
            catch
            {
                return "";
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
