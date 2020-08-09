using PFC_V1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC_V1.Controle
{
    public class ControleInterno
    {
        public void autenticar(ref Usuario usuario)
        {
            IAutenticacaoDAO autenticador = new AutenticacaoDAO();
            autenticador.executar(ref usuario);
        }
        public void alterarUsuario(ref Usuario usuario)
        {
            IUsuarioDAO dao = new UsuarioDAO();
            dao.alterar(ref usuario);
        }
        public void criarUsuario(Usuario usuario)
        {
            IUsuarioDAO dao = new UsuarioDAO();
            dao.cadastrar(usuario);
        }
        public void excluirUsuario(Usuario usuario)
        {
            IUsuarioDAO dao = new UsuarioDAO();
            dao.excluirUsuario(usuario);
        }
        public void recuperarUsuario(ref Usuario usuario)
        {
            IUsuarioDAO dao = new UsuarioDAO();
            dao.consultar(ref usuario);
        }
        public void atualizarConexoes(ref Usuario usuario)
        {
            IUsuarioDAO dao = new UsuarioDAO();
            dao.alterar(ref usuario);
        }
        public void excluirConexao(Conexao conexao)
        {
            IUsuarioDAO dao = new UsuarioDAO();
            dao.excluirConexao(conexao);
        }
    }
}
