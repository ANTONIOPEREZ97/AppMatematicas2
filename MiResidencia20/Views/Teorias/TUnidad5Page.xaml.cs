using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;
namespace MiResidencia20.Views.Teorias
{
    public partial class TUnidad5Page : ContentPage
    {
        public TUnidad5Page()
        {
            InitializeComponent();
        }

        void Btn_irAEjerciciosU5(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EUnidad5Page());
        }

       

        void Btn_irAVideoTuturial(System.Object sender, System.EventArgs e)
        {
            var anchura = 600;
            WebView.HeightRequest = anchura;
            var meWebUnidad5 = WebView.Source;
        }

    }
}
