using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Videos
{
    public partial class VideoUnidad3Page : ContentPage
    {
        public VideoUnidad3Page()
        {
            InitializeComponent();
            webVideo.Source = "https://www.youtube.com/embed/xDNVdC8iCxc";
            
        }
    }
}
