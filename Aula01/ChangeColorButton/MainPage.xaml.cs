using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ChangeColorButton.Resources;
using System.Windows.Media;

namespace ChangeColorButton
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

           
        }

        protected override void OnOrientationChanged(OrientationChangedEventArgs e)
        {
            base.OnOrientationChanged(e);
            if (e.Orientation == PageOrientation.LandscapeLeft || e.Orientation == PageOrientation.LandscapeRight)
            {
                this.bt01.Background = new SolidColorBrush(Colors.Yellow);
                this.bt01.Foreground = new SolidColorBrush(Colors.Black);
                this.bt01.VerticalAlignment = System.Windows.VerticalAlignment.Top;

                this.bt02.Background = new SolidColorBrush(Colors.Yellow);
                this.bt02.Foreground = new SolidColorBrush(Colors.Black);
                this.bt02.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            }
            else
            {
                this.bt01.Background = new SolidColorBrush(Colors.Black);
                this.bt01.Foreground = new SolidColorBrush(Colors.White);
                this.bt01.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;

                this.bt02.Background = new SolidColorBrush(Colors.Black);
                this.bt02.Foreground = new SolidColorBrush(Colors.White);
                this.bt02.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
            }
        }
    }
}