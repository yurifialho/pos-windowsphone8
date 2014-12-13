using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ImageExibicao.Resources;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace ImageExibicao
{
    


    public partial class MainPage : PhoneApplicationPage
    {

        private double tamanho = 100.0;
        private bool isLarge = false;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Uri uri = new Uri("Assets/Grama.png", UriKind.Relative);
            BitmapImage bmp = new BitmapImage(uri);
            img.Source = bmp;
        }
    }
}