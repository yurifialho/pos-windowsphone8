using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CameraExample.Resources;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace CameraExample
{
    public partial class MainPage : PhoneApplicationPage
    {
        CameraCaptureTask camera;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btTirarFoto_Click(object sender, RoutedEventArgs e)
        {
            camera = new CameraCaptureTask();
            camera.Completed += (s, evt) =>
            {
                if(evt.TaskResult == TaskResult.OK) {
                    BitmapImage bmp = new BitmapImage();
                    bmp.SetSource(evt.ChosenPhoto);
                    imgFoto.Source = bmp;
                }
            };
            camera.Show();
        }

       
    }
}