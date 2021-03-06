﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Demo_CircleFitter.Converters
{
    /// <summary>
    /// 布尔值转换为可见性
    /// </summary>
    public class DoubleFormatF3Converter : IValueConverter
    {
        ///当界面的绑定到DataContext中的属性发生变化时，会调用该方法，将绑定的bool值转换为界面需要的Visibility类型的值
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((double)value).ToString("F3");
        }

        ///当界面的Visibility值发生变化时，会调用该方法，将Visibility类型的值转换为bool值返回给绑定到DataContext中的属性
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double v = 0;
            bool n = double.TryParse((string)value, out v);
            return v;
        }
    }
}
