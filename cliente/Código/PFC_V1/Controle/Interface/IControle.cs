using PFC_V1.Modelo;
using PFC_V1.Operador;
using System.Collections.Generic;

namespace PFC_V1.Controle.Interface
{
	interface IControle
	{
		T cadastrar<T>(Objeto objeto, IOperadorREST operador, Conexao conexao);
		List<T> listar<T>(IOperadorREST operador, Conexao conexao);
		T alterar<T>(Objeto objeto, IOperadorREST operador, Conexao conexao);
		T remover<T>(Objeto objeto, IOperadorREST operador, Conexao conexao);
	}
}
