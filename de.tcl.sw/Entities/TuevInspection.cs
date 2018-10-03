using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.tcl.sw.Entities
{
    public class TuevInspection : Inspection
    {
        public TuevInspection(DateTime date) : base(date)
        {
        }

        public override InspectionType InspectionType => InspectionType.TÜV;
    }
}
