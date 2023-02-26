using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanCosta
{
    public class Banco
    {


        public List<Usuarios> listUsrs { get; set; }


        public Banco()
        {

            listUsrs = new List<Usuarios>();
        }

        public Banco(List<Usuarios> user)
        {

            listUsrs = user;
        }
    }
}
