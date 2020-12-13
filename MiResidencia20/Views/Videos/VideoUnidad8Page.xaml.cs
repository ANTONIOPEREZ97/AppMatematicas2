using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Videos
{
    public partial class VideoUnidad8Page : ContentPage
    {
        public VideoUnidad8Page()
        {
            InitializeComponent();
            webVideo.Source = "https://www.youtube.com/embed/G3pd_oxUGvc";
        }
    }
}
