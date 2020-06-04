using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTesting.Services;
using XamarinTesting.Views;
using XamarinTesting.Views.Forms;

namespace XamarinTesting
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AddCardPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
