using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AppBarComponent.Resources;

namespace AppBarComponent
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((ApplicationBarIconButton)sender).Text + " foi clicado !");

            if (((ApplicationBarIconButton)this.ApplicationBar.Buttons[1]).IsEnabled)
            {
                ((ApplicationBarIconButton)this.ApplicationBar.Buttons[1]).IsEnabled = false;
            }
            else
            {
                ((ApplicationBarIconButton)this.ApplicationBar.Buttons[1]).IsEnabled = true;
            }
        }
    }
}