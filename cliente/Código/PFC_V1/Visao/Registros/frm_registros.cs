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
using PFC_V1.Controle;

namespace PFC_V1.Visao
{
    public partial class frm_registros : Form
    {
        private Conexao conexao;
        //private List<Registro> arrregistro;

        public frm_registros(Conexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        private void frm_registros_Load(object sender, EventArgs e)
        {
            try { encheRegistro(); } catch (Exception ex) { }
        }
        private void encheRegistro()
        {
            IOperadorREST op = new OperadorJson();
            CtrlHidrometro controle = new CtrlHidrometro();
			Hidrometro hidrometro = new Hidrometro();
			hidrometro.id = this.conexao.hidrometro.id;
			
			List<Registro> arrregistro = controle.consultar<Hidrometro>(hidrometro, op, this.conexao).registros;
			DataTable tabelaRegistro = new DataTable();

            tabelaRegistro.Columns.Add("Id", typeof(int));
            tabelaRegistro.Columns.Add("Valor", typeof(double));
            tabelaRegistro.Columns.Add("Data", typeof(DateTime));

            foreach (Registro registro in arrregistro)
            {
                tabelaRegistro.Rows.Add(
                    registro.id,
                    registro.valor,
                    registro.data);
            }

            dgvRegistro.DataSource = tabelaRegistro;
            //dgvRegistro.Columns["Id"].Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
