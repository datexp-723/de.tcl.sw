﻿using de.tcl.sw.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.tcl.sw.ViewModels
{
    public class GroupedVehiclesViewModel : ObservableCollection<Vehicle>
    {

        public DateTime Date { get; set; }

        public GroupedVehiclesViewModel()
        {

        }

    }
}
