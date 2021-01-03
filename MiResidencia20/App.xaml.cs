using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MiResidencia20.Views;
using System.IO;
using MiResidencia20.Views.Logueo;

namespace MiResidencia20
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            MainPage = new  NavigationPage (new BienvenidoPage());
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
