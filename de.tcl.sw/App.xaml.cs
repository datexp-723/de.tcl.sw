using de.tcl.common.pageNavigation;
using de.tcl.sw.ViewModels;
using de.tcl.sw.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace de.tcl.sw
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // create the root entry page for the mobile app.
            RootPage rootPage = new RootPage();

            // initialize the navigaion service for the app
            // and get 'Views <-> ViewModels' married/mapped
            RegisterViewByViewModelNavigationMapping(rootPage.Detail.Navigation);

            ThreadHelper.Initialize(Environment.CurrentManagedThreadId);

            Current.MainPage = rootPage;
        }

        //public static void SetMainPage()
        //{
        //    Current.MainPage = new RootPage();

        //    //Current.MainPage = new TabbedPage
        //    //{
        //    //    Children =
        //    //    {
        //    //        new NavigationPage(new ItemsPage())
        //    //        {
        //    //            Title = "Browse",
        //    //            Icon = Device.OnPlatform("tab_feed.png",null,null)
        //    //        },
        //    //        new NavigationPage(new AboutPage())
        //    //        {
        //    //            Title = "About",
        //    //            Icon = Device.OnPlatform("tab_about.png",null,null)
        //    //        },
        //    //    }
        //    //};
        //}

        private void RegisterViewByViewModelNavigationMapping(INavigation xamarinFormsNavigation)
        {
            PageNavigator.XamarinFormsNavigation = xamarinFormsNavigation;

            PageNavigator.RegisterViewMapping(typeof(MenuPageViewModel), typeof(MenuPage));
            PageNavigator.RegisterViewMapping(typeof(MainPageViewModel), typeof(MainPage));
            PageNavigator.RegisterViewMapping(typeof(BusPageViewModel), typeof(BusPage));
        }

    }
}
