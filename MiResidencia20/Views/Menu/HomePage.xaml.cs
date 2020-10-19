using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MiResidencia20.Views.Menu
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

       //1Para poder listar en el listview
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadItemsEstudiante();
        }

        //2. Me sirve para cargar los datos 
        private async void LoadItemsEstudiante()
        {

            var items = await App.Context.GetItemEstudiantesAsync();
            //Enlazo con mi propiedad xaml listview  listaDatosAlumnos x:Name de listView 
            ListaDatosAlumno.ItemsSource = items;

        }
    }
}
