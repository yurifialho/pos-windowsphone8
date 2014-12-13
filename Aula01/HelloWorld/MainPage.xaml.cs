using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using HelloWorld.Resources;

namespace HelloWorld
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
            if(e.Orientation == PageOrientation.PortraitUp || e.Orientation == PageOrientation.PortraitDown)
            { 
                MessageBox.Show("Orietantion Changed - Portrait");
            }
            else
            {
                MessageBox.Show("Orietantion Changed - Landscape");
            }
        }
    }
}