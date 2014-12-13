using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace ExemploContatos
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            CarregarLista();
        }

        void CarregarLista()
        {
            List<Contato> list = new List<Contato>();

            for (int i = 0; i < 5; i++)
            {
                Contato c = new Contato("Pessoa " + i, "Assets/Fotos/" + (i + 1) + ".jpg");
                list.Add(c);
            }
            lstContatos.ItemsSource = list;
        }

        private void lstContatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contato c = (Contato)lstContatos.SelectedItem;

            Uri uri = new Uri(c.Foto, UriKind.Relative);
            BitmapImage bmp = new BitmapImage(uri);
            imgFoto.Source = bmp;
            txtNome.Text = c.Nome;

            pivot.SelectedIndex = 1;
        }

        private void btnDetalhes_Click(object sender, RoutedEventArgs e)
        {
            pivot.SelectedIndex = 0;
        }
    }
}