using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BetterBuses.View.WinPhone.Converters
{
    /// <summary>
    /// Converts an image path into an ImageBrush.
    /// </summary>
    public class ImagePathConverter : IValueConverter 
    {
        /// <summary>
        /// Given a string containing the path to some image, build up an
        /// ImageBrush containing that image.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;

            // Build up a new ImageBrush.
            Uri imagePath = new Uri(value.ToString(), UriKind.RelativeOrAbsolute);
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(imagePath);
            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Not implemented.");
        }
    }
}
