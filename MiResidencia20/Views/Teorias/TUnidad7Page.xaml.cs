using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;

namespace MiResidencia20.Views.Teorias
{
    public partial class TUnidad7Page : ContentPage
    {
        public TUnidad7Page()
        {
            InitializeComponent();
        }

        void Btn_irAEjerciciosU7(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EUnidad7Page());
        }

        void Btn_irAVideoTuturial(System.Object sender, System.EventArgs e)
        {
            var anchura = 500;
            WebView.HeightRequest = anchura;
            var meWebUnidad7 = WebView.Source;

           
        }
    }
}
