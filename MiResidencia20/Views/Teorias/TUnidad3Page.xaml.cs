using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;
using MiResidencia20.Views.Videos;
namespace MiResidencia20.Views.Teorias
{
    public partial class TUnidad3Page : ContentPage
    {
        public TUnidad3Page()
        {
            InitializeComponent();
        }

        void Btn_irAEjerciciosU3(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EUnidad3Page());
        }

        void Btn_irAVideoTuturial(System.Object sender, System.EventArgs e)
        {
             //1.Navego VideoU3
            Navigation.PushAsync(new VideoUnidad3Page());
 
        }

    }
}
