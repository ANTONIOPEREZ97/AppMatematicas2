using System;
using SQLite;
using System.Collections.Generic;
using Xamarin.Forms;
using System.IO;
using MiResidencia20.Models;
using static MiResidencia20.Models.TablasDB;

namespace MiResidencia20.Views.Logueo
{
    public partial class IniciarSesionPage : ContentPage
    {
        public IniciarSesionPage()
        {
            InitializeComponent();
        }

        async  void Btn_IniciarConUsuario(System.Object sender, System.EventArgs e)
        {
            var dbpat = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "EstudianteDB.db");
            var db = new SQLiteConnection(dbpat);
            var myquery = db.Table<Student>().Where(s => s.Name.Equals(nombreRegistradoEntry.Text)).FirstOrDefault();

            if (myquery != null)
            {
                App.Current.MainPage = new NavigationPage(new MenuTabbedPage());
                await DisplayAlert("Bienvenido", "AppMatemáticas", "Ok");
            }

            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                   await DisplayAlert("Error", "Nombre de usuario incorrecto ", "Ok");

                   
                });
            }
        }
    }
}
