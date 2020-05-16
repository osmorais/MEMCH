using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using PFC_V1.Controle;
using PFC_V1.DAO;
using PFC_V1.Operador;

namespace PFC_V1
{
    public partial class frm_nova_conexao : Form
    {
        private Conexao conexao = new Conexao();
		private Hidrometro hidrometro = new Hidrometro();
		private Usuario usuario;
        public frm_nova_conexao(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }
        private void btn_sair_cadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_cadastrar_novo_Click(object sender, EventArgs e)
        {
			conexao.host = txb_host_conexao.Text;
			conexao.descricao = txb_descricao_conexao.Text;
			conexao.ativo = ckb_conexao_ativa.Checked;

			conexao.hidrometro = new Hidrometro();

			conexao.hidrometro.identificador = txb_identificador_hidrometro.Text;
			conexao.hidrometro.modelo = txb_modelo_hidrometro.Text;
			conexao.hidrometro.chave = txb_chave_conexao.Text;
			conexao.hidrometro.descricao = txb_descricao_hidrometro.Text;

			if (!String.IsNullOrEmpty(conexao.host) || !String.IsNullOrEmpty(conexao.hidrometro.chave) ||
				!String.IsNullOrEmpty(conexao.descricao) || !String.IsNullOrEmpty(conexao.hidrometro.identificador)
				|| !String.IsNullOrEmpty(conexao.hidrometro.modelo) || !String.IsNullOrEmpty(conexao.hidrometro.descricao))
			{
				if (usuario.conexoes == null) usuario.conexoes = new List<Conexao>();

				IOperadorREST op = new OperadorJson();
				CtrlConexao controle = new CtrlConexao();

				try
				{
					this.conexao = controle.cadastrar<Conexao>(conexao, op, this.conexao);
					
					usuario.conexoes.Add(conexao);
					ControleInterno controleinterno = new ControleInterno();
					controleinterno.atualizarConexoes(ref usuario);

					MessageBox.Show("Nova conexao adicionada com Sucesso!");
					this.Hide();
				}
				catch (Exception ex)
				{
					throw new System.InvalidOperationException("Ocorreu um erro inesperado, verifique sua conexão.");
				}
			}
			else {
				throw new System.InvalidOperationException("Necessário preencimento de todos os campos.");
			}
            Close();
        }
	}
}
