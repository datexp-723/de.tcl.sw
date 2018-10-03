using de.tcl.common.helper.Extensions;
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
        private static Random _rnd = new Random();
        private static List<VehicleForm> _vehicleForms = new List<VehicleForm>();
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
            CreateBusTypes();
            CreateBusses();
        }

        private static void CreateBusses()
        {
            Bus bus1 = new Bus(FindVehicleForm(VehicleType.EvoBus_MB_O_530_2005), 229);
            bus1.Inspections.Add(new TuevInspection(new DateTime(2017, 6, 30, 0, 0, 0)));
            bus1.Inspections.Add(new SpInspection(new DateTime(2017, 9, 30, 0, 0, 0)));
            bus1.Inspections.Add(new TuevInspection(new DateTime(2018, 6, 30, 0, 0, 0)));
            bus1.Inspections.Add(new SpInspection(new DateTime(2018, 10, 30, 0, 0, 0)));

            Bus bus2 = new Bus(FindVehicleForm(VehicleType.EvoBus_MB_O_530_2005), 327);
            bus2.Inspections.Add(new TuevInspection(new DateTime(2017, 7, 6, 0, 0, 0)));
            bus2.Inspections.Add(new SpInspection(new DateTime(2017, 12, 6, 0, 0, 0)));
            bus2.Inspections.Add(new TuevInspection(new DateTime(2018, 2, 6, 0, 0, 0)));
            bus2.Inspections.Add(new SpInspection(new DateTime(2018, 4, 6, 0, 0, 0)));

            Bus bus3 = new Bus(FindVehicleForm(VehicleType.EvoBus_MB_O_530_2005), 422);
            bus3.Inspections.Add(new TuevInspection(new DateTime(2017, 7, 6, 0, 0, 0)));

            Bus bus4 = new Bus(FindVehicleForm(VehicleType.EvoBus_MB_O_530_2005), 123);
            bus4.Inspections.Add(new TuevInspection(new DateTime(2017, 8, 24, 0, 0, 0)));

            Bus bus5 = new Bus(FindVehicleForm(VehicleType.EvoBus_MB_O_530_2005), 77);
            bus5.Inspections.Add(new TuevInspection(new DateTime(2017, 9, 25, 0, 0, 0)));

            Bus bus6 = new Bus(FindVehicleForm(VehicleType.EvoBus_MB_O_530_2005), 234);
            bus6.Inspections.Add(new TuevInspection(new DateTime(2017, 11, 30, 0, 0, 0)));

            Bus bus7 = new Bus(FindVehicleForm(VehicleType.EvoBus_MB_O_530_2005), 44);
            bus7.Inspections.Add(new TuevInspection(new DateTime(2017, 7, 6, 0, 0, 0)));

            Bus bus8 = new Bus(FindVehicleForm(VehicleType.EvoBus_MB_O_530_2005), 23);
            bus8.Inspections.Add(new SpInspection(new DateTime(2017, 9, 25, 0, 0, 0)));

            Bus bus9 = new Bus(FindVehicleForm(VehicleType.EvoBus_MB_O_530_2005), 38);
            bus9.Inspections.Add(new SpInspection(new DateTime(2018, 12, 1, 0, 0, 0)));

            Bus bus10 = new Bus(FindVehicleForm(VehicleType.EvoBus_MB_O_530_2005), 120);
            bus10.Inspections.Add(new SpInspection(new DateTime(2018, 1, 29, 0, 0, 0)));

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

            _vehicles = new List<Vehicle>(_vehicles.OrderBy(v => v.Number));
        }

        private static void CreateBusTypes()
        {
            VehicleForm solo1 = new VehicleTypeSolo(VehicleType.EvoBus_MB_O_530_2005, "EvoBus MB O 530 (2005)");
            VehicleForm solo2 = new VehicleTypeSolo(VehicleType.EvoBus_MB_O_530_2007, "EvoBus MB O 530 (2007)");
            VehicleForm solo3 = new VehicleTypeSolo(VehicleType.MAN_Lions_City_2008, "MAN Lion's City (2008)");
            VehicleForm solo4 = new VehicleTypeSolo(VehicleType.EvoBus_MB_O_530_2009, "EvoBus MB O 530 (2009)");
            VehicleForm solo5 = new VehicleTypeSolo(VehicleType.EvoBus_MB_O_530_2010_2013, "EvoBus MB O 530 (2010 bis 2013)");
            VehicleForm solo6 = new VehicleTypeSolo(VehicleType.EvoBus_MB_O_530_LE_2012_2013, "EvoBus MB O 530 LE (2012 und 2013)");
            VehicleForm solo7 = new VehicleTypeSolo(VehicleType.EvoBus_MB_O_530_LE_C2_2014_2015_2016_2017, "EvoBus MB O 530 LE C2 (2014 und 2015 und 2016 und 2017)");
            VehicleForm solo8 = new VehicleTypeSolo(VehicleType.EvoBus_MB_O_530_C2_2017, "EvoBus MB O 530 C2 (2017)");

            VehicleForm bendy1 = new VehicleTypeBendy(VehicleType.EvoBus_MB_O_530_G_2004_2005, "EvoBus MB O 530 G (2004 und 2005)");
            VehicleForm bendy2 = new VehicleTypeBendy(VehicleType.EvoBus_MB_O_530_G_2006, "EvoBus MB O 530 G (2006)");
            VehicleForm bendy3 = new VehicleTypeBendy(VehicleType.MAN_Lions_City_G_2008, "MAN Lion's City G (2008)");
            VehicleForm bendy4 = new VehicleTypeBendy(VehicleType.EvoBus_MB_O_530_G_2009, "EvoBus MB O 530 G (2009)");
            VehicleForm bendy5 = new VehicleTypeBendy(VehicleType.EvoBus_MB_O_530_G_2010_2011_2013, "EvoBus MB O 530 G (2010, 2011 und 2013)");
            VehicleForm bendy6 = new VehicleTypeBendy(VehicleType.EvoBus_MB_O_530_G_C2_2012_2014, "EvoBus MB O 530 G C2 (2012 und 2014)");
            VehicleForm bendy7 = new VehicleTypeBendy(VehicleType.MAN_Lions_City_G_2015, "MAN Lion's City G (2015)");
            VehicleForm bendy8 = new VehicleTypeBendy(VehicleType.MAN_Lions_City_G_2016_2017, "MAN Lion's City G (2016 und 2017)");
            VehicleForm bendy9 = new VehicleTypeBendy(VehicleType.MAN_Lions_City_G_2017_3, "MAN Lion's City G (2017 3-Türer)");
            VehicleForm bendy10 = new VehicleTypeBendy(VehicleType.MAN_Lions_City_G_2017_4, "MAN Lion's City G (2017 4-Türer)");

            _vehicleForms.AddIfNotContained(solo1);
            _vehicleForms.AddIfNotContained(solo2);
            _vehicleForms.AddIfNotContained(solo3);
            _vehicleForms.AddIfNotContained(solo4);
            _vehicleForms.AddIfNotContained(solo5);
            _vehicleForms.AddIfNotContained(solo6);
            _vehicleForms.AddIfNotContained(solo7);
            _vehicleForms.AddIfNotContained(solo8);
            _vehicleForms.AddIfNotContained(bendy1);
            _vehicleForms.AddIfNotContained(bendy2);
            _vehicleForms.AddIfNotContained(bendy3);
            _vehicleForms.AddIfNotContained(bendy4);
            _vehicleForms.AddIfNotContained(bendy5);
            _vehicleForms.AddIfNotContained(bendy6);
            _vehicleForms.AddIfNotContained(bendy7);
            _vehicleForms.AddIfNotContained(bendy8);
            _vehicleForms.AddIfNotContained(bendy9);
            _vehicleForms.AddIfNotContained(bendy10);
        }

        public static VehicleForm FindVehicleForm(VehicleType vehicleType)
        { 
            return _vehicleForms[_rnd.Next(0, _vehicleForms.Count)];

            //return _vehicleForms.Where(vf => vf.VehicleType == vehicleType).FirstOrDefault();
        }
    }
}
