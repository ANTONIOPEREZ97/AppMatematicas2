using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;

namespace MiResidencia20.Views.Teorias
{
    public partial class TUnidad4Page : ContentPage
    {
        public TUnidad4Page()
        {
            InitializeComponent();
        }

        void Btn_irAEjerciciosU4(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EUnidad4Page());
        }

        void Btn_irAVideoTuturial(System.Object sender, System.EventArgs e)
        {
            var anchura = 500;
            WebView.HeightRequest = anchura;
            var meWebUnidad4 = WebView.Source;
        }
    }
}
