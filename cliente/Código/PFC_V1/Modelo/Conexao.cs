using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using PFC_V1.Modelo;

namespace PFC_V1
{
    public class Conexao : Objeto
    {
        public string host { get; set; }
        public bool ativo { get; set; }
        public string chave { get; set; }
        public string descricao { get; set; }
    }
}
