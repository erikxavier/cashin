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
            decimal? valor = (decimal)value;            
            if (valor != null)
            {
                return String.Format("{0:C}", valor);
            }
            else return String.Format("{0:C}", 0);
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                return Decimal.Parse((string)value, NumberStyles.Currency);
            }
            else return 0;
            
        }
    }
}
