using Newtonsoft.Json;
using PFC_V1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PFC_V1.Operador
{
    class OperadorJson : IOperadorREST
    {
        public List<T> listar<T>(Uri uriBase)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(
			    new Uri(uriBase, "json"));
			httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            string resposta = Requisicao.realizarSemConteudo(httpWebRequest);

            return JsonConvert.DeserializeObject<List<T>>(resposta);
        }

		public T cadastrar<T>(Objeto objeto, Uri uriBase)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(
				new Uri(uriBase, "json"));
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "POST";

			string resposta = Requisicao.realizarComConteudo(
				JsonConvert.SerializeObject(objeto), httpWebRequest);

			return JsonConvert.DeserializeObject<T>(resposta);
		}
	}
}
