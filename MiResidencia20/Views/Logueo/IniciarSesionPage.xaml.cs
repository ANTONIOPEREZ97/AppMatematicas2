using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Logueo
{
    public partial class IniciarSesionPage : ContentPage
    {
        public IniciarSesionPage()
        {
            InitializeComponent();
        }

        async void Btn_IniciarConUsuario(System.Object sender, System.EventArgs e)
        {
            if (nombreUsuarioRegistradoEntry.Text == null)
            {
                await DisplayAlert("Error al iniciar sesión ", "Inserte el nombre de usuario correcto", "ok");
            }
            else
            {
                await Navigation.PushAsync(new MenuTabbedPage());
                await DisplayAlert("Bienvenid@", "¡Comenzar a usar la App!", "Ok");

                //await Navigation.PushAsync(new MenuTabbedPage());

            }



            
        }
    }
}
