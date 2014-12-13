using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DrawApplication.Resources;
using System.Windows.Shapes;
using System.Windows.Media;

namespace DrawApplication
{
    public partial class MainPage : PhoneApplicationPage
    {
        private Point currentPoint;
        private Point endPoint;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void drawCanvas_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            currentPoint = e.GetPosition(this.drawCanvas);

            Line line = new Line();
            line.X1 = currentPoint.X;
            line.Y1 = currentPoint.Y;
            line.X2 = endPoint.X;
            line.Y2 = endPoint.Y;

            endPoint = currentPoint;

            line.Stroke = new SolidColorBrush(Colors.Blue);
            line.StrokeThickness = 3;

            this.drawCanvas.Children.Add(line);
        }

        private void drawCanvas_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentPoint = e.GetPosition(this.drawCanvas);
            endPoint = currentPoint;
        }

        private void drawCanvas_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            this.drawCanvas.Children.Clear();
        }
    }
}