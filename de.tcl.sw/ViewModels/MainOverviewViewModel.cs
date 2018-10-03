using de.tcl.common.entities.Mvvm;
using de.tcl.sw.Entities;
using de.tcl.sw.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.tcl.sw.ViewModels
{
    public class MainOverviewViewModel : ViewModelBase
    {

        public ObservableCollection<GroupedVehiclesViewModel> GroupedVehicleInspectionsByYear { get; set; }

        public MainOverviewViewModel()
        {
            GroupedVehicleInspectionsByYear = new ObservableCollection<GroupedVehiclesViewModel>();
            ReloadInspectionDates();
        }

        private void ReloadInspectionDates()
        {
            GroupedVehicleInspectionsByYear.Clear();

            List<Vehicle> vehicles = DummyDatabase.Vehicles;

            Dictionary<DateTime, List<Vehicle>> vehiclesByInspectionDateMonth = new Dictionary<DateTime, List<Vehicle>>();
            foreach (Vehicle vehicle in vehicles)
            {
                foreach (Inspection inspection in vehicle.Inspections)
                {
                    int year = inspection.Date.Year;

                    DateTime monthDate = new DateTime(year, 1, 1);
                    if (!vehiclesByInspectionDateMonth.ContainsKey(monthDate))
                    {
                        vehiclesByInspectionDateMonth.Add(monthDate, new List<Vehicle>());
                        vehiclesByInspectionDateMonth[monthDate].Add(vehicle);
                    }
                }
            }

            foreach (DateTime inspectionDate in vehiclesByInspectionDateMonth.Keys)
            {
                GroupedVehiclesViewModel inspectionGroup = new GroupedVehiclesViewModel() { Date = inspectionDate };

                foreach (Vehicle vehicle in vehiclesByInspectionDateMonth[inspectionDate])
                {
                    inspectionGroup.Add(vehicle);
                }

                GroupedVehicleInspectionsByYear.Add(inspectionGroup);
            }
        }

        public override Task InitAsync()
        {
            return Task.FromResult(0);
        }
    }
}
