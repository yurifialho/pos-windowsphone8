using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TileChangeColor.Resources;
using System.Windows.Shapes;
using System.Windows.Media;

namespace TileChangeColor
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            String colorBackgroud = String.Empty;

            /*if (NavigationContext.QueryString.TryGetValue("color", out colorBackgroud))
            {
                MessageBox.Show(colorBackgroud);
            }*/

        }

        private void Rect_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Rectangle rect = (Rectangle)sender;

            StandardTileData data = new StandardTileData();
            data.Title = rect.Name;

            Uri uri = new Uri("/MainPage.xaml?color=" + rect.Name, UriKind.Relative);

            ShellTile tile = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains(uri.ToString()));
            if(tile == null)
                ShellTile.Create(uri, data);

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (NavigationContext.QueryString.ContainsKey("color"))
            {
                String color = NavigationContext.QueryString["color"];

                Color cor = Colors.Black;

                if(color.Equals("Red")) {
                    cor = Colors.Red;
                } else if(color.Equals("Green")) {
                    cor = Colors.Green;
                } else if(color.Equals("Yellow")) {
                    cor = Colors.Yellow;
                } else if(color.Equals("Brown")) {
                    cor = Colors.Brown;
                } else if(color.Equals("Purple")) {
                    cor = Colors.Purple;
                } else if(color.Equals("Blue")) {
                    cor = Colors.Blue;
                }


                Root.Background = new SolidColorBrush(cor);
            }
        }
    }
}