﻿using PFC_V1.Controle;
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

namespace PFC_V1.Visao.Regra
{
	public partial class frm_nova_regra : Form
	{
		private Conexao conexao;
		private List<RegraTipo> arrregratipo;
		public frm_nova_regra(Conexao conexao)
		{
			InitializeComponent();
			this.conexao = conexao;
		}

		private void btn_cadastrar_regra_Click(object sender, EventArgs e)
		{
			try
			{
				PFC_V1.Modelo.Regra regra = new Modelo.Regra();
				if (String.IsNullOrEmpty(txb_gasto_limite.Text) || String.IsNullOrEmpty(txb_periodo.Text))
				{
					throw new System.InvalidOperationException("Necessário preencimento de todos os campos.");
				}

				regra.tipo = new RegraTipo();
				if (Int32.TryParse(cmb_tipo.SelectedValue.ToString(), out int tipoaux)) { regra.tipo.id = tipoaux; }

				for (int i = 0; i < this.arrregratipo.Count; i++) if (regra.tipo.id == arrregratipo[i].id) regra.tipo = arrregratipo[i];

				try { regra.valor = Convert.ToDouble(txb_gasto_limite.Text); } catch (Exception ex) {
					throw new System.InvalidOperationException("O campo \"Gasto Limite\" só aceita números");}

				if (!int.TryParse(txb_periodo.Text, out int periodoaux)) { throw new System.InvalidOperationException("O campo \"Periodo\" aceita apenas números inteiros (dias).");}
				else { regra.periodo = periodoaux; }

				regra.ativo = ckb_ativo.Checked;

				IOperadorREST op = new OperadorJson();
				CtrlHidrometro controle = new CtrlHidrometro();
				Hidrometro hidrometro = new Hidrometro();
				hidrometro.id = this.conexao.hidrometro.id;
				hidrometro.regras = new List<PFC_V1.Modelo.Regra>();
				hidrometro.regras.Add(regra);
				try
				{
					this.conexao.hidrometro = controle.cadastrar<Hidrometro>(hidrometro, op, this.conexao);

					MessageBox.Show("Regra cadastrada com sucesso!");
					this.Hide();
				}
				catch (Exception ex)
				{
					throw new System.InvalidOperationException("Ocorreu um erro inesperado, verifique sua conexão.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void frm_nova_regra_Load(object sender, EventArgs e)
		{
			preecherCmbRegraTipo();
		}

		private void preecherCmbRegraTipo()
		{
			IOperadorREST op = new OperadorJson();
			CtrlRegraTipo controle = new CtrlRegraTipo();

			this.arrregratipo = controle.listar<RegraTipo>(op, this.conexao);

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

		private void btn_sair_cadastro_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
