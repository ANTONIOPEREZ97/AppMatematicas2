using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;

namespace MiResidencia20.Views.Teorias
{
    public partial class TUnidad9Page : ContentPage
    {
        public TUnidad9Page()
        {
            InitializeComponent();
        }

        void Btn_irAEjerciciosU9(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EUnidad9Page());
        }

        void Btn_irAVideoTuturial(System.Object sender, System.EventArgs e)
        {
            var anchura = 500;
            WebView.HeightRequest = anchura;
            var meWebUnidad9 = WebView.Source;
        }
    }
    
}
