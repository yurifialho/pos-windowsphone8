using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LifeCicle.Resources;

namespace LifeCicle
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            MessageBox.Show("NavigatedFrom");
            this.State["textName"] = this.txtNome.Text;
            

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            MessageBox.Show("NavigatedTo");

            if (this.State.ContainsKey("textName"))
            {
                this.txtNome.Text = (String) this.State["textName"];
            }
        }
    }
}