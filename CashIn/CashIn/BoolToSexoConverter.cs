using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;

namespace CashIn.Converters
{
    public class BoolToSexoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            //if (value != null)
            //{
            //    if ((bool)value == true) return "M";
            //    else return "F";
            //}
            //else return "M";
            if (value != null)
            {
                if (value.ToString() == "M") return true;
                else return false;
            }
            else return true;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((bool)value == true) return "M";
                else return "F";
            }
            else return "M";
            //if (value != null)
            //{
            //    if (value.ToString() == "M") return true;
            //    else return false;
            //}
            //else return true;
        }
    }
}
