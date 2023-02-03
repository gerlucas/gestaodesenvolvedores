using AtividadeAvaliativaBD.Interface_Gráfica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaBD
{
    public partial class JanPesquisaDev : Form
    {
        private static JanPesquisaDev _instance;
        private static Desenvolvedor dev;

        private JanPesquisaDev( )
        {
            InitializeComponent();
            cbxNivelDev.Items.Add("Nivel: Júnior");
            cbxNivelDev.Items.Add("Nivel: Pleno");
            cbxNivelDev.Items.Add("Nivel: Sênior");


        }
        public static JanPesquisaDev GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanPesquisaDev();
            }
            return _instance;
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtNome.Text.Length != 0)
            {
                lstDevsPesquisa.DataSource = DesenvolvedorRepository.EncontrarPorNome(txtNome.Text);
            }
            else
            {
                lstDevsPesquisa.DataSource = null;
            }
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtNome.Text.Length != 0)
            {
                lstDevsPesquisa.DataSource = DesenvolvedorRepository.EncontrarEmail(txtNome.Text);
            }
            else
            {
                lstDevsPesquisa.DataSource = null;
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dev = lstDevsPesquisa.SelectedItem as Desenvolvedor;

            txtNomeDev.Text = $"{dev.Nome}";
            dtpNascimentoDev.Text = $"{dev.Nascimento.Date}";
            txtEmailDev.Text = $"{dev.Credencial.Email}";
            PesquisarNivel(dev);
            chkAdm.Checked = dev.Credencial.Administrador;
            chkAtivo.Checked = dev.Credencial.Ativo;
            lstAlocacoesDev.DataSource = AlocacaoRepository.EncontrarDevProjeto(dev.Nome);

            chkAtivo.Enabled = true;
            chkAdm.Enabled = true;


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dev.Credencial.Ativo = chkAtivo.Checked;
            dev.Credencial.Administrador = chkAdm.Checked;

            DesenvolvedorRepository.Salvar(dev);
            MessageBox.Show("Desenvolvedor atualizado com sucesso.", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAtualizar.Enabled = false;

        }

        private void chkAdm_Click(object sender, EventArgs e)
        {

            btnAtualizar.Enabled = true;

        }

        private void chkAtivo_Click(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = true;

        }
        private void PesquisarNivel(Desenvolvedor dev)
        {
            String level = dev.NivelDev;

            if (level == "J")
            {
                cbxNivelDev.SelectedIndex = 0;
            }
            else if (level == "P")
            {
                cbxNivelDev.SelectedIndex = 1;
            }
            else if (level == "S")
            {
                cbxNivelDev.SelectedIndex = 2;
            }
        }

        private void lblLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = null;
            txtNomeDev.Text = null;
            dtpNascimentoDev.Text = null;
            txtEmailDev.Text = null;
            cbxNivelDev.SelectedIndex = 0;
            chkAdm.Checked = false;
            chkAtivo.Checked = false;
            lstAlocacoesDev.DataSource = null;
            lstDevsPesquisa.DataSource = null;
        }


    }
}
