using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC_V1.DAO
{
    public interface IUsuarioDAO
    {
        void alterar(ref Usuario usuario);
        void cadastrar(Usuario usuario);
        void consultar(ref Usuario usuario);
        void excluirConexao(Conexao conexao);
        void excluirUsuario(Usuario usuario);
    }
}
