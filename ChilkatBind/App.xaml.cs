using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChilkatBind
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Get<ChilkatService>().Initalize();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
