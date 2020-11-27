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
	class CtrlConexao : IControle
	{
		string uri = "http://10.1.1.3:8080/servidor/servico/conexao/";

		public T alterar<T>(Objeto objeto, IOperadorREST operador, Conexao conexao)
		{
			return operador.enviarConteudo<T>(objeto, new Uri(this.uri + "alterar/"));
		}

		public T cadastrar<T>(Objeto objeto, IOperadorREST operador, Conexao conexao)
		{
			return operador.enviarConteudo<T>(conexao, new Uri(this.uri + string.Concat("cadastrar/", objeto.id, "/")));
		}

		public List<T> listar<T>(IOperadorREST operador, Conexao conexao)
		{
			return operador.retornarConteudo<T>(new Uri(this.uri + "listar/"));
		}

		public List<T> listar<T>(Objeto objeto, IOperadorREST operador, Conexao conexao)
		{
			return operador.retornarConteudo<T>(new Uri(this.uri + string.Concat("listar/", objeto.id, "/")));
		}

		public T remover<T>(Objeto objeto, IOperadorREST operador, Conexao conexao)
		{
			return operador.enviarConteudo<T>(objeto, new Uri(this.uri + "remover/"));
		}
	}
}
