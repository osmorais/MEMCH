using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using PFC_V1.Util;

namespace PFC_V1.DAO
{
    public class AutenticacaoDAO : IAutenticacaoDAO
    {
        private LiteDatabase db;
        public AutenticacaoDAO()
        {
            db = new LiteDatabase("aplicacao.db");
        }
        public void executar(ref Usuario usuario)
        {
            Usuario aux = db.GetCollection<Usuario>("usuario").FindOne(
                    Query.And(
                        Query.EQ("login", usuario.login),
                        Query.EQ("senha", SHA.GenerateSHA512String(usuario.senha))
                    ));

            if (aux != null) usuario = aux;
            else throw new Exception("Usuário inexistente.");
        }
    }
}
