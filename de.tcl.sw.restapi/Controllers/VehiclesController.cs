using de.tcl.sw.restapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace de.tcl.sw.restapi.Controllers
{
    public class VehiclesController : ApiController
    {

        private readonly EsweDbContext _dbContextVehicles = new EsweDbContext();

        // GET api/values
        public IEnumerable<Vehicle> Get()
        {
            List<Vehicle> allVehicles = _dbContextVehicles.Vehicles.ToList();
            if(allVehicles.Count == 0)
            {
                List<Vehicle> newVehicles = new List<Vehicle>();
                for (int i = 0; i < 1000; i++)
                {
                    Vehicle v = new Vehicle() { VehicleId = i + 1, Comment = "Dummdidöäüä0" };
                    newVehicles.Add(v);
                }

                _dbContextVehicles.Vehicles.AddRange(newVehicles);

                _dbContextVehicles.SaveChanges();

                return _dbContextVehicles.Vehicles.ToList();
            }
            else
            {
                return allVehicles;
            }
        }

        // GET api/values/5
        public Vehicle Get(int id)
        {
            return _dbContextVehicles.Vehicles.Where(v => v.Id == id).FirstOrDefault();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            // Create stub entity
            Vehicle vehicle = new Vehicle { Id = id };

            // Attach the entity to the context.
            _dbContextVehicles.Vehicles.Attach(vehicle);

            // Remove the entity. This marks it for deletion
            _dbContextVehicles.Vehicles.Remove(vehicle);

            // Save changes. EF will see that the entity state has changed,
            // and process it accordingly. In this case performing a delete query.
            _dbContextVehicles.SaveChanges();
        }
    }
}