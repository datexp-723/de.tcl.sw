using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.tcl.sw.Entities
{
    public class Bus : Vehicle
    {
        public Bus(VehicleForm formtype, int number)
            : base(formtype, number)
        {
        }

    }
}
