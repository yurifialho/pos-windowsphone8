using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ArmazenamentoFile.Resources;
using System.IO.IsolatedStorage;
using System.IO;
using System.Xml.Serialization;

namespace ArmazenamentoFile
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

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            Contato contato = new Contato();
                contato.Nome = "Yuri";
                contato.Cidade = "Fortaleza";

                using (var store = IsolatedStorageFile.GetUserStoreForApplication()) {
                using (var stream = new IsolatedStorageFileStream("dados.txt", FileMode.Create, FileAccess.Write, store))
                {
                    var serializer = new XmlSerializer(typeof(Contato));
                    serializer.Serialize(stream, contato);

                    MessageBox.Show("Serializado!");
                }
                }
        }

        private void brOpen_Click(object sender, RoutedEventArgs e)
        {
            Contato contato = new Contato();
            contato.Nome = "Yuri";
            contato.Cidade = "Fortaleza";

            using (var store = IsolatedStorageFile.GetUserStoreForApplication())
            using (var stream = new IsolatedStorageFileStream("dados.txt", FileMode.Open, FileAccess.Read, store))
            using (var reader = new StreamReader(stream)) 
            {
                MessageBox.Show(reader.ReadToEnd());
            }
        }

        private void btWriteLine_Click(object sender, RoutedEventArgs e)
        {
            using (var store = IsolatedStorageFile.GetUserStoreForApplication())
            using (var stream = new IsolatedStorageFileStream("dados.txt", FileMode.Create, FileAccess.Write, store))
            using (var write = new StreamWriter(stream)) {
                write.Write("Yuri Fialho");
                MessageBox.Show("Wrote Line!");
            }
        }

        private void btPhoneSettings_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            if (!settings.Contains("setKey"))
            {
                settings["setKey"] = "CUSTOM SETTINGS";
                settings.Save();
                MessageBox.Show("Settings Saved");
            }
        }

        private void brOpenSettings_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            if (settings.Contains("setKey"))
            {
                MessageBox.Show(settings["setKey"].ToString());
                
                
            }
        }
    }
}