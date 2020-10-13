using System;
using System.Collections.Generic;
using MiResidencia20.Views.Logueo;

using Xamarin.Forms;

namespace MiResidencia20.Views.PorcentajeEvaluacion
{
    public partial class PEvaluacionPage : ContentPage
    {
        public PEvaluacionPage()
        {
            InitializeComponent();
        }

        #region NavigatioMenu
        void Btn_IrAMenuPrincipal(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MenuTabbedPage());
        }

        #endregion
    }
}
