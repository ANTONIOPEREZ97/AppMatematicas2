﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiResidencia20.Views.Ejercicios;
using MiResidencia20.Views.Videos;
namespace MiResidencia20.Views.Teorias
{
    public partial class TUnidad5Page : ContentPage
    {
        public TUnidad5Page()
        {
            InitializeComponent();
        }

        void Btn_irAEjerciciosU5(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EUnidad5Page());
        }

       

        void Btn_irAVideoTuturial(System.Object sender, System.EventArgs e)
        { //1.Navego VideoU5
            Navigation.PushAsync(new VideoUnidad5Page());

        }

    }
}
