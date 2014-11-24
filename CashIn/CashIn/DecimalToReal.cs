using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;

namespace CashIn.Converters
{
    class DecimalToReal : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {                       
            if (value != null)
            {
                return String.Format("{0:C}", (decimal)value);
            }
            else return String.Format("{0:C}", 0);
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                try
                {
                    return Decimal.Parse((string)value, NumberStyles.Currency);
                }
                catch (Exception)
                {
                    
                    return 0;
                }
            }
            else return 0;
            
        }
    }
}
