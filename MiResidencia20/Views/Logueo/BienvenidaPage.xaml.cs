using System;
using System.Collections.Generic;
using Xamarin.Forms;
using MiResidencia20.Views.Logueo;
using MiResidencia20.Views; //Llamo a la carpeta Views


namespace MiResidencia20.Views
{
    public partial class BienvenidaPage : ContentPage
    {
        public BienvenidaPage()
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
