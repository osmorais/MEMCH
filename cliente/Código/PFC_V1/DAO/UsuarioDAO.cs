using LiteDB;
using PFC_V1.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC_V1.DAO
{
    class UsuarioDAO : IUsuarioDAO
    {
        private LiteDatabase db;
        private LiteCollection<Usuario> col_usuario;
        private LiteCollection<Pessoa> col_pessoa;
        private LiteCollection<Conexao> col_connexao;
        public UsuarioDAO()
        {
            BsonMapper mapa = new BsonMapper();
            mapa.Entity<Usuario>()
                .DbRef(x => x.pessoa, "pessoa")
                .DbRef(x => x.conexoes, "conexao");
            mapa.SerializeNullValues = true;

            db = new LiteDatabase("aplicacao.db", mapa);
            col_connexao = db.GetCollection<Conexao>("conexao");
            col_pessoa = db.GetCollection<Pessoa>("pessoa");
            col_usuario = db.GetCollection<Usuario>("usuario");
        }
        public void alterar(ref Usuario usuario)
        {
            if (usuario.conexoes != null)
                col_connexao.Upsert(usuario.conexoes);
            col_pessoa.Update(usuario.pessoa);
            col_usuario.Update(usuario);
        }
        public void cadastrar(Usuario usuario)
        {
            if (col_usuario.FindOne(Query.EQ("login", usuario.login)) != null)
                throw new Exception("Usuário já existente");
            else
            {
                if (usuario.conexoes != null) col_connexao.Insert(usuario.conexoes);
                col_pessoa.Insert(usuario.pessoa);
                col_usuario.Insert(usuario);
            }
        }
        public void consultar(ref Usuario usuario)
        {
            Usuario aux = col_usuario
                .Include(x => x.conexoes)
                .Include(x => x.pessoa)
                .FindById(usuario.id);

            if (aux != null) usuario = aux;
            else throw new Exception("BD não retornou valor");
        }
        public void excluirConexao(Conexao conexao)
        {
            col_connexao.Delete(conexao.id);
        }
        public void excluirUsuario(Usuario usuario)
        {
            if (usuario.conexoes != null)
                foreach (Conexao conexao in usuario.conexoes)
                {
                    col_connexao.Delete(conexao.id);
                }
            col_pessoa.Delete(usuario.pessoa.id);
            col_usuario.Delete(usuario.id);
        }
        //public List<Usuario> listar()
        //{
        //    List<Usuario> arr_usuarios = col_usuario
        //        .Include(x => x.conexoes)
        //        .Include(x => x.pessoa)
        //        .FindAll() as List<Usuario>;

        //    return arr_usuarios;
        //}
    }
}
