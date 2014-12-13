using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BrTimeTrabalho.Resources;
using System.IO.IsolatedStorage;
using System.Xml.Linq;
using Microsoft.Phone.Tasks;
using System.Data.Linq.Mapping;

namespace BrTimeTrabalho
{
    [Table]
    public class Noticia
    {
        [Column(IsDbGenerated=true, IsPrimaryKey=true)]
        public int Id { get; set; }
        [Column()]
        public string Titulo { get; set; }
        [Column()]
        public string Link { get; set; }
        [Column()]
        public string Time { get; set; }
    }

    public partial class MainPage : PhoneApplicationPage
    {
        public static string SETTINGS_KEY = "time_selecionado";
        public static string SETTINGS_KEY_NOME = "time_selecionado_nome";

        public string TIME_SELECIONADO = null;
        public string TIME_SELECIONADO_NOME = null;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            CarregarFavoritos();
        }

        private void changeTime_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button) sender;

            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            settings[SETTINGS_KEY] = bt.Name;
            settings[SETTINGS_KEY_NOME] = bt.Content;
            settings.Save();
            TIME_SELECIONADO = bt.Name;
            TIME_SELECIONADO_NOME = (string)bt.Content;
            
            CarregarNoticias();
            
        }

        private void goToMudarTime_Click(object sender, EventArgs e)
        {
            pivotTime.SelectedIndex = 0;
        }

        private void fixarTeleInicial_Click(object sender, EventArgs e)
        {
            if (TIME_SELECIONADO_NOME != null)
            {
                StandardTileData newTile = new StandardTileData();
                newTile.Title = TIME_SELECIONADO_NOME;
                string keyPage = "/MainPage.xaml?time=" + TIME_SELECIONADO + "&time_nome=" + TIME_SELECIONADO_NOME;
                Uri uri = new Uri(keyPage, UriKind.Relative);
                ShellTile tile = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains(keyPage));
                if (tile == null) { 
                    ShellTile.Create(uri, newTile);
                }
                else
                {
                    MessageBox.Show("Time já fixado na tela inicial");
                }
            }
        }

        private void adicionarFavorito_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            Noticia noticia = (Noticia)bt.DataContext;

            using (BrTimeTrabalhoDataContext db = new BrTimeTrabalhoDataContext(BrTimeTrabalhoDataContext.CONNECTION))
            {
                noticia.Time = TIME_SELECIONADO_NOME;
                db.Favoritos.InsertOnSubmit(noticia);
                db.SubmitChanges();
            }

            CarregarFavoritos();
            this.pivotTime.SelectedIndex = 2;
        }

        private void viewNoticia_Click(object sender, System.Windows.Input.GestureEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();

            TextBlock link = (TextBlock)sender;
            Noticia noticia = (Noticia)link.DataContext;

            webBrowserTask.Uri = new Uri(noticia.Link, UriKind.Absolute);

            webBrowserTask.Show();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            if (NavigationContext.QueryString.ContainsKey("time"))
            {
                TIME_SELECIONADO = NavigationContext.QueryString["time"];
                TIME_SELECIONADO_NOME = NavigationContext.QueryString["time_nome"];
                CarregarNoticias();
            }
            else if (settings.Contains(SETTINGS_KEY))
            {
                TIME_SELECIONADO = (string)settings[SETTINGS_KEY];
                TIME_SELECIONADO_NOME = (string)settings[SETTINGS_KEY_NOME];
                CarregarNoticias();
            }
        }

        void CarregarNoticias()
        {
            
            if (TIME_SELECIONADO_NOME != null)
            {
                labelNoticias.Text = TIME_SELECIONADO_NOME;
                pivotTime.SelectedIndex = 1;
            }

            ListarNoticias();
        }

        void ListarNoticias()
        {
            if (TIME_SELECIONADO != null)
            {
                Uri uri = new Uri("http://esporte.uol.com.br/futebol/clubes/"+TIME_SELECIONADO+".xml");
                WebClient client = new WebClient();
                client.OpenReadCompleted += (s, evt) =>
                {
                    XDocument doc = XDocument.Load(evt.Result);

                    List<Noticia> noticias = new List<Noticia>();

                    foreach (var item in doc.Descendants("item"))
                    {
                        Noticia not = new Noticia();
                        not.Titulo = ((string)item.Element("title")).Substring(0,30) + "...";
                        not.Link = (string)item.Element("link");

                        noticias.Add(not);
                    }

                    this.listNoticiaTimes.ItemsSource = noticias;
                };
                client.OpenReadAsync(uri);
            }
        }


        void CarregarFavoritos()
        {
            using (BrTimeTrabalhoDataContext db = new BrTimeTrabalhoDataContext(BrTimeTrabalhoDataContext.CONNECTION))
            {
                var result = (from no in db.Favoritos select no);
                if (result != null) { 
                List<Noticia> noticias = result.ToList();
                this.listFavoritos.ItemsSource = noticias;
                }
            }
        }
        

        

        
    }
}