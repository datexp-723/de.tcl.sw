using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.tcl.sw.Entities
{
    public class SpInspection : Inspection
    {
        public SpInspection(DateTime date) : base(date)
        {
        }

        public override InspectionType InspectionType => InspectionType.SP;
    }
}
