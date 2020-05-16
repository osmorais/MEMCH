using PFC_V1.Modelo;
using PFC_V1.Operador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC_V1.Controle
{
	class CtrlRegraTipo
	{
		string uri = "http://{0}:8080/servidor/servico/regratipo/";

		public T cadastrar<T>(Objeto objeto, IOperadorREST operador, Conexao conexao)
		{
			return operador.cadastrar<T>(objeto, new Uri(string.Format(this.uri, conexao.host) + "cadastrar/"));
		}

		public List<T> listar<T>(IOperadorREST operador, Conexao conexao)
		{
			return operador.listar<T>(new Uri(string.Format(this.uri, conexao.host) + "listar/"));
		}
	}
}
