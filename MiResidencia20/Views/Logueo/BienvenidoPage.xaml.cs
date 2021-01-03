using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Logueo
{
    public partial class BienvenidoPage : ContentPage
    {
        public BienvenidoPage()
        {
            InitializeComponent();
        }

        public async void Btn_IrARegistro(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegistroPage());

        }


        public async void Btn_IniciarSesion(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new IniciarSesionPage());

        }
    }
}
