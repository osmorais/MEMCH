using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PFC_V1.Modelo;
using PFC_V1.Operador;
using PFC_V1.Util;

namespace PFC_V1.Controle
{
	class ControleExterno
	{
		public List<T> listar<T>(Uri uri, IOperadorREST operador)
		{
            Uri uriBase = new Uri(uri, "registro/");
            return operador.listar<T>(uriBase);
		}
	}
}
