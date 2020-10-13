using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MiResidencia20.Views;
using MiResidencia20.Data;
using System.IO;

namespace MiResidencia20
{
    public partial class App : Application
    {
        //llamo a mi clase DatabaseQuery creandole una variable
        static DatabaseQuery database;

        public static DatabaseQuery Database
        {
            get
            {
                if (database == null)
                {
                    //TestAlumno es el nombre de mi base de datos
                    database = new DatabaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"TestAlumno.db3"));

                }
               
                return database;
            }
            


        }


        public App()
        {
            InitializeComponent();

            MainPage = new  NavigationPage (new BienvenidaPage());
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
