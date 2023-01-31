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
    public partial class Entrada : Form
    {
        private static Entrada _instance;
        public Entrada()
        {
            InitializeComponent();

        }

        public static Entrada GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Entrada();
            }

            return _instance;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanSobre jansobre = JanSobre.GetInstance();
            jansobre.MdiParent = this;
            jansobre.WindowState = FormWindowState.Normal;
            jansobre.Show();
        }

        private void desenvolvedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            JanCadastrar jancadastrar = JanCadastrar.GetInstance();
            jancadastrar.MdiParent = this;
            jancadastrar.WindowState = FormWindowState.Normal;
            jancadastrar.Show();
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanProjeto janprojeto = JanProjeto.GetInstance();
            janprojeto.MdiParent = this;
            janprojeto.WindowState = FormWindowState.Normal;
            janprojeto.Show();
        }

        private void alocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanAlocacao janalocacao = JanAlocacao.GetInstance();
            janalocacao.MdiParent = this;
            janalocacao.WindowState = FormWindowState.Normal;
            janalocacao.Show();
        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanTarefas jantarefas = JanTarefas.GetInstance();
            jantarefas.MdiParent = this;
            jantarefas.WindowState = FormWindowState.Normal;
            jantarefas.Show();
        }
    }
}
   
       