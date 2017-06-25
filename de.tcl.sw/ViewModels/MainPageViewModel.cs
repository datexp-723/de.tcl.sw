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
    public class MainPageViewModel : ViewModelBase
    {

        public ObservableCollection<GroupedVehicelInspectionViewModel> GroupedVehicelInspections { get; set; }
        private ICommand _vehicleTappedCommand;
        private Vehicle _selectedVehicle;

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

        public MainPageViewModel()
        {
            GroupedVehicelInspections = new ObservableCollection<GroupedVehicelInspectionViewModel>();

            List<Vehicle> vehicles = DummyDatabase.Vehicles;

            Dictionary<DateTime, List<Vehicle>> vehiclesByInspectionDateMonth = new Dictionary<DateTime, List<Vehicle>>();
            foreach(Vehicle vehicle in vehicles)
            {
                int year = vehicle.Inspection.Date.Year;
                int month = vehicle.Inspection.Date.Month;

                DateTime monthDate = new DateTime(year, month, 1);
                if (!vehiclesByInspectionDateMonth.ContainsKey(monthDate))
                {
                    vehiclesByInspectionDateMonth.Add(monthDate, new List<Vehicle>());
                }

                vehiclesByInspectionDateMonth[monthDate].Add(vehicle);
            }
            
            foreach(DateTime inspectionDate in vehiclesByInspectionDateMonth.Keys)
            {
                GroupedVehicelInspectionViewModel inspectionGroup = new GroupedVehicelInspectionViewModel() { Date = inspectionDate };
                
                foreach(Vehicle vehicle in vehiclesByInspectionDateMonth[inspectionDate])
                {
                    inspectionGroup.Add(vehicle);
                }

                GroupedVehicelInspections.Add(inspectionGroup);
            }
        }

        public override Task InitAsync()
        {
            return Task.FromResult(0);
        }

    }
}
