using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DispatcherTime.Resources;
using System.Windows.Threading;

namespace DispatcherTime
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            DispatcherTimer time = new DispatcherTimer();
                time.Interval = TimeSpan.FromSeconds(1);
                time.Tick += ((s, args) =>
                {
                    lbTimer.Text = DateTime.Now.ToLongTimeString().ToString();
                });
                time.Start();
        }
    }
}