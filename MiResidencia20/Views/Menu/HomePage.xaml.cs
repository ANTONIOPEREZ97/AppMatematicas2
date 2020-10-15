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

       
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadItemsEstudiante();
        }

        private async void LoadItemsEstudiante()
        {

            var items = await App.Context.GetItemEstudiantesAsync();
            //Enlazo con mi propiedad xaml listview 
            ListaDatosAlumno.ItemsSource = items;

        }
    }
}
