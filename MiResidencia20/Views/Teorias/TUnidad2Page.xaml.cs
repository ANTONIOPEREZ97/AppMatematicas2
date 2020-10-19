using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;

namespace MiResidencia20.Views.Teorias
{
    public partial class TUnidad2Page : ContentPage
    {
        public TUnidad2Page()
        {
            InitializeComponent();
        }

        void Btn_irAEjerciciosU2(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EUnidad2Page());
        }

        void Btn_irAVideoTuturial(System.Object sender, System.EventArgs e)
        {

            var anchura = 600;
            WebView.HeightRequest = anchura;
            var meWebUnidad2 = WebView.Source;
        }

    }
}
