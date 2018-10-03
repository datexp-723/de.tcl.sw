using de.tcl.sw.Entities;
using de.tcl.sw.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace de.tcl.sw.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InspectionOverviewPage : ContentPage
    {

        public InspectionType InspectionType
        {
            get { return (InspectionType)GetValue(InspectionTypeProperty); }
            set
            {
                SetValue(InspectionTypeProperty, value);
            }
        }

        public static readonly BindableProperty InspectionTypeProperty =
            BindableProperty.Create("InspectionType", typeof(InspectionType), typeof(BusPage), InspectionType.NotDefined, propertyChanged: OnEventNameChanged);

        static void OnEventNameChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            InspectionOverviewPage inspectionOverviewPage = bindable as InspectionOverviewPage;
            if (inspectionOverviewPage != null
                && newValue is InspectionType)
            {
                InspectionOverviewViewModel viewModel = inspectionOverviewPage.BindingContext as InspectionOverviewViewModel;
                if (viewModel != null)
                {
                    viewModel.ActiveInspectionType = (InspectionType)newValue;
                }
            }
        }

        protected InspectionOverviewViewModel InspectionOverviewViewModel
        {
            get { return (InspectionOverviewViewModel)Resources["InspectionOverviewViewModel"]; }
        }

        public InspectionOverviewPage()
        {
            InitializeComponent();
            InspectionOverviewViewModel.ActiveInspectionType = InspectionType;
        }
    }
}
