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
        //1.Mando a llamar a mi propiedad del Modelo DatabaseContex 
        public static DatabaseContext  Context { get; set; }

        public App()
        {
            InitializeComponent();
            //2.Creo un meto-do
            InitializeDatabase();
            MainPage = new  NavigationPage (new BienvenidaPage());
        }

        private void InitializeDatabase()
        {
            //Obtener la carpeta de la Aplicación
            var CarpetaApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            //Necesito la ruta completa de
            var dbPath = System.IO.Path.Combine(CarpetaApp,"TestEstudiante.db3");

            //3.Inicializo Context enviandole la ruta de la BD al meto-do DatabeContext
            Context = new DatabaseContext(dbPath);
          
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
