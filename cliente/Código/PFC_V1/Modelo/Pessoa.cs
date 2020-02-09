using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using PFC_V1.Modelo;

namespace PFC_V1
{
    public class Pessoa : Objeto
    {
        public string nome { get; set; }
        public string cpf { get; set; }
    }
}
