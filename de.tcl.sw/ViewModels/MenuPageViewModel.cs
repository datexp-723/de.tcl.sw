using de.tcl.common.entities;
using de.tcl.common.entities.Mvvm;
using de.tcl.common.pageNavigation;
using de.tcl.sw.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace de.tcl.sw.ViewModels
{
    public class MenuPageViewModel : ViewModelBase
    {

        private ObservableRangeCollection<MenuCommand> _menuItems;
        private ICommand _menuItemTappedCommand;
        private MenuCommand _selectedMenuItem;

        public ObservableRangeCollection<MenuCommand> MenuItems
        {
            get { return _menuItems; }
            set
            {
                if (_menuItems != value)
                {
                    _menuItems = value;
                    OnPropertyChanged();
                }
            }
        }

        public MenuCommand SelectedMenuItem
        {
            get { return _selectedMenuItem; }
            set
            {
                if (_selectedMenuItem != value)
                {
                    _selectedMenuItem = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand MenuItemTappedCommand
        {
            get
            {
                if (_menuItemTappedCommand == null)
                {
                    _menuItemTappedCommand = new RelayCommand(() =>
                    {
                        if (SelectedMenuItem != null)
                        {
                            SelectedMenuItem.CommandToExecute.Execute(null);
                        }
                    });
                }

                return _menuItemTappedCommand;
            }
        }

        public MenuPageViewModel()
        {
            List<MenuCommand> menuItems = new List<MenuCommand>();

            MenuCommand mainOverviewCommand = new MenuCommand();
            mainOverviewCommand.Text = "Inspections";
            mainOverviewCommand.ImageSource = "icon.png";
            mainOverviewCommand.CommandToExecute = new RelayCommand(async () =>
            {
                await PageNavigator.NavigateToAsync<InspectionSelectorViewModel>();
            });
            menuItems.Add(mainOverviewCommand);

            MenuCommand busOverview = new MenuCommand();
            busOverview.Text = "Busses";
            busOverview.ImageSource = "ic_bus.png";
            busOverview.CommandToExecute = new RelayCommand(async () =>
            {
                await PageNavigator.NavigateToAsync<BusOverviewViewModel>();
            });
            menuItems.Add(busOverview);

            MenuItems = new ObservableRangeCollection<MenuCommand>(menuItems);
        }

        public override Task InitAsync()
        {
            return Task.FromResult(0);
        }
    }
}
