using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Acelerometro.Resources;
using Microsoft.Devices.Sensors;

namespace Acelerometro
{
    public partial class MainPage : PhoneApplicationPage
    {
        Accelerometer acc;
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            acc = new Accelerometer();
            acc.ReadingChanged += acc_ReadingChanged;
            acc.Start();

        }

        int Left = 100;

        private void acc_ReadingChanged(object sender, AccelerometerReadingEventArgs e)
        {
            string valores = string.Format(" X: {0:F2}  - Y: {1:F2}  - Z:  {2:F2}" , e.X, e.Y, e.Z);

            bola.Dispatcher.BeginInvoke(delegate()
            {
                if (e.X > 0)
                {
                    Canvas.SetLeft(bola, Left + 20);
                }
                else
                {
                    Canvas.SetLeft(bola, Left - 20);
                }
            });

            txtEixo.Dispatcher.BeginInvoke(delegate()
            {
                txtEixo.Text = valores;
            });
        }

        
        
    }
}