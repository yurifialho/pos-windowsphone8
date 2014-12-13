using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BancoDeDados.Resources;

namespace BancoDeDados
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            CarregarAlunos();
        }

        void CarregarAlunos()
        {
            using (EscolaDataContext db = new EscolaDataContext(EscolaDataContext.Connection))
            {
                List<Aluno> lista = (from al in db.Alunos
                                     //where al.Nome == "Yuri"
                                     select al).ToList();
                lstAlunos.ItemsSource = lista;
            }
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = txtNome.Text;
            aluno.Matricula = int.Parse(txtMatricula.Text);

            using (EscolaDataContext db = new EscolaDataContext(EscolaDataContext.Connection))
            {
                db.Alunos.InsertOnSubmit(aluno);
                db.SubmitChanges();

                MessageBox.Show("Aluno adicionado");
                txtNome.Text = "";
                txtMatricula.Text = "";

                CarregarAlunos();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Remover", MessageBoxButton.OKCancel) == MessageBoxResult.OK) { 
                Button bt = (Button)sender;
                Aluno aluno = (Aluno)bt.DataContext;

                using (EscolaDataContext db = new EscolaDataContext(EscolaDataContext.Connection))
                {
                    db.Alunos.Attach(aluno);
                    db.Alunos.DeleteOnSubmit(aluno);
                    db.SubmitChanges();
                
                    CarregarAlunos();

                }
            }
            /*
            string value = ((Button)sender).CommandParameter.ToString();

            using (EscolaDataContext db = new EscolaDataContext(EscolaDataContext.Connection))
            {
                Aluno aluno = (from al in db.Alunos
                               where al.Id == int.Parse(value)
                               select al).Single();
                db.Alunos.DeleteOnSubmit(aluno);
                db.SubmitChanges();
                MessageBox.Show("Aluno removido");

                CarregarAlunos();
            }
            */
            
        }
    }
}