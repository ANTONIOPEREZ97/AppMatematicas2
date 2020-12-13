using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Videos
{
    public partial class VideoUnidad4Page : ContentPage
    {
        public VideoUnidad4Page()
        {
            InitializeComponent();
            webVideo.Source = "https://www.youtube.com/embed/4ptuAOM1XNU";
        }
    }
}
