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
    public partial class InspectionSelectorPage : TabbedPage
    {
        public InspectionSelectorPage()
        {
            InitializeComponent();
        }

        public InspectionSelectorPage(InspectionSelectorViewModel vm)
            : this()
        {
        }
    }
}