using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ConsultaWebService.Resources;
using System.Xml.Linq;

namespace ConsultaWebService
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btPesquisar_Click(object sender, RoutedEventArgs e)
        {
            //http://republicavirtual.com.br/cep/exemplos.php
            Uri uri = new Uri("http://cep.republicavirtual.com.br/web_cep.php?cep=" + txtcep.Text + "&formato=xml");
            WebClient client = new WebClient();
            client.OpenReadCompleted += (s, evt) =>
            {
                XDocument doc = XDocument.Load(evt.Result);

                foreach (var item in doc.Descendants("webservicecep"))
                {
                    txtResultado.Text = string.Format("UF = {0}, Cidade = {1}, Bairro = {2}",
                        (string)item.Element("uf"), (string)item.Element("cidade"), (string)item.Element("bairro"));
                }
                
            };
            client.OpenReadAsync(uri);
        }
    }
}