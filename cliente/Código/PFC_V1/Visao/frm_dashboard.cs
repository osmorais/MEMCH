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
using PFC_V1;
using PFC_V1.Controle;
using PFC_V1.DAO;
using PFC_V1.Operador;
using PFC_V1.Visao;

namespace PFC_V1
{
    public partial class frm_dashboard : Form
    {
        private Usuario usuario;
		private Conexao conexao;
        public frm_dashboard(Usuario usuario)
        {
            InitializeComponent();
			this.conexao = new Conexao();
			recuperarUsuario(usuario);
        }
        private void frm_dashboard_Load(object sender, EventArgs e)
        {
            preencherDgv(usuario.conexoes);
            Text = "MEMCH - " + usuario.pessoa.nome.ToUpper();
        }
        private void btn_sair_dashboard_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tsm_alterar_usuario_Click(object sender, EventArgs e)
        {
            frm_atualizar_usuario formulario = new frm_atualizar_usuario(usuario);
            formulario.ShowDialog();

            ControleInterno controle = new ControleInterno();
            controle.alterarUsuario(ref usuario);
            Text = "MEMCH - " + usuario.pessoa.nome.ToUpper();
        }
        private void tsm_excluir_usuario_Click(object sender, EventArgs e)
        {
            frm_excluir_usuario formulario = new frm_excluir_usuario(usuario);
            DialogResult confirmação = formulario.ShowDialog();

            if (confirmação == DialogResult.OK)
            {
                ControleInterno controle = new ControleInterno();
                controle.excluirUsuario(usuario);
                Close();
            }
        }
        private void btn_nova_conexao_Click(object sender, EventArgs e)
        {
			try
			{
				frm_nova_conexao formulario = new frm_nova_conexao(usuario);
				formulario.ShowDialog();
				preencherDgv(usuario.conexoes);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
				btn_nova_conexao_Click(sender, e);
			}
        }
        private void btn_editar_conexao_Click(object sender, EventArgs e)
        {
            Conexao conexao_alteravel = retornarConexaoDgv();
			try
			{
				if (conexao_alteravel != null)
				{
					frm_atualizar_conexao formulario = new frm_atualizar_conexao(conexao_alteravel, usuario);
					formulario.ShowDialog();
					preencherDgv(usuario.conexoes);
				}
				else
				{
					MessageBox.Show("Não há conexão para editar!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
        private void btn_deletar_conexao_Click(object sender, EventArgs e)
        {
            Conexao conexao_deletavel = retornarConexaoDgv();
            if (conexao_deletavel != null)
            {
                usuario.conexoes.Remove(conexao_deletavel);

                ControleInterno controle = new ControleInterno();
                controle.excluirConexao(conexao_deletavel);
                recuperarUsuario(usuario);
                preencherDgv(usuario.conexoes);
                MessageBox.Show("Conexão excluída com Sucesso!!!");
            }
            else
            {
                MessageBox.Show("Não há conexão para excluir!");
            }
        }
        private void btn_acessar_registros_Click(object sender, EventArgs e)
        {
            frm_registros formulario = new frm_registros(retornarConexaoDgv());
            formulario.ShowDialog();
        }
        private void recuperarUsuario(Usuario usuario)
        {
            ControleInterno controleinterno = new ControleInterno();
            controleinterno.recuperarUsuario(ref usuario);

			IOperadorREST op = new OperadorJson();
			CtrlConexao controle = new CtrlConexao();

			usuario.conexoes = controle.listar<Conexao>(op, this.conexao);

			this.usuario = usuario;
        }
        private void preencherDgv(List<Conexao> conexoes)
        {
            if (usuario.conexoes != null)
            {
                DataTable tabelaconexao = new DataTable();

                tabelaconexao.Columns.Add("Id", typeof(int));
                tabelaconexao.Columns.Add("Host", typeof(string));
                tabelaconexao.Columns.Add("Ativo", typeof(bool));
                tabelaconexao.Columns.Add("Descrição", typeof(string));
				tabelaconexao.Columns.Add("Hidrometro", typeof(string));
				tabelaconexao.Columns.Add("Modelo", typeof(string));

				foreach (Conexao conexao in conexoes)
                {
                    tabelaconexao.Rows.Add(
                        conexao.id,
                        conexao.host,
                        conexao.ativo,
                        conexao.descricao,
						conexao.hidrometro.identificador,
						conexao.hidrometro.modelo);
                }

                dgwConexao.DataSource = tabelaconexao;
                dgwConexao.Columns["Id"].Visible = false;
            }
        }
        private Conexao retornarConexaoDgv()
        {
            if (usuario.conexoes != null || usuario.conexoes.Count > 0)
            {
                Conexao conexao = new Conexao();

                int id = (int)dgwConexao.SelectedRows[0].Cells["Id"].Value;
                foreach (Conexao aux in usuario.conexoes)
                    if (id == aux.id) conexao = aux;

                return conexao;
            }
            else
            {
                return null;
            }
        }

		private void btn_alerta_Click(object sender, EventArgs e)
		{
			frm_alertas formulario = new frm_alertas(retornarConexaoDgv());
			formulario.ShowDialog();
		}

		private void btn_regra_Click(object sender, EventArgs e)
		{
			frm_regras formulario = new frm_regras(retornarConexaoDgv());
			formulario.ShowDialog();
		}
	}
}
