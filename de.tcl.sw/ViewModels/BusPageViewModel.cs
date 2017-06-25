using de.tcl.common.entities.Mvvm;
using de.tcl.sw.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                }
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
