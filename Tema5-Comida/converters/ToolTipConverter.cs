using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace Tema5_Comida.converters
{
    class ToolTipConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                switch (value.ToString().ToUpper())
                {
                    case "CHINA":
                        return new ToolTip().Content = "Comida china";
                    case "AMERICANA":
                        return new ToolTip().Content = "Comida americana";
                    case "MEXICANA":
                        return new ToolTip().Content = "Comida mexicana";
                }
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}