using PFC_V1.Controle;
using PFC_V1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC_V1
{
    public partial class frm_login : Form
    {
        private Usuario usuario;
        public frm_login()
        {
            InitializeComponent();
        }
        private void frm_login_Load(object sender, EventArgs e)
        {
            usuario = new Usuario();
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            frm_cadastrar frmcadastrar = new frm_cadastrar();
            frmcadastrar.ShowDialog();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.login = txb_nome_usuario.Text;
                usuario.senha = txb_senha_acesso.Text;

                ControleInterno controle = new ControleInterno();
                controle.autenticar(ref usuario);

                frm_dashboard formulario = new frm_dashboard(usuario);
                formulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_excluir_pessoa_Click(object sender, EventArgs e)
        {

        }
    }
}
