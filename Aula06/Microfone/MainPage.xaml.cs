using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microfone.Resources;
using Microsoft.Xna.Framework.Audio;
using System.IO;
using System.Windows.Threading;
using Microsoft.Xna.Framework;

namespace Microfone
{
    public partial class MainPage : PhoneApplicationPage
    {

        Microphone mic = Microphone.Default;
        byte[] byffer;
        MemoryStream stream;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            DispatcherTimer time = new DispatcherTimer();
            time.Interval = TimeSpan.FromMilliseconds(50);
            time.Tick += delegate { FrameworkDispatcher.Update(); };
            time.Start();

            mic.BufferDuration = TimeSpan.FromSeconds(1);
            mic.BufferReady += (s, evt) =>
            {
                mic.GetData(byffer);
                stream.Write(byffer, 0, byffer.Length);
            };

            

        }

        private void btRec_Click(object sender, RoutedEventArgs e)
        {
            stream = new MemoryStream();
            byffer = new byte[mic.GetSampleSizeInBytes(mic.BufferDuration)];
            mic.Start();
        }

        private void btStop_Click(object sender, RoutedEventArgs e)
        {
            mic.Stop();
        }

        private void btPlay_Click(object sender, RoutedEventArgs e)
        {
            var se = new SoundEffect(stream.ToArray(), mic.SampleRate, AudioChannels.Mono);
            SoundEffect.MasterVolume = 0.7f;
            se.Play();
        }

        
    }
}