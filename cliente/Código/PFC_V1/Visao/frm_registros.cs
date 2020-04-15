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
            ControleExterno controle = new ControleExterno();

            List<Registro> arrregistro = controle.listarRegistro<Registro>(
                new Uri("http://" + conexao.host + ":8080/servidor/servico/"), op);
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
