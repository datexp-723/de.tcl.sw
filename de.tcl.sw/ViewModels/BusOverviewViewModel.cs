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
using System.Linq;

namespace de.tcl.sw.ViewModels
{
    public class BusOverviewViewModel : ViewModelBase
    {

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

        private string _searchEntry;
        public string SearchEntry
        {
            get { return _searchEntry; }
            set
            {
                if(_searchEntry != value)
                {
                    _searchEntry = value;

                    Reload();

                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<Vehicle> Vehicles { get; set; }

        public BusOverviewViewModel()
        {
            Vehicles = new ObservableCollection<Vehicle>(DummyDatabase.Vehicles);
        }

        private void Reload()
        {
            int busNumberToSearch;
            if (string.IsNullOrEmpty(SearchEntry)
                || int.TryParse(SearchEntry, out busNumberToSearch))
            {
                Vehicles.Clear();

                List<Vehicle> vehiclesMatchingPattern = new List<Vehicle>();
                foreach(Vehicle vehicle in DummyDatabase.Vehicles)
                {
                    string busNumber = vehicle.Number.ToString();
                    if (busNumber.Contains(SearchEntry))
                    {
                        Vehicles.Add(vehicle);
                    }
                }
            }
        }

        public override Task InitAsync()
        {
            return Task.FromResult(0);
        }
    }
}
