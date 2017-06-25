using de.tcl.sw.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.tcl.sw.Helpers
{
    public static class DummyDatabase
    {

        private static List<Vehicle> _vehicles = new List<Vehicle>();

        public static List<Vehicle> Vehicles
        {
            get
            {
                return new List<Vehicle>(_vehicles);
            }
        }

        static DummyDatabase()
        {
            Bus bus1 = new Bus(229) { Type = "Mercedes" };
            bus1.Inspection = new GeneralInspection(new DateTime(2017, 6, 30, 0, 0, 0));

            Bus bus2 = new Bus(327) { Type = "Mercedes" };
            bus2.Inspection = new GeneralInspection(new DateTime(2017, 7, 6, 0, 0, 0));

            Bus bus3 = new Bus(422) { Type = "Volvo" };
            bus3.Inspection = new GeneralInspection(new DateTime(2017, 7, 6, 0, 0, 0));

            Bus bus4 = new Bus(123) { Type = "Volvo" };
            bus4.Inspection = new GeneralInspection(new DateTime(2017, 8, 24, 0, 0, 0));

            Bus bus5 = new Bus(77) { Type = "Mercedes" };
            bus5.Inspection = new GeneralInspection(new DateTime(2017, 9, 25, 0, 0, 0));

            Bus bus6 = new Bus(234) { Type = "Volvo" };
            bus6.Inspection = new GeneralInspection(new DateTime(2017, 11, 30, 0, 0, 0));

            Bus bus7 = new Bus(234) { Type = "Mercedes" };
            bus7.Inspection = new GeneralInspection(new DateTime(2017, 7, 6, 0, 0, 0));

            Bus bus8 = new Bus(234) { Type = "Volvo" };
            bus8.Inspection = new GeneralInspection(new DateTime(2017, 9, 25, 0, 0, 0));

            Bus bus9 = new Bus(234) { Type = "Volvo" };
            bus9.Inspection = new GeneralInspection(new DateTime(2018, 12, 1, 0, 0, 0));

            Bus bus10 = new Bus(234) { Type = "Mercedes" };
            bus10.Inspection = new GeneralInspection(new DateTime(2018, 1, 29, 0, 0, 0));

            _vehicles.Add(bus1);
            _vehicles.Add(bus2);
            _vehicles.Add(bus3);
            _vehicles.Add(bus4);
            _vehicles.Add(bus5);
            _vehicles.Add(bus6);
            _vehicles.Add(bus7);
            _vehicles.Add(bus8);
            _vehicles.Add(bus9);
            _vehicles.Add(bus10);
        }

    }
}
