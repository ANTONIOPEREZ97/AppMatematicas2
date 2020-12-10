using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;
using MiResidencia20.Views.Videos;
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
            //1.Navego VideoU7
            Navigation.PushAsync(new VideoUnidad7Page());

        }
    }
}
