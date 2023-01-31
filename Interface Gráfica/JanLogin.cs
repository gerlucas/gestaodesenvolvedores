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
    public partial class JanLogin : Form
    {
        private static JanLogin _instance;
        public JanLogin()
        {
            InitializeComponent();
        }

        public static JanLogin GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanLogin();
            }

            return _instance;
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            try
            {

                Desenvolvedor developer = CredencialRepository.AutenticarDev(txtEmail.Text, txtSenha.Text);

                if (developer == null)
                {
                    MessageBox.Show("Insira novamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (developer.Credencial.Ativo == true)
                {
                    this.Hide();

                    Entrada.GetInstance().Show();

                    txtEmail.Text = null;
                    txtSenha.Text = null;
                }
                else
                {
                    MessageBox.Show("Usuário inativo.", "NÃO FOI POSSIVEL AUTENTICAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro ocorreu. Tente novamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void JanLogin_Load(object sender, EventArgs e)
        {
            Repository dbContext = new Repository();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAutenticar.PerformClick();
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '\0')
            {
                txtSenha.PasswordChar = '*';
            }
            else
            {
                txtSenha.PasswordChar = '\0';
            }
        }
    }
}

