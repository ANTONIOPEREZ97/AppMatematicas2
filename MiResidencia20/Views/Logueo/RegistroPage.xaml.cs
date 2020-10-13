using System;
using System.Collections.Generic;
using Xamarin.Forms;
using MiResidencia20.Views.Logueo;

namespace MiResidencia20.Views
{
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
        }

        async void  Btn_Registrar(System.Object sender, System.EventArgs e)
        {
            var usuario = UsuarioEntry.Text;
            var carrera = carreraEntry.Text;
            var grupo = grupoEntry.Text;
            var periodo = periodoEntry.Text;

            if(usuario == null || carrera == null ||  grupo == null || periodo == null)//Validaciones de campos vacíos
            {
                await DisplayAlert("Error al registrarse", "Llene todos los campos!", "ok");
            }
            else
            {
                await DisplayAlert("Felicitaciones", "¡Usuario creado exitosamente!", "Comenzar");
                await Navigation.PushAsync(new MenuTabbedPage());

            }

        }
    }
     
}
