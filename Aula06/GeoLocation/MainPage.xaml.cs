using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using GeoLocation.Resources;
using System.Device.Location;
using System.Windows.Shapes;
using System.Windows.Media;
using Microsoft.Phone.Maps.Controls;

namespace GeoLocation
{
    public partial class MainPage : PhoneApplicationPage
    {

        GeoCoordinateWatcher geo;

        public MainPage()
        {
            InitializeComponent();

            geo = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            geo.PositionChanged += geo_PositionChanged;
            geo.Start();
        }

        void geo_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {

            txtValores.Text = string.Format(" Altitude: {0:F2} - Longitude: {1:F2} - Latitude: {2:F2}",
                e.Position.Location.Altitude, e.Position.Location.Longitude, e.Position.Location.Latitude);

            //Mapa.ConvertViewportPointToGeoCoordinate(new Point( e.Position.Location.Longitude, e.Position.Location.Latitude));
            Mapa.Center = new GeoCoordinate(e.Position.Location.Latitude, e.Position.Location.Longitude );
            //Mapa.MapElements.Add()
            
            Mapa.ZoomLevel = 13;

            Ellipse el = new Ellipse();
            el.Width = 20;
            el.Height = 20;
            el.Fill = new SolidColorBrush(Colors.Red);

            MapOverlay over = new MapOverlay();
                over.Content = el;
                over.GeoCoordinate = e.Position.Location;
                over.PositionOrigin = new Point(0.5, 0.5);
                MapLayer layer = new MapLayer();
                
                layer.Add(over);
            Mapa.Layers.Clear();
            Mapa.Layers.Add(layer);
        }

    }
}