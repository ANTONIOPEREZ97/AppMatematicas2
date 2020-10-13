using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace MiResidencia20.Views.Logueo
{
    public partial class MenuTabbedPage : Xamarin.Forms.TabbedPage
    {
        public MenuTabbedPage()
        {
            InitializeComponent();
            //Configuro el desiño de mi tabbed para que quede como bottom
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            On<Android>().SetIsSmoothScrollEnabled(true);
        }
    }
}
