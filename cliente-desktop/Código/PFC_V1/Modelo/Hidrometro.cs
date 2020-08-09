using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using PFC_V1.Modelo;

namespace PFC_V1
{
    public class Hidrometro : Objeto
    {
		public string identificador { get; set; }
		public string chave { get; set; }
		public string modelo { get; set; }
		public string descricao { get; set; }
		public bool ativo { get; set; }
		public List<Registro> registros { get; set; }
		public List<Alerta> alertas { get; set; }
		public List<Regra> regras { get; set; }
	}
}
