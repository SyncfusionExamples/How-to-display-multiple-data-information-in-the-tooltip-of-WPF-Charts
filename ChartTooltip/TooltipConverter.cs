using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ChartTooltip
{
    public class TooltipConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Model model = (value as ChartSegment).Item as Model;
            return string.Format("{0}, {1}", model.Country, model.Population.ToString("#M"));

            //Here ‘Item’ retrieves the corresponding data point model instance to get the required values.
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
