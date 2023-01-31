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
    public partial class JanProjeto : Form
    {
        private static JanProjeto _instance;
        public JanProjeto()
        {
            InitializeComponent();
        }
        public static JanProjeto GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanProjeto();
            }

            return _instance;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Projeto projeto = new Projeto();

                projeto.Nome = txtNome.Text;
                projeto.Inicio = dtpInicio.Value;
                projeto.TerminoPlanejado = dtpTerminoPlanejado.Value;
                projeto.Termino = dtpTermino.Value;

                ProjetoRepository.Salvar(projeto);
                MessageBox.Show("Projeto cadastrado com sucesso.", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro ocorreu. Tente novamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
