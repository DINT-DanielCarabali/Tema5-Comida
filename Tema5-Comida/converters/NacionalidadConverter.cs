using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Tema5_Comida.converters
{
    class NacionalidadConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                switch (value.ToString().ToUpper())
                {
                    case "CHINA":
                        return new Uri("./assets/china.png", UriKind.Relative);
                    case "AMERICANA":
                        return new Uri("./assets/united_states.png", UriKind.Relative);
                    case "MEXICANA":
                        return new Uri("./assets/mexico.png", UriKind.Relative);
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
