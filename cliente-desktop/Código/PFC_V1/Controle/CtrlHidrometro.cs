using PFC_V1.Controle.Interface;
using PFC_V1.Modelo;
using PFC_V1.Operador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC_V1.Controle
{
	class CtrlHidrometro : IControle
	{
		string uri = "http://{0}:8080/servidor/servico/hidrometro/";

		public T alterar<T>(Objeto objeto, IOperadorREST operador, Conexao conexao)
		{
			return operador.enviarConteudo<T>(objeto, new Uri(string.Format(this.uri, conexao.host) + "alterar/"));
		}

		public T cadastrar<T>(Objeto objeto, IOperadorREST operador, Conexao conexao)
		{
			return operador.enviarConteudo<T>(objeto, new Uri(string.Format(this.uri, conexao.host) + "cadastrar/"));
		}

		public List<T> listar<T>(IOperadorREST operador, Conexao conexao)
		{
			return operador.retornarConteudo<T>(new Uri(string.Format(this.uri, conexao.host) + "listar/"));
		}

		public T consultar<T>(Objeto objeto, IOperadorREST operador, Conexao conexao)
		{
			return operador.enviarConteudo<T>(objeto, new Uri(string.Format(this.uri, conexao.host) + "consultar/"));
		}

		public T remover<T>(Objeto objeto, IOperadorREST operador, Conexao conexao)
		{
			return operador.enviarConteudo<T>(objeto, new Uri(string.Format(this.uri, conexao.host) + "cadastrar/"));
		}
	}
}
