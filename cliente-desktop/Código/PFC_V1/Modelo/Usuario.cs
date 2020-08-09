using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using PFC_V1.Modelo;

namespace PFC_V1
{
    public class Usuario : Objeto
    {
        public string login { get; set; }
        public string senha { get; set; }
        public Pessoa pessoa { get; set; }
        public List<Conexao> conexoes { get; set; }
    }
}
