﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Videos
{
    public partial class VideoUnidad6Page : ContentPage
    {
        public VideoUnidad6Page()
        {
            InitializeComponent();
            webVideo.Source = "https://www.youtube.com/embed/8oV8gndd9WM";
        }
    }
}
