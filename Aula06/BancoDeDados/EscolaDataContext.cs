using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados
{
    public class EscolaDataContext : DataContext
    {
        public static string Connection = "isostore:/escola.sdf";
        
        
        public Table<Aluno> Alunos;

        public EscolaDataContext(string connection) : base(connection)
        {

        }
    }
}
