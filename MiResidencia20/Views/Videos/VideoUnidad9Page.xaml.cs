using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Videos
{
    public partial class VideoUnidad9Page : ContentPage
    {
        public VideoUnidad9Page()
        {
            InitializeComponent();
            webVideo.Source = "https://www.youtube.com/embed/kF5acki5HBw";
        }
    }
}
