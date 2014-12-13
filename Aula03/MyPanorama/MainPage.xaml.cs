using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyPanorama.Resources;

namespace MyPanorama
{

    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }

        public override string ToString()
        {
            return "Nome:" + Nome + " - Idade:" + Idade;
        }
    }

    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            for (int i = 0; i < 11; i++)
            {
                lstAlunos.Items.Add(new Aluno() { Nome = "Aluno " + i, Idade = i, Cidade = "Cidade " + i });
            }
        }

        private void selecionarAluno(object sender, SelectionChangedEventArgs e)
        {
            ListBox list = (ListBox)sender;
            Aluno aluno = (Aluno)list.SelectedItem;

            MessageBox.Show("Aluno " + aluno.Nome + " da Cidade " + aluno.Cidade);
        }
    }
}