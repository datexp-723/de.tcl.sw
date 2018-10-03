using de.tcl.common.entities.Mvvm;
using de.tcl.common.pageNavigation;
using de.tcl.sw.Entities;
using de.tcl.sw.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace de.tcl.sw.ViewModels
{
    public class InspectionOverviewViewModel : ViewModelBase
    {

        public ObservableCollection<GroupedVehiclesViewModel> GroupedVehicleInspections { get; set; }
        private ICommand _vehicleTappedCommand;
        private Vehicle _selectedVehicle;
        private InspectionType _activeInspectionType
            ;

        public Vehicle SelectedVehicle
        {
            get { return _selectedVehicle; }
            set
            {
                if (_selectedVehicle != value)
                {
                    _selectedVehicle = value;
                    OnPropertyChanged();
                }
            }
        }

        public InspectionType ActiveInspectionType
        {
            get { return _activeInspectionType; }
            set
            {
                if(_activeInspectionType != value)
                {
                    _activeInspectionType = value;

                    ReloadInspectionDates();

                    OnPropertyChanged();
                }
            }
        }

        public ICommand VehicleTappedCommand
        {
            get
            {
                if (_vehicleTappedCommand == null)
                {
                    _vehicleTappedCommand = new RelayCommand(async () =>
                    {
                        if (SelectedVehicle != null)
                        {
                            await GoToVehicalPage(SelectedVehicle);
                        }
                    });
                }

                return _vehicleTappedCommand;
            }
        }

        private async Task GoToVehicalPage(Vehicle vehicle)
        {
            if (vehicle is Bus)
            {
                await PageNavigator.NavigateToAsync<BusPageViewModel, Bus>((Bus)vehicle);
            }
            else
            {
                
            }
        }

        private void ReloadInspectionDates()
        {
            GroupedVehicleInspections.Clear();

            List<Vehicle> vehicles = DummyDatabase.Vehicles;

            Dictionary<DateTime, List<Vehicle>> vehiclesByInspectionDateMonth = new Dictionary<DateTime, List<Vehicle>>();
            foreach (Vehicle vehicle in vehicles)
            {
                foreach (Inspection inspection in vehicle.Inspections)
                {
                    if (ActiveInspectionType == InspectionType.NotDefined
                        || inspection.InspectionType == ActiveInspectionType)
                    {
                        int year = inspection.Date.Year;
                        int month = inspection.Date.Month;

                        DateTime monthDate = new DateTime(year, month, 1);
                        if (!vehiclesByInspectionDateMonth.ContainsKey(monthDate))
                        {
                            vehiclesByInspectionDateMonth.Add(monthDate, new List<Vehicle>());
                        }

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

                GroupedVehicleInspections.Add(inspectionGroup);
            }
        }

        public InspectionOverviewViewModel()
        {
            GroupedVehicleInspections = new ObservableCollection<GroupedVehiclesViewModel>();
        }

        public override Task InitAsync()
        {
            return Task.FromResult(0);
        }

    }
}
