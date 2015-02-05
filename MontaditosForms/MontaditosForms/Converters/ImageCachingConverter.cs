using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MontaditosForms.Converters
{
    public class ImageCachingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }
            if (Device.OS == TargetPlatform.WinPhone)
            {
                var image = value.ToString();

                return new UriImageSource
                {
                    Uri = new Uri(image),
                    CachingEnabled = false,
                };
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
