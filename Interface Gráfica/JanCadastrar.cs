using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaBD
{
    public partial class JanCadastrar : Form
    {
        private static JanCadastrar _instance;
        public JanCadastrar()
        {
            InitializeComponent();

            cbxNivel.Items.Add("Nivel: Júnior");
            cbxNivel.Items.Add("Nivel: Pleno");
            cbxNivel.Items.Add("Nivel: Sênior");
            cbxNivel.SelectedIndex = 0;
        }
        public static JanCadastrar GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanCadastrar();
            }

            return _instance;
        }

        private void lblbirthday_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {


                Desenvolvedor devprincipal = new Desenvolvedor();

                devprincipal.Nome = txtNome.Text;
                devprincipal.Nascimento = dtpNascimento.Value;

                if (cbxNivel.SelectedIndex == 0)
                {
                    devprincipal.Nivel = 'J';
                }
                if (cbxNivel.SelectedIndex == 1)
                {
                    devprincipal.Nivel = 'P';
                }
                if (cbxNivel.SelectedIndex == 2)
                {
                    devprincipal.Nivel = 'S';
                }

                Credencial credprincipal = new Credencial();

                credprincipal.Email = txtEmail.Text;
                credprincipal.Senha = txtSenha.Text;

                if (rdbAtivoSim.Checked)
                {
                    credprincipal.Ativo = true;
                }
                else if (rdbAtivoNao.Checked)
                {
                    credprincipal.Ativo = false;
                }

                if (rdbAdmSim.Checked)
                {
                    credprincipal.Administrador = true;
                }
                else if (rdbAdmNao.Checked)
                {
                    credprincipal.Administrador = false;
                }


                credprincipal.Desenvolvedor = devprincipal;
                devprincipal.Credencial = credprincipal;

                DesenvolvedorRepository.Salvar(devprincipal);

                MessageBox.Show("Desenvolvedor cadastrado com sucesso.", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro ocorreu. Tente novamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
