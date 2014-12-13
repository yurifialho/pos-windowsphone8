using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Tiles.Resources;

namespace Tiles
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShellTile tileFirst = ShellTile.ActiveTiles.First();
            StandardTileData data = new StandardTileData();
                data.Title = this.txtTitle.Text;
                data.Count = 20;
                data.BackContent = "Texto na parte de trás";
            
            tileFirst.Update(data);
        }

        private void btCreateTile_Click(object sender, RoutedEventArgs e)
        {
            StandardTileData newTile = new StandardTileData();
            newTile.Title = "Page 01";

            Uri uri = new Uri("/Page1.xaml", UriKind.Relative);

            ShellTile tile = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("/Page1.xaml"));

            if(tile == null)
                ShellTile.Create(uri, newTile);
        }

    }
}