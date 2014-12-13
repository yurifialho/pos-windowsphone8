using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Controllers.Resources;
using System.Windows.Media;


namespace Controllers
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void SizeChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Rectangle.Fill = new SolidColorBrush(Color.FromArgb(255, Convert.ToByte(Red.Value), Convert.ToByte(Green.Value), Convert.ToByte(Blue.Value)));
            
            Red.Foreground   = new SolidColorBrush(Color.FromArgb(255, (byte)Red.Value, 0,                 0));
            Green.Foreground = new SolidColorBrush(Color.FromArgb(255, 0              , (byte)Green.Value, 0));
            Blue.Foreground  = new SolidColorBrush(Color.FromArgb(255, 0,               0,                 (byte)Blue.Value));
            
            Red_Label.Text = Convert.ToInt32(Red.Value) + "";
            Green_Label.Text = Convert.ToInt32(Green.Value) + "";
            Blue_Label.Text = Convert.ToInt32(Blue.Value) + "";
        }
    }
}