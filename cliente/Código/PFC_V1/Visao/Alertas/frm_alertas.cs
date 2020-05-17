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
	public partial class frm_alertas : Form
	{
		private Conexao conexao;
		private List<Alerta> alertas;
		public frm_alertas(Conexao conexao)
		{
			InitializeComponent();
			this.conexao = conexao;
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void frm_alertas_Load(object sender, EventArgs e)
		{
			try { preencherAlertas(recuperarAlertas(this.alertas)); } catch (Exception ex) { }
		}
		private void preencherAlertas(List<Alerta> arralerta)
		{
			DataTable tabelaAlerta = new DataTable();

			tabelaAlerta.Columns.Add("Id", typeof(int));
			tabelaAlerta.Columns.Add("Descricao", typeof(string));
			tabelaAlerta.Columns.Add("Data", typeof(DateTime));
			tabelaAlerta.Columns.Add("Regra", typeof(string));
			tabelaAlerta.Columns.Add("Gasto Limite", typeof(double));

			foreach (Alerta alerta in arralerta)
			{
				tabelaAlerta.Rows.Add(
					alerta.id,
					alerta.descricao,
					alerta.data,
					alerta.regra.tipo.descricao,
					alerta.regra.valor);
			}

			dgvAlerta.DataSource = tabelaAlerta;
			//dgvAlerta.Columns["Id"].Visible = false;
		}
		private List<Alerta> recuperarAlertas(List<Alerta> arralerta)
		{
			IOperadorREST op = new OperadorJson();
			CtrlHidrometro controle = new CtrlHidrometro();
			Hidrometro hidrometro = new Hidrometro();
			hidrometro.id = this.conexao.hidrometro.id;

			arralerta = controle.consultar<Hidrometro>(hidrometro, op, this.conexao).alertas ;

			return arralerta;
		}
	}
}
