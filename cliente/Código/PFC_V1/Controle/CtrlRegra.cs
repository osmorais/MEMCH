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
	class CtrlRegra : IControle
	{
		string uri = "http://{0}:8080/servidor/servico/regra/";

		public T alterar<T>(Objeto objeto, IOperadorREST operador, Conexao conexao)
		{
			throw new System.InvalidOperationException("Operação invalida.");
		}

		public T cadastrar<T>(Objeto objeto, IOperadorREST operador, Conexao conexao)
		{
			throw new System.InvalidOperationException("Operação invalida.");
		}

		public List<T> listar<T>(IOperadorREST operador, Conexao conexao)
		{
			throw new System.InvalidOperationException("Operação invalida.");
		}

		public T remover<T>(Objeto objeto, IOperadorREST operador, Conexao conexao)
		{
			return operador.enviarConteudo<T>(objeto, new Uri(string.Format(this.uri, conexao.host) + "remover/"));
		}
	}
}
