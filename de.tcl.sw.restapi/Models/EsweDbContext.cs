using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace de.tcl.sw.restapi.Models
{
    public class EsweDbContext : DbContext
    {
        public EsweDbContext() : base("name=EsweDB")
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}