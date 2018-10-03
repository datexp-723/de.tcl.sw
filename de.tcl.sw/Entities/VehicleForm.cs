using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.tcl.sw.Entities
{
    public abstract class VehicleForm
    {
        [Key]
        public int Id { get; set; }

        public VehicleType VehicleType { get; private set; }

        public string Name { get; private set; }

        public VehicleForm(VehicleType vehicleType, string name)
        {
            VehicleType = vehicleType;
            Name = name;
        }
    }
}
