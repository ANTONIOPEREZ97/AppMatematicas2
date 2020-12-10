using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;
using MiResidencia20.Views.Videos;
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

            //1.Navego VideoU9
            Navigation.PushAsync(new VideoUnidad9Page());
            
        }
    }
    
}
