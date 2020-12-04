using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;
using MiResidencia20.Views.Videos;
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
            //1.Navego VideoU4
            Navigation.PushAsync(new VideoUnidad4Page());

            //var anchura = 600;
            //WebView.HeightRequest = anchura;
            //var meWebUnidad4 = WebView.Source;
        }
    }
}
