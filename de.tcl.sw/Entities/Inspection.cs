using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.tcl.sw.Entities
{
    public abstract class Inspection
    {

        public DateTime Date { get; set; }

        public Inspection(DateTime date)
        {
            Date = date;
        }

    }
}
