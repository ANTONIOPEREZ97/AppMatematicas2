using System;
using System.Collections.Generic;
using MiResidencia20.Views.Evaluaciones;

using Xamarin.Forms;

namespace MiResidencia20.Views.Menu
{
    public partial class EvaluacionesPage : ContentPage
    {
        public EvaluacionesPage()
        {
            InitializeComponent();
        }

        #region Navigation Evaluations

        void Btn_IrAEvaluacionU1(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EvalUnidad1Page());

        }

        void Btn_IrAEvaluacionU2(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EvalUnidad2Page());

        }

        void Btn_IrAEvaluacionU3(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EvalUnidad3Page());

        }

        void Btn_IrAEvaluacionU4(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EvalUnidad4Page());

        }

        void Btn_IrAEvaluacionU5(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EvalUnidad5Page());

        }

        void Btn_IrAEvaluacionU6(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EvalUnidad6Page());

        }

        void Btn_IrAEvaluacionU7(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EvalUnidad7Page());

        }

        void Btn_IrAEvaluacionU8(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EvalUnidad8Page());

        }

        void Btn_IrAEvaluacionU9(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EvalUnidad9Page());

        }

        #endregion
    }
}
