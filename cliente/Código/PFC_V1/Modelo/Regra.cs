using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC_V1.Modelo
{
	public class Regra : Objeto
	{
		public double valor { get; set; }
		public int periodo { get; set; }
		public RegraTipo tipo { get; set; }
		public bool ativo { get; set; }
	}
}
