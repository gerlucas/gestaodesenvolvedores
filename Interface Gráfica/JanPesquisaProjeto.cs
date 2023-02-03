using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaBD.Interface_Gráfica
{
    public partial class JanPesquisaProjeto : Form
    {
        private static JanPesquisaProjeto _instance;
        private static Projeto proj;
        private JanPesquisaProjeto()
        {
            InitializeComponent();
            
        }
        public static JanPesquisaProjeto GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanPesquisaProjeto();
            }

            return _instance;
        }
        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtNome.Text.Length != 0)
            {
                lstProjetosPesquisa.DataSource = ProjetoRepository.EncontrarPorNome(txtNome.Text);
            }
            else
            {
                lstProjetosPesquisa.DataSource = null;
            }
        }

        private void lblLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = null;
            txtNomeProjeto.Text = null;
            dtpInicioProjeto = null;
            dtpTerminoProjeto = null;
            dtpTerminoPlanejadoProjeto = null;
            lstProjetos.DataSource = null;
            lstProjetosPesquisa.DataSource = null;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            proj = lstProjetosPesquisa.SelectedItem as Projeto;

            txtNomeProjeto.Text = $"{proj.Nome}";
            dtpInicioProjeto.Text = $"{proj.Inicio.Date}";
            dtpTerminoProjeto.Text = $"{proj.Termino.Date}";
            dtpTerminoPlanejadoProjeto.Text = $"{proj.TerminoPlanejado.Date}";
            lstProjetos.DataSource = AlocacaoRepository.EncontrarDevProjeto(txtNome.Text);

            dtpTerminoProjeto.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            proj.Termino = dtpTerminoProjeto.Value;
            ProjetoRepository.Salvar(proj);
            MessageBox.Show("Projeto atualizado com sucesso.", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnAtualizar.Enabled = false;
        }

        private void dtpTerminoProjeto_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                btnAtualizar.Enabled = true;
            }
        }
    }
}
