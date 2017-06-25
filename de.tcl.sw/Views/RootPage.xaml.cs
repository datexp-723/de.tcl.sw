using de.tcl.common.pageNavigation;
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
    public partial class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            InitializeComponent();
            PageNavigator.PageChanged += PushNotificationNavigationService_PageChanged;
        }

        private void PushNotificationNavigationService_PageChanged(object sender, System.EventArgs e)
        {
            if (IsPresented)
            {
                IsPresented = false;
            }
        }
    }
}
