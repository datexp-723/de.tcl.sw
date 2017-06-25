using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.tcl.sw.Entities
{
    public class Vehicle
    {

        public int Number { get; set; }

        public string Type { get; set; }

        public Inspection Inspection { get; set; }

        public Vehicle(int number)
        {
            Number = number;
        }

    }
}
