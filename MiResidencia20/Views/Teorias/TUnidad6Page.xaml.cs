using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;
using MiResidencia20.Views.Videos;
namespace MiResidencia20.Views.Teorias
{
    public partial class TUnidad6Page : ContentPage
    {
        public TUnidad6Page()
        {
            InitializeComponent();
        }

        void Btn_irAEjerciciosU6(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EUnidad6Page());
        }

        void Btn_irAVideoTuturial(System.Object sender, System.EventArgs e)
        {
             //1.Navego VideoU6
            Navigation.PushAsync(new VideoUnidad6Page());

        }
    }
}
