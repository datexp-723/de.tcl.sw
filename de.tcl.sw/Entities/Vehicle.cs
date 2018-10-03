using de.tcl.common.helper.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.tcl.sw.Entities
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        public List<Inspection> Inspections { get; set; }

        public int Number { get; private set; }

        public VehicleForm FormType { get; private set; }

        public int CountTuevInspections
        {
            get { return Inspections.Count(i => i.InspectionType == InspectionType.TÜV); }
        }

        public int CountSpInspections
        {
            get { return Inspections.Count(i => i.InspectionType == InspectionType.SP); }
        }

        public Vehicle(VehicleForm formType, int number)
        {
            FormType = formType;
            Number = number;
            Inspections = new List<Inspection>();
        }

    }
}
