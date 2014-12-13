using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using NavigationPages.Resources;

namespace NavigationPages
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

           
        }

        private void sendPagina2(object sender, RoutedEventArgs e)
        {
            Button bt = new Button();
            bt.Content = "BotaoTransferido";
            bt.Name = "btTransfer";

            App app = (App)Application.Current;
            app.BtTransfer = bt;

            Uri uri = new Uri("/Page2.xaml?texto=Yuri", UriKind.Relative);
                
            NavigationService.Navigate(uri);
        }
    }
}