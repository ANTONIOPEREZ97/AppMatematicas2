using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Videos
{
    public partial class VideoUnidad7Page : ContentPage
    {
        public VideoUnidad7Page()
        {
            InitializeComponent();
            webVideo.Source = "https://www.youtube.com/embed/0kv5W5B7HKA";
        }
    }
}
