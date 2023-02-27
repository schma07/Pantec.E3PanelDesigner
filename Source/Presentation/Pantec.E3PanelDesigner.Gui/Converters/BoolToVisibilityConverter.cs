using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows;

namespace Pantec.E3PanelDesigner.Converters
{
    public class BoolToVisibilityConverter : MarkupConverterBase
    {
        [ConstructorArgument("TrueValue")]
        public Visibility TrueValue { get; set; }

        [ConstructorArgument("FalseValue")]
        public Visibility FalseValue { get; set; }

        [ConstructorArgument("NullValue")]
        public Visibility NullValue { get; set; }

        public BoolToVisibilityConverter()
        {
            TrueValue = Visibility.Visible;
            FalseValue = Visibility.Collapsed;
            NullValue = Visibility.Collapsed;
        }

        protected override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return NullValue;

            if (!(value is bool?))
                return null;

            return (bool)value ? TrueValue : FalseValue;
        }

        protected override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Equals(value, TrueValue))
                return true;
            if (Equals(value, FalseValue))
                return false;
            return null;
        }
    }
}
