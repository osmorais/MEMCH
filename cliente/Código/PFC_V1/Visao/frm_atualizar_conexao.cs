using PFC_V1.Controle;
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
    public partial class frm_atualizar_conexao : Form
    {
        private Conexao conexao;
        public frm_atualizar_conexao(Conexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }
        private void frm_atualizar_conexao_Load(object sender, EventArgs e)
        {
            iniciarCampos();
        }
        private void btn_sair_cadastro_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_atualizar_conexao_Click(object sender, EventArgs e)
        {
            conexao.host = txb_host_conexao.Text;
            conexao.ativo = ckb_ativo_conexao.Checked;
            conexao.chave = txb_chave_conexao.Text;
            conexao.descricao = txb_descricao_conexao.Text;

            Close();
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
            ckb_ativo_conexao.Checked = conexao.ativo;
            txb_chave_conexao.Text = conexao.chave;
            txb_descricao_conexao.Text = conexao.descricao;
        }
        private void verificarAlteracao() { }
    }
}
