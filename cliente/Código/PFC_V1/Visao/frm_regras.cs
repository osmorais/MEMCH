using PFC_V1.Controle;
using PFC_V1.Modelo;
using PFC_V1.Operador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PFC_V1.Visao
{
	public partial class frm_regras : Form
	{
		private Conexao conexao;
		public frm_regras(Conexao conexao)
		{
			InitializeComponent();
			this.conexao = conexao;
		}

		private void frm_regras_Load(object sender, EventArgs e)
		{
			try { preencherDgv(recuperarRegras()); } catch (Exception ex) { }
		}
		private void preencherDgv(List<Regra> regras)
		{
			DataTable tabelaconexao = new DataTable();

			tabelaconexao.Columns.Add("Id", typeof(int));
			tabelaconexao.Columns.Add("Gasto Limite", typeof(double));
			tabelaconexao.Columns.Add("Periodo", typeof(int));
			tabelaconexao.Columns.Add("Tipo", typeof(string));
			tabelaconexao.Columns.Add("Ativo", typeof(bool));

			foreach (Regra regra in regras)
			{
				tabelaconexao.Rows.Add(
					regra.id,
					regra.valor,
					regra.periodo,
					regra.tipo.descricao,
					regra.ativo);
			}

			dgwConexao.DataSource = tabelaconexao;
			dgwConexao.Columns["Id"].Visible = false;

		}

		private List<Regra> recuperarRegras()
		{
			IOperadorREST op = new OperadorJson();
			ControleExterno controle = new ControleExterno();

			List<Regra> arrregra = controle.listarRegra<Regra>(
				new Uri("http://" + conexao.host + ":8080/servidor/servico/"), op);

			return arrregra;
		}

		private void btn_sair_dashboard_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
