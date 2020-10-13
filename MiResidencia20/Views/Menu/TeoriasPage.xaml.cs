using System;
using System.Collections.Generic;
using MiResidencia20.Views.Teorias;
using Xamarin.Forms;


namespace MiResidencia20.Views.Menu
{
    public partial class TeoriasPage : ContentPage
    {
        public TeoriasPage()
        {
            InitializeComponent();
        }

        #region Navigation Theories

        void Btn_IrAUnidad1(System.Object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new TUnidad1Page());

        }

        void Btn_IrAUnidad2(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TUnidad2Page());
        }

        void Btn_IrAUnidad3(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TUnidad3Page());
        }

        void Btn_IrAUnidad4(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TUnidad4Page());
        }

        void Btn_IrAUnidad5(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TUnidad5Page());
        }

        void Btn_IrAUnidad6(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TUnidad6Page());
        }

        void Btn_IrAUnidad7(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TUnidad7Page());
        }

        void Btn_IrAUnidad8(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TUnidad8Page());
        }


        void Btn_IrAUnidad9(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TUnidad9Page());
        }

        #endregion
    }
}
