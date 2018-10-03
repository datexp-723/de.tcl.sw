using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace de.tcl.sw.restapi.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        public int VehicleId { get; set; }

        public string Comment { get; set; }
    }
}