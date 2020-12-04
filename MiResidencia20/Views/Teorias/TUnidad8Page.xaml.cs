using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;
using MiResidencia20.Views.Videos;
namespace MiResidencia20.Views.Teorias
{
    public partial class TUnidad8Page : ContentPage
    {
        public TUnidad8Page()
        {
            InitializeComponent();
        }

        void Btn_irAEjerciciosU8(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EUnidad8Page());
        }

        void Btn_irAVideoTuturial(System.Object sender, System.EventArgs e)
        {
            //1.Navego VideoU8
            Navigation.PushAsync(new VideoUnidad8Page());

            //var anchura = 600;
            //WebView.HeightRequest = anchura;
            //var meWebUnidad8 = WebView.Source;
        }
    }
}
