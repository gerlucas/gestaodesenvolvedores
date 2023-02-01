using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaBD.Interface_Gráfica
{
    public partial class JanPesquisaDev : Form
    {
        private static JanPesquisaDev _instance;
        public JanPesquisaDev()
        {
            InitializeComponent();
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

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Desenvolvedor dev = lstDevsPesquisa.SelectedItem as Desenvolvedor;


            txtNomeDev.Text = $"{dev.Nome}";
            dtpNascimentoDev.Text = $"{dev.Nascimento.Date}";
            txtEmailDev.Text = dev.Credencial.Email;

            //txtSenhaDev.Text = $"{dev.Credencial.Senha}";
            //chkAdm.Checked = dev.Credencial.Administrador;
            //chkAtivo.Checked = dev.Credencial.Ativo;
            lstAlocacoesDev.DataSource = AlocacaoRepository.EncontrarDevProjeto(dev.Nome);

        }
    }
}
