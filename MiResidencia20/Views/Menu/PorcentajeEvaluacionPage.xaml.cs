using System;
using System.Collections.Generic;
using MiResidencia20.Views.Logueo;

using Xamarin.Forms;

namespace MiResidencia20.Views.Menu
{
    public partial class PorcentajeEvaluacionPage : ContentPage
    {
        public PorcentajeEvaluacionPage()
        {
            InitializeComponent();
        }

        #region NavigationMenu
        void Btn_IrAMenuPrincipal(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MenuTabbedPage());
        }

        #endregion
    }
}
