using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LayoutCanvas.Resources;
using System.Windows.Shapes;
using System.Windows.Media;

namespace LayoutCanvas
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

           
        }

        private void bt_Click(object sender, RoutedEventArgs args)
        {
            this.CanvasObj.Children.Clear();
            for (int i = 0; i < 500; i+=100)
            {
                for (int j = 0; j <700; j+=100)
                {
                    Ellipse e = new Ellipse();
                    e.Width = 100;
                    e.Height = 100;
                    e.StrokeThickness = 1;
                    if (((Button)sender).Content.ToString() == "Red")
                    {
                        e.Stroke = new SolidColorBrush(Colors.Red);
                    }
                    else if (((Button)sender).Content.ToString() == "Blue")
                    {
                        e.Stroke = new SolidColorBrush(Colors.Blue);
                    }
                    else
                    {
                        e.Stroke = new SolidColorBrush(Colors.Yellow);
                    }

                    e.SetValue(Canvas.LeftProperty, Double.Parse(""+i));
                    e.SetValue(Canvas.TopProperty, Double.Parse("" + j));

                    /* Outro jeito
                    Canvas.SetLeft(e, Double.Parse("" + i));
                    Canvas.SetTop(e, Double.Parse("" + j));
                    */
                    this.CanvasObj.Children.Add(e);
                }
            }
            
        }

        
    }
}