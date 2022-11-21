using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Tema5_Comida.converters
{
    class FuenteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                switch (value.ToString().ToUpper())
                {
                    case "CHINA":
                        return new FontFamily("Chinese Wok Food St");
                    case "AMERICANA":
                        return new FontFamily("Slim Summer");
                    case "MEXICANA":
                        return new FontFamily("Taco Salad");
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