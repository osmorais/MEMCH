using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC_V1.Modelo
{
	public class Alerta : Objeto
	{
		public string descricao { get; set; }
		public DateTime data { get; set; }
		public Regra regra { get; set; }
	}
}
