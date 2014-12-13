using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LockScreen.Resources;
using Windows.Phone.System.UserProfile;

namespace LockScreen
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

        private async void btBackGround_Click(object sender, RoutedEventArgs e)
        {
            bool isOK = LockScreenManager.IsProvidedByCurrentApplication;

            if (!isOK)
            {
                var op = await LockScreenManager.RequestAccessAsync();

                isOK = op == LockScreenRequestResult.Granted;
            }

            if (isOK)
            {
                Windows.Phone.System.UserProfile.LockScreen.SetImageUri(new Uri("ms-appx:///Assets/back.png",UriKind.Absolute));
            }
            else
            {
                MessageBox.Show("Usuario nao liberou permissao");
            }
        }

        private void btLockNotification_Click(object sender, RoutedEventArgs e)
        {
            ShellTile tile = ShellTile.ActiveTiles.First();

            FlipTileData data = new FlipTileData();
            data.WideBackContent = "Boa Noite!";
            data.Count = 100;

            tile.Update(data);
        }

    }
}