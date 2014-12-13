using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploContatos
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Foto { get; set; }

        public Contato(string nome, string foto)
        {
            Nome = nome;
            Foto = foto;
        }
    }
}
