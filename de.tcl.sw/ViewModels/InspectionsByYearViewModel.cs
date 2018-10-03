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
    public class InspectionsByYearViewModel : ViewModelBase
    {

        private int _activeYear;

        public ObservableCollection<Vehicle> VehicleInspections { get; set; }

        public int ActiveYear
        {
            get { return _activeYear; }
            set
            {
                if(_activeYear != value)
                {
                    _activeYear = value;

                    ReloadInspectionDates();

                    OnPropertyChanged();
                }
            }
        }

        #region Dates

        public bool HasJanInspections
        {
            get { return InspectionsCountJanTuev > 0 || InspectionsCountJanSp > 0; }
        }

        public bool HasFebInspections
        {
            get { return InspectionsCountFebTuev > 0 || InspectionsCountFebSp > 0; }
        }

        public bool HasMarInspections
        {
            get { return InspectionsCountMarTuev > 0 || InspectionsCountMarSp > 0; }
        }

        public bool HasAprInspections
        {
            get { return InspectionsCountAprTuev > 0 || InspectionsCountAprSp > 0; }
        }

        public bool HasMayInspections
        {
            get { return InspectionsCountMayTuev > 0 || InspectionsCountMaySp > 0; }
        }

        public bool HasJunInspections
        {
            get { return InspectionsCountJunTuev > 0 || InspectionsCountJunSp > 0; }
        }

        public bool HasJulInspections
        {
            get { return InspectionsCountJulTuev > 0 || InspectionsCountJulSp > 0; }
        }

        public bool HasAugInspections
        {
            get { return InspectionsCountAugTuev > 0 || InspectionsCountAugSp > 0; }
        }

        public bool HasSepInspections
        {
            get { return InspectionsCountSepTuev > 0 || InspectionsCountSepSp > 0; }
        }

        public bool HasOctInspections
        {
            get { return InspectionsCountOctTuev > 0 || InspectionsCountOctSp > 0; }
        }

        public bool HasNovInspections
        {
            get { return InspectionsCountNovTuev > 0 || InspectionsCountNovSp > 0; }
        }

        public bool HasDecInspections
        {
            get { return InspectionsCountDecTuev > 0 || InspectionsCountDecSp > 0; }
        }

        #endregion

        #region TÜV Count

        private int _inspectionsCountJanTuev;
        private int _inspectionsCountFebTuev;
        private int _inspectionsCountMarTuev;
        private int _inspectionsCountAprTuev;
        private int _inspectionsCountMayTuev;
        private int _inspectionsCountJunTuev;
        private int _inspectionsCountJulTuev;
        private int _inspectionsCountAugTuev;
        private int _inspectionsCountSepTuev;
        private int _inspectionsCountOctTuev;
        private int _inspectionsCountNovTuev;
        private int _inspectionsCountDecTuev;

        public int InspectionsCountTuev
        {
            get
            {
                return InspectionsCountJanTuev + InspectionsCountFebTuev + InspectionsCountMarTuev
                    + InspectionsCountAprTuev + InspectionsCountMayTuev + InspectionsCountJunTuev
                    + InspectionsCountJulTuev + InspectionsCountAugTuev + InspectionsCountSepTuev
                    + InspectionsCountOctTuev + InspectionsCountNovTuev + InspectionsCountDecTuev;
            }
        }

        public int InspectionsCountJanTuev
        {
            get { return _inspectionsCountJanTuev; }
            set
            {
                if (_inspectionsCountJanTuev != value)
                {
                    _inspectionsCountJanTuev = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountFebTuev
        {
            get { return _inspectionsCountFebTuev; }
            set
            {
                if (_inspectionsCountFebTuev != value)
                {
                    _inspectionsCountFebTuev = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountMarTuev
        {
            get { return _inspectionsCountMarTuev; }
            set
            {
                if (_inspectionsCountMarTuev != value)
                {
                    _inspectionsCountMarTuev = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountAprTuev
        {
            get { return _inspectionsCountAprTuev; }
            set
            {
                if (_inspectionsCountAprTuev != value)
                {
                    _inspectionsCountAprTuev = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountMayTuev
        {
            get { return _inspectionsCountMayTuev; }
            set
            {
                if (_inspectionsCountMayTuev != value)
                {
                    _inspectionsCountMayTuev = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountJunTuev
        {
            get { return _inspectionsCountJunTuev; }
            set
            {
                if (_inspectionsCountJunTuev != value)
                {
                    _inspectionsCountJunTuev = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountJulTuev
        {
            get { return _inspectionsCountJulTuev; }
            set
            {
                if (_inspectionsCountJulTuev != value)
                {
                    _inspectionsCountJulTuev = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountAugTuev
        {
            get { return _inspectionsCountAugTuev; }
            set
            {
                if (_inspectionsCountAugTuev != value)
                {
                    _inspectionsCountAugTuev = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountSepTuev
        {
            get { return _inspectionsCountSepTuev; }
            set
            {
                if (_inspectionsCountSepTuev != value)
                {
                    _inspectionsCountSepTuev = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountOctTuev
        {
            get { return _inspectionsCountOctTuev; }
            set
            {
                if (_inspectionsCountOctTuev != value)
                {
                    _inspectionsCountOctTuev = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountNovTuev
        {
            get { return _inspectionsCountNovTuev; }
            set
            {
                if (_inspectionsCountNovTuev != value)
                {
                    _inspectionsCountNovTuev = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountDecTuev
        {
            get { return _inspectionsCountDecTuev; }
            set
            {
                if (_inspectionsCountDecTuev != value)
                {
                    _inspectionsCountDecTuev = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region SP Count

        private int _inspectionsCountJanSp;
        private int _inspectionsCountFebSp;
        private int _inspectionsCountMarSp;
        private int _inspectionsCountAprSp;
        private int _inspectionsCountMaySp;
        private int _inspectionsCountJunSp;
        private int _inspectionsCountJulSp;
        private int _inspectionsCountAugSp;
        private int _inspectionsCountSepSp;
        private int _inspectionsCountOctSp;
        private int _inspectionsCountNovSp;
        private int _inspectionsCountDecSp;

        public int InspectionsCountSp
        {
            get
            {
                return InspectionsCountJanSp + InspectionsCountFebSp + InspectionsCountMarSp
                    + InspectionsCountAprSp + InspectionsCountMaySp + InspectionsCountJunSp
                    + InspectionsCountJulSp + InspectionsCountAugSp + InspectionsCountSepSp
                    + InspectionsCountOctSp + InspectionsCountNovSp + InspectionsCountDecSp;
            }
        }

        public int InspectionsCountJanSp
        {
            get { return _inspectionsCountJanSp; }
            set
            {
                if (_inspectionsCountJanSp != value)
                {
                    _inspectionsCountJanSp = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountFebSp
        {
            get { return _inspectionsCountFebSp; }
            set
            {
                if (_inspectionsCountFebSp != value)
                {
                    _inspectionsCountFebSp = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountMarSp
        {
            get { return _inspectionsCountMarSp; }
            set
            {
                if (_inspectionsCountMarSp != value)
                {
                    _inspectionsCountMarSp = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountAprSp
        {
            get { return _inspectionsCountAprSp; }
            set
            {
                if (_inspectionsCountAprSp != value)
                {
                    _inspectionsCountAprSp = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountMaySp
        {
            get { return _inspectionsCountMaySp; }
            set
            {
                if (_inspectionsCountMaySp != value)
                {
                    _inspectionsCountMaySp = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountJunSp
        {
            get { return _inspectionsCountJunSp; }
            set
            {
                if (_inspectionsCountJunSp != value)
                {
                    _inspectionsCountJunSp = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountJulSp
        {
            get { return _inspectionsCountJulSp; }
            set
            {
                if (_inspectionsCountJulSp != value)
                {
                    _inspectionsCountJulSp = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountAugSp
        {
            get { return _inspectionsCountAugSp; }
            set
            {
                if (_inspectionsCountAugSp != value)
                {
                    _inspectionsCountAugSp = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountSepSp
        {
            get { return _inspectionsCountSepSp; }
            set
            {
                if (_inspectionsCountSepSp != value)
                {
                    _inspectionsCountSepSp = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountOctSp
        {
            get { return _inspectionsCountOctSp; }
            set
            {
                if (_inspectionsCountOctSp != value)
                {
                    _inspectionsCountOctSp = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountNovSp
        {
            get { return _inspectionsCountNovSp; }
            set
            {
                if (_inspectionsCountNovSp != value)
                {
                    _inspectionsCountNovSp = value;
                    OnPropertyChanged();
                }
            }
        }

        public int InspectionsCountDecSp
        {
            get { return _inspectionsCountDecSp; }
            set
            {
                if (_inspectionsCountDecSp != value)
                {
                    _inspectionsCountDecSp = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        public InspectionsByYearViewModel()
        {
            VehicleInspections = new ObservableCollection<Vehicle>();
        }

        private void ReloadInspectionDates()
        {
            VehicleInspections.Clear();

            List<Vehicle> vehicles = DummyDatabase.Vehicles;

            Dictionary<DateTime, List<Vehicle>> thisYear = GetVehiclesByMonthYear(vehicles, ActiveYear);
            Fill(VehicleInspections, thisYear);

            InspectionsCountJanTuev = CountInspectionsInSpecificMonth(InspectionType.TÜV, 1);
            InspectionsCountFebTuev = CountInspectionsInSpecificMonth(InspectionType.TÜV, 2);
            InspectionsCountMarTuev = CountInspectionsInSpecificMonth(InspectionType.TÜV, 3);
            InspectionsCountAprTuev = CountInspectionsInSpecificMonth(InspectionType.TÜV, 4);
            InspectionsCountMayTuev = CountInspectionsInSpecificMonth(InspectionType.TÜV, 5);
            InspectionsCountJunTuev = CountInspectionsInSpecificMonth(InspectionType.TÜV, 6);
            InspectionsCountJulTuev = CountInspectionsInSpecificMonth(InspectionType.TÜV, 7);
            InspectionsCountAugTuev = CountInspectionsInSpecificMonth(InspectionType.TÜV, 8);
            InspectionsCountSepTuev = CountInspectionsInSpecificMonth(InspectionType.TÜV, 9);
            InspectionsCountOctTuev = CountInspectionsInSpecificMonth(InspectionType.TÜV, 10);
            InspectionsCountNovTuev = CountInspectionsInSpecificMonth(InspectionType.TÜV, 11);
            InspectionsCountDecTuev = CountInspectionsInSpecificMonth(InspectionType.TÜV, 12);

            InspectionsCountJanSp = CountInspectionsInSpecificMonth(InspectionType.SP, 1);
            InspectionsCountFebSp = CountInspectionsInSpecificMonth(InspectionType.SP, 2);
            InspectionsCountMarSp = CountInspectionsInSpecificMonth(InspectionType.SP, 3);
            InspectionsCountAprSp = CountInspectionsInSpecificMonth(InspectionType.SP, 4);
            InspectionsCountMaySp = CountInspectionsInSpecificMonth(InspectionType.SP, 5);
            InspectionsCountJunSp = CountInspectionsInSpecificMonth(InspectionType.SP, 6);
            InspectionsCountJulSp = CountInspectionsInSpecificMonth(InspectionType.SP, 7);
            InspectionsCountAugSp = CountInspectionsInSpecificMonth(InspectionType.SP, 8);
            InspectionsCountSepSp = CountInspectionsInSpecificMonth(InspectionType.SP, 9);
            InspectionsCountOctSp = CountInspectionsInSpecificMonth(InspectionType.SP, 10);
            InspectionsCountNovSp = CountInspectionsInSpecificMonth(InspectionType.SP, 11);
            InspectionsCountDecSp = CountInspectionsInSpecificMonth(InspectionType.SP, 12);

            OnPropertyChanged("InspectionsCountTuev");
            OnPropertyChanged("InspectionsCountSp");

            OnPropertyChanged("HasJanInspections");
            OnPropertyChanged("HasFebInspections");
            OnPropertyChanged("HasMarInspections");
            OnPropertyChanged("HasAprInspections");
            OnPropertyChanged("HasMayInspections");
            OnPropertyChanged("HasJunInspections");
            OnPropertyChanged("HasJulInspections");
            OnPropertyChanged("HasAugInspections");
            OnPropertyChanged("HasSepInspections");
            OnPropertyChanged("HasOctInspections");
            OnPropertyChanged("HasNovInspections");
            OnPropertyChanged("HasDecInspections");
        }

        private int CountInspectionsInSpecificMonth(InspectionType inspectionType, int monthToCheck)
        {
            int count = 0;
            foreach (Vehicle vehicle in VehicleInspections)
            {
                foreach (Inspection inspectionDate in vehicle.Inspections)
                {
                    if (inspectionDate.InspectionType == inspectionType
                        && inspectionDate.Date.Month == monthToCheck)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private void Fill(ObservableCollection<Vehicle> toFill, Dictionary<DateTime, List<Vehicle>> groupedVehiclesByDate)
        {
            foreach (DateTime inspectionDate in groupedVehiclesByDate.Keys)
            {
                //GroupedVehiclesViewModel inspectionGroup = new GroupedVehiclesViewModel() { Date = inspectionDate };
                foreach (Vehicle vehicle in groupedVehiclesByDate[inspectionDate])
                {
                    //inspectionGroup.Add(vehicle);
                    toFill.Add(vehicle);
                }
                //toFill.Add(inspectionGroup);
            }

        }

        private Dictionary<DateTime, List<Vehicle>> GetVehiclesByMonthYear(List<Vehicle> vehicles, int yearToLookFor)
        {
            Dictionary<DateTime, List<Vehicle>> vehiclesByInspectionYearMonth = new Dictionary<DateTime, List<Vehicle>>();
            foreach (Vehicle vehicle in vehicles)
            {
                foreach (Inspection inspection in vehicle.Inspections)
                {
                    int year = inspection.Date.Year;
                    if (year == yearToLookFor)
                    {
                        int month = inspection.Date.Month;

                        DateTime yearMonthDate = new DateTime(year, month, 1);
                        if (!vehiclesByInspectionYearMonth.ContainsKey(yearMonthDate))
                        {
                            vehiclesByInspectionYearMonth.Add(yearMonthDate, new List<Vehicle>());
                        }

                        vehiclesByInspectionYearMonth[yearMonthDate].Add(vehicle);
                    }
                }
            }

            return vehiclesByInspectionYearMonth;
        }

        public override Task InitAsync()
        {
            return Task.FromResult(0);
        }
    }
}
