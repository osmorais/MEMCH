using PFC_V1.Controle;
using PFC_V1.Operador;
using System;
using System.Windows.Forms;

namespace PFC_V1.Visao
{
	public partial class frm_atualizar_conexao : Form
	{
		private Conexao conexao;
		private Usuario usuario;
		public frm_atualizar_conexao(Conexao conexao, Usuario usuario)
		{
			InitializeComponent();
			this.conexao = conexao;
			this.usuario = usuario;
		}
		private void frm_atualizar_conexao_Load(object sender, EventArgs e)
		{
			iniciarCampos();
		}
		private void btn_sair_cadastro_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btn_atualizar_conexao_Click(object sender, EventArgs e)
		{
			conexao.host = txb_host_conexao.Text;
			conexao.descricao = txb_descricao_conexao.Text;
			conexao.ativo = ckb_conexao_ativa.Checked;

			conexao.hidrometro.identificador = txb_identificador_hidrometro.Text;
			conexao.hidrometro.modelo = txb_modelo_hidrometro.Text;
			conexao.hidrometro.chave = txb_chave.Text;
			conexao.hidrometro.descricao = txb_descricao_hidrometro.Text;

			if (!String.IsNullOrEmpty(conexao.host) || !String.IsNullOrEmpty(conexao.hidrometro.chave) ||
				!String.IsNullOrEmpty(conexao.descricao) || !String.IsNullOrEmpty(conexao.hidrometro.identificador)
				|| !String.IsNullOrEmpty(conexao.hidrometro.modelo) || !String.IsNullOrEmpty(conexao.hidrometro.descricao))
			{
				IOperadorREST op = new OperadorJson();
				CtrlConexao controle = new CtrlConexao();
				try
				{
					conexao.hidrometro.registros = null;
					conexao = controle.alterar<Conexao>(conexao, op, this.conexao);

					for (int i = 0; i < usuario.conexoes.Count; i++)
						if (conexao.id == usuario.conexoes[i].id)
							usuario.conexoes[i] = conexao;

					ControleInterno controleinterno = new ControleInterno();
					controleinterno.atualizarConexoes(ref usuario);

					MessageBox.Show("Conexao atualizada com sucesso!");
					this.Hide();
				}
				catch (Exception ex)
				{
					throw new System.InvalidOperationException("Ocorreu um erro inesperado, verifique sua conexão.");
				}
			}
			else
			{
				throw new System.InvalidOperationException("Necessário preencimento de todos os campos.");
			}
		}

		private void txb_host_conexao_TextChanged(object sender, EventArgs e)
		{
			verificarAlteracao();
		}
		private void txb_chave_conexao_TextChanged(object sender, EventArgs e)
		{
			verificarAlteracao();
		}
		private void ckb_ativo_conexao_CheckedChanged(object sender, EventArgs e)
		{
			verificarAlteracao();
		}
		private void txb_descricao_conexao_TextChanged(object sender, EventArgs e)
		{
			verificarAlteracao();
		}
		private void iniciarCampos()
		{
			txb_host_conexao.Text = conexao.host;
			ckb_conexao_ativa.Checked = conexao.ativo;
			txb_chave.Text = conexao.hidrometro.chave;
			txb_descricao_conexao.Text = conexao.descricao;

			txb_identificador_hidrometro.Text = conexao.hidrometro.identificador;
			txb_modelo_hidrometro.Text = conexao.hidrometro.modelo;
			txb_descricao_hidrometro.Text = conexao.hidrometro.descricao;
		}
		private void verificarAlteracao() { }
	}
}
