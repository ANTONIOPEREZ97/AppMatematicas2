using System;
using System.Collections.Generic;
using MiResidencia20.Models;
using MiResidencia20.Data;
using SQLite;
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

            
           
            if (string.IsNullOrEmpty(this.nombreUsuarioEntry.Text))
            {
                await DisplayAlert("Error al iniciar sesión ", "Inserte el nombre de usuario correcto", "ok");

            }

           
            else
            {

                await Navigation.PushAsync(new MenuTabbedPage());
                await DisplayAlert("Bienvenido", "AppMatemáticas", "Ok");


            }

            

        }
    }
}
