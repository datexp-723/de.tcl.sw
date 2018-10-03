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
    public partial class InspectionsByYearView : ContentView
    {

        public int InspectionYear
        {
            get { return (int)GetValue(InspectionYearProperty); }
            set
            {
                SetValue(InspectionYearProperty, value);
            }
        }

        public static readonly BindableProperty InspectionYearProperty =
            BindableProperty.Create("InspectionYear", typeof(int), typeof(InspectionsByYearView), -1, propertyChanged: OnEventNameChanged);

        static void OnEventNameChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
            InspectionsByYearView inspectionByYearView = bindable as InspectionsByYearView;
            if (inspectionByYearView != null
                && newValue is int)
            {
                InspectionsByYearViewModel viewModel = inspectionByYearView.BindingContext as InspectionsByYearViewModel;
                if (viewModel != null)
                {
                    viewModel.ActiveYear = (int)newValue;
                }
            }
        }

        protected InspectionsByYearViewModel InspectionsByYearViewModel
        {
            get { return (InspectionsByYearViewModel)Resources["InspectionsByYearViewModel"]; }
        }

        public InspectionsByYearView()
        {
            InitializeComponent();
        }
    }
}