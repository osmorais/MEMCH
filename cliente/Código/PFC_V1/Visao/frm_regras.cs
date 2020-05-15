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
		private List<Regra> regras;
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
			DataTable tabelaregra = new DataTable();

			tabelaregra.Columns.Add("Id", typeof(int));
			tabelaregra.Columns.Add("Gasto Limite", typeof(double));
			tabelaregra.Columns.Add("Periodo", typeof(int));
			tabelaregra.Columns.Add("Tipo", typeof(string));
			tabelaregra.Columns.Add("Ativo", typeof(bool));

			foreach (Regra regra in regras)
			{
				tabelaregra.Rows.Add(
					regra.id,
					regra.valor,
					regra.periodo,
					regra.tipo.descricao,
					regra.ativo);
			}

			dgwRegras.DataSource = tabelaregra;
			dgwRegras.Columns["Id"].Visible = false;

		}

		private List<Regra> recuperarRegras()
		{
			IOperadorREST op = new OperadorJson();
			CtrlRegra controle = new CtrlRegra();

			this.regras = controle.listar<Regra>(op, this.conexao);

			return this.regras;
		}

		private void btn_sair_dashboard_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private Regra retornarRegraDgv()
		{
			List<Regra> arrregra = this.regras;
			if (arrregra != null || arrregra.Count > 0)
			{
				Regra regra = new Regra();

				int id = (int)dgwRegras.SelectedRows[0].Cells["Id"].Value;
				foreach (Regra aux in arrregra)
					if (id == aux.id) regra = aux;

				return regra;
			}
			else
			{
				return null;
			}
		}

		private void btn_editar_regra_Click(object sender, EventArgs e)
		{
			Regra regra_alteravel = retornarRegraDgv();
			try
			{
				if (regra_alteravel != null)
				{
					frm_atualizar_regra formulario = new frm_atualizar_regra(regra_alteravel,this.conexao);
					formulario.ShowDialog();
					preencherDgv(recuperarRegras());
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
	}
}
