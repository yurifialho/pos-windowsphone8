using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ConsultaWebServiceJson.Resources;
using System.Runtime.Serialization.Json;

namespace ConsultaWebServiceJson
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            WebClient client = new WebClient();
            client.OpenReadCompleted += (s, evt) =>
            {
                DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(FlickrResult));
                FlickrResult result = (FlickrResult)jsonSer.ReadObject(evt.Result);

                this.lstImage.ItemsSource = result.Photos.Photo;

                SystemTray.GetProgressIndicator(this).IsVisible = false;
            };
            client.OpenReadAsync(new Uri("https://api.flickr.com/services/rest/?method=flickr.interestingness.getList&api_key=0824635474307ddd7227504a282336db&format=json&nojsoncallback=1&api_sig=7f813fd8a3937e30aa8396bd98b2b440"));

            ProgressIndicator p = new ProgressIndicator();
            p.IsVisible = true;
            p.IsIndeterminate = true;
            p.Text = "Carregando imagens...";

            SystemTray.SetProgressIndicator(this, p);

        }

       
    }
}