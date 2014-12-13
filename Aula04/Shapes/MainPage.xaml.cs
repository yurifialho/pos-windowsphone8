using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Shapes.Resources;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Shapes
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            createCustomPath();

        }

        private void createCustomPath()
        {
            GeometryGroup group = new GeometryGroup();

            LineGeometry line1 = new LineGeometry();
                line1.StartPoint = new Point(0, 0);
                line1.EndPoint = new Point(1, 0);

            LineGeometry line2 = new LineGeometry();
                line2.StartPoint = new Point(0, 0.5);
                line2.EndPoint = new Point(1, 0.5);

            LineGeometry line3 = new LineGeometry();
                line3.StartPoint = new Point(0, 0);
                line3.EndPoint = new Point(0, 1);

                group.Children.Add(line1);
                group.Children.Add(line2);
                group.Children.Add(line3);

            Path path = new Path();
            path.Width = 100;
            path.Height = 100;
            path.Stroke = new SolidColorBrush(Colors.White);
            path.StrokeThickness = 20;
            path.Stretch = Stretch.Fill;
            path.Data = group;

            this.panel.Children.Add(path);

        }

        
    }
}