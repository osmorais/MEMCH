using PFC_V1.Controle;
using PFC_V1.Modelo;
using PFC_V1.Operador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC_V1.Visao
{
	public partial class frm_atualizar_regra : Form
	{
		private Regra regra;
		private List<RegraTipo> arrregratipo;
		private Conexao conexao;
		public frm_atualizar_regra(Regra regra, Conexao conexao)
		{
			InitializeComponent();
			this.regra = regra;
			this.conexao = conexao;
		}

		private void frm_atualizar_regra_Load(object sender, EventArgs e)
		{
			iniciarCampos();
		}

		private void iniciarCampos()
		{
			txb_gasto_limite.Text = regra.valor.ToString();
			ckb_ativo_conexao.Checked = regra.ativo;
			txb_periodo.Text = regra.periodo.ToString();
			preecherCmbRegraTipo();
			cmb_tipo.SelectedIndex = regra.tipo.id;
		}

		private void preecherCmbRegraTipo()
		{
			recuperarRegras(this.arrregratipo);

			DataTable tabelaRegraTipo = new DataTable();

			tabelaRegraTipo.Columns.Add("Id", typeof(int));
			tabelaRegraTipo.Columns.Add("Descricao", typeof(string));

			foreach (RegraTipo regratipo in this.arrregratipo)
			{
				tabelaRegraTipo.Rows.Add(
					regratipo.id,
					regratipo.descricao);
			}

			cmb_tipo.ValueMember = "Id";
			cmb_tipo.DisplayMember = "Descricao";
			cmb_tipo.DataSource = tabelaRegraTipo;
			
		}

		private void recuperarRegras(List<RegraTipo> arrregratipo)
		{
			IOperadorREST op = new OperadorJson();
			ControleExterno controle = new ControleExterno();

			arrregratipo = controle.listarRegraTipo<RegraTipo>(
				new Uri("http://" + conexao.host + ":8080/servidor/servico/"), op);
		}
	}
}
