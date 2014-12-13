using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using UseResources.Resources;

namespace UseResources
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((Button)e.OriginalSource).Name + " Has Clicked!");
            MessageBox.Show(((Button)sender).Name + " Has Clicked!");
        }

    }
}