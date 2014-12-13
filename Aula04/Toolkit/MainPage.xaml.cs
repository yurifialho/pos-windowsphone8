using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Toolkit.Resources;

namespace Toolkit
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

        private void GestureListener_Hold(object sender, GestureEventArgs e)
        {

        }

        private void GestureListener_DragDelta(object sender, DragDeltaGestureEventArgs e)
        {
            
            
            //e.GetPosition(rect)
        }

       
    }
}