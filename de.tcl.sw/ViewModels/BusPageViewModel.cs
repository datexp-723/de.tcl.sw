using de.tcl.common.entities.Mvvm;
using de.tcl.sw.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace de.tcl.sw.ViewModels
{
    public class BusPageViewModel : ViewModelBase<Bus>
    {

        private Bus _bus;

        public Bus Bus
        {
            get { return _bus; }
            set
            {
                if (value != _bus)
                {
                    _bus = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(BusImage));
                }
            }
        }

        public ImageSource BusImage
        {
            get
            {
                if (Bus != null)
                {
                    switch (Bus.FormType.VehicleType)
                    {
                        case VehicleType.EvoBus_MB_O_530_2005:
                            return ImageSource.FromResource("de.tcl.sw.Resources.EvoBus_MB_O_530_(2005).jpg");

                        case VehicleType.EvoBus_MB_O_530_2007:
                            return ImageSource.FromResource("de.tcl.sw.Resources.EvoBus_MB_O_530_(2007).jpg");

                        case VehicleType.MAN_Lions_City_2008:
                            return ImageSource.FromResource("de.tcl.sw.Resources.MAN_Lions_City_(2008).jpg");

                        case VehicleType.EvoBus_MB_O_530_2009:
                            return ImageSource.FromResource("de.tcl.sw.Resources.EvoBus_MB_O_530_(2009).jpg");

                        case VehicleType.EvoBus_MB_O_530_2010_2013:
                            return ImageSource.FromResource("de.tcl.sw.Resources.EvoBus_MB_O_530_(2010_bis_2013).jpg");

                        case VehicleType.EvoBus_MB_O_530_LE_2012_2013:
                            return ImageSource.FromResource("de.tcl.sw.Resources.EvoBus_MB_O_530_LE_(2012_und_2013).jpg");

                        case VehicleType.EvoBus_MB_O_530_LE_C2_2014_2015_2016_2017:
                            return ImageSource.FromResource("de.tcl.sw.Resources.EvoBus_MB_O_530_LE_C2_(2014_und_2015_und_2016_und_2017).jpg");

                        case VehicleType.EvoBus_MB_O_530_C2_2017:
                            return ImageSource.FromResource("de.tcl.sw.Resources.EvoBus_MB_O_530_C2_(2017).jpg");




                        case VehicleType.EvoBus_MB_O_530_G_2004_2005:
                            return ImageSource.FromResource("de.tcl.sw.Resources.EvoBus_MB_O_530_G_(2004_und_2005).jpg");

                        case VehicleType.EvoBus_MB_O_530_G_2006:
                            return ImageSource.FromResource("de.tcl.sw.Resources.EvoBus_MB_O_530_G_(2006).jpg");

                        case VehicleType.MAN_Lions_City_G_2008:
                            return ImageSource.FromResource("de.tcl.sw.Resources.MAN_Lions_City_G_(2008).jpg");

                        case VehicleType.EvoBus_MB_O_530_G_2009:
                            return ImageSource.FromResource("de.tcl.sw.Resources.EvoBus_MB_O_530_G_(2009).jpg");

                        case VehicleType.EvoBus_MB_O_530_G_2010_2011_2013:
                            return ImageSource.FromResource("de.tcl.sw.Resources.EvoBus_MB_O_530_G_(2010,_2011_und_2013).jpg");

                        case VehicleType.EvoBus_MB_O_530_G_C2_2012_2014:
                            return ImageSource.FromResource("de.tcl.sw.Resources.EvoBus_MB_O_530_G_C2_(2012_und_2014).jpg");

                        case VehicleType.MAN_Lions_City_G_2015:
                            return ImageSource.FromResource("de.tcl.sw.Resources.MAN_Lions_City_G_(2015).jpg");

                        case VehicleType.MAN_Lions_City_G_2016_2017:
                            return ImageSource.FromResource("de.tcl.sw.Resources.MAN_Lions_City_G_(2016_und_2017).jpg");

                        case VehicleType.MAN_Lions_City_G_2017_3:
                            return ImageSource.FromResource("de.tcl.sw.Resources.MAN_Lions_City_G_(2017_3Tuerer).jpg");

                        case VehicleType.MAN_Lions_City_G_2017_4:
                            return ImageSource.FromResource("de.tcl.sw.Resources.MAN_Lions_City_G_(2017_4Tuerer).jpg");

                        default:
                            return "";
                    }
                }

                return "";
            }
        }


        public BusPageViewModel()
        {
        }

        public override async Task InitAsync(Bus bus)
        {
            Bus = bus;
        }
    }
}
