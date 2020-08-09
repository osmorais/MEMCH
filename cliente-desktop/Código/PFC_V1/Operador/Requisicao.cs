using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PFC_V1.Operador
{
    class Requisicao
    {
        public static string realizarSemConteudo(HttpWebRequest httpWebRequest)
        {
            string resultado;
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                resultado = streamReader.ReadToEnd();
            }

            return resultado;
        }
        public static string realizarComConteudo(string conteudo, HttpWebRequest httpWebRequest)
        {
            string resultado;
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(conteudo);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                resultado = streamReader.ReadToEnd();
            }

            return resultado;
        }
    }
}
