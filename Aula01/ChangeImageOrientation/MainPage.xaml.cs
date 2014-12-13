using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ChangeImageOrientation.Resources;
using System.Windows.Threading;
using System.Windows.Media.Imaging;

namespace ChangeImageOrientation
{
    public partial class MainPage : PhoneApplicationPage
    {

        private DispatcherTimer timer = new DispatcherTimer();
        private int count = 2;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += ((s, args) =>
            {
                if (count > 4)
                    count = 2;

                Uri uri = new Uri("Assets/homer/homer"+count+".png",UriKind.Relative);
                BitmapImage bmp = new BitmapImage(uri);
                this.homer.Source = bmp;
                count++;
            });

        }

        protected override void OnOrientationChanged(OrientationChangedEventArgs e)
        {
            base.OnOrientationChanged(e);
            if (e.Orientation == PageOrientation.LandscapeLeft || e.Orientation == PageOrientation.LandscapeRight)
            {
                this.timer.Start();
            }
            else
            {
                this.timer.Stop();
                Uri uri = new Uri("Assets/homer/homer1.png", UriKind.Relative);
                BitmapImage bmp = new BitmapImage(uri);
                this.homer.Source = bmp;
            }
        }
    }
}