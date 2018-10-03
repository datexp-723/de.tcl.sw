using de.tcl.sw.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace de.tcl.sw.Converters
{
    public class InspectionTypeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            InspectionType inspectionType = (InspectionType)value;
            switch (inspectionType)
            {
                case InspectionType.NotDefined:
                    return "TÜV + SP";
                case InspectionType.TÜV:
                    return "TÜV";
                case InspectionType.SP:
                    return "SP";
                default:
                    return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
