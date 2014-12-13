using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrTimeTrabalho
{
    class BrTimeTrabalhoDataContext : DataContext
    {
        public static string CONNECTION = "isostore:/brtimetrabalho.sdf";

        public Table<Noticia> Favoritos;

        public BrTimeTrabalhoDataContext(string connection)
            : base(connection)
        {

        }
    }
}
