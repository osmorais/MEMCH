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
		private List<PFC_V1.Modelo.Regra> regras;
		public frm_regras(Conexao conexao)
		{
			InitializeComponent();
			this.conexao = conexao;
		}

		private void frm_regras_Load(object sender, EventArgs e)
		{
			try { preencherDgv(recuperarRegras()); } catch (Exception ex) { }
		}
		private void preencherDgv(List<PFC_V1.Modelo.Regra> regras)
		{
			DataTable tabelaregra = new DataTable();

			tabelaregra.Columns.Add("Id", typeof(int));
			tabelaregra.Columns.Add("Gasto Limite", typeof(double));
			tabelaregra.Columns.Add("Periodo", typeof(int));
			tabelaregra.Columns.Add("Tipo", typeof(string));
			tabelaregra.Columns.Add("Ativo", typeof(bool));

			foreach (PFC_V1.Modelo.Regra regra in regras)
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

		private List<PFC_V1.Modelo.Regra> recuperarRegras()
		{
			IOperadorREST op = new OperadorJson();
			CtrlHidrometro controle = new CtrlHidrometro();
			Hidrometro hidrometro = new Hidrometro();
			hidrometro.id = this.conexao.hidrometro.id;

			this.regras = controle.consultar<Hidrometro>(hidrometro, op, this.conexao).regras;

			return this.regras;
		}

		private void btn_sair_dashboard_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private PFC_V1.Modelo.Regra retornarRegraDgv()
		{
			List<PFC_V1.Modelo.Regra> arrregra = this.regras;
			if (arrregra != null || arrregra.Count > 0)
			{
				PFC_V1.Modelo.Regra regra = new PFC_V1.Modelo.Regra();

				int id = (int)dgwRegras.SelectedRows[0].Cells["Id"].Value;
				foreach (PFC_V1.Modelo.Regra aux in arrregra)
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
			PFC_V1.Modelo.Regra regra_alteravel = retornarRegraDgv();
			try
			{
				if (regra_alteravel != null)
				{
					frm_atualizar_regra formulario = new frm_atualizar_regra(regra_alteravel, this.conexao);
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

		private void btn_nova_regra_Click(object sender, EventArgs e)
		{
			PFC_V1.Modelo.Regra regra_alteravel = retornarRegraDgv();
			try
			{
				if (regra_alteravel != null)
				{
					Regra.frm_nova_regra formulario = new Regra.frm_nova_regra(this.conexao);
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

		private void btn_deletar_regra_Click(object sender, EventArgs e)
		{
			PFC_V1.Modelo.Regra regra_deletavel = retornarRegraDgv();
			try
			{
				if (regra_deletavel != null)
				{
					var result = MessageBox.Show(
					"Tem certeza que deseja excluir a conexão selecionada?",
					"Confirmar Exclusão",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1);

					if (result.Equals(DialogResult.Yes))
					{
						IOperadorREST op = new OperadorJson();
						CtrlRegra controle = new CtrlRegra();

						PFC_V1.Modelo.Regra regra = controle.remover<PFC_V1.Modelo.Regra>(regra_deletavel, op, this.conexao);
						if(regra.id == 0) MessageBox.Show("Conexão excluída com Sucesso!!!");
						else { MessageBox.Show("Houve algum erro no momento da exclusão"); }
					}
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
