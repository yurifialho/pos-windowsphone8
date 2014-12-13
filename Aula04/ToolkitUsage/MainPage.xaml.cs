using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ToolkitUsage.Resources;
using System.Windows.Media;

namespace ToolkitUsage
{
    public partial class MainPage : PhoneApplicationPage
    {
        private int angle = 0;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Pequeno.IsChecked = true;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void ligarVideo_Checked(object sender, RoutedEventArgs e)
        {
            video.Play();
        }

        private void ligarVideo_Unchecked(object sender, RoutedEventArgs e)
        {
            video.Stop();
        }

        private void Pequeno_Checked(object sender, RoutedEventArgs e)
        {
            TransformGroup group = new TransformGroup();
            ScaleTransform scale = new ScaleTransform();
                scale.ScaleX = 1;
                scale.ScaleY = 1;
                group.Children.Add(scale);

                RotateTransform rotate = new RotateTransform();
                rotate.Angle = angle;

                group.Children.Add(rotate);
                video.RenderTransform = group;
        }

        private void Grande_Checked(object sender, RoutedEventArgs e)
        {
            TransformGroup group = new TransformGroup();
                

            ScaleTransform scale = new ScaleTransform();
            scale.ScaleX = 3;
            scale.ScaleY = 3;
            group.Children.Add(scale);
            

            RotateTransform rotate = new RotateTransform();
            rotate.Angle = angle;
            group.Children.Add(rotate);
            video.RenderTransform = group;
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            TransformGroup group = new TransformGroup();
            RotateTransform rotate = new RotateTransform();
            rotate.Angle = angle;
            angle += 90;
            

            ScaleTransform scale = new ScaleTransform();
            if (Pequeno.IsChecked.Value)
            {
                scale.ScaleX = 1;
                scale.ScaleY = 1;
                
            }
            else
            {
                scale.ScaleX = 2;
                scale.ScaleY = 2;
            }
            group.Children.Add(scale);
            group.Children.Add(rotate);
            video.RenderTransform = group;
        }

        private void video_MediaEnded(object sender, RoutedEventArgs e)
        {
            ligarVideo.IsChecked = false;
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}