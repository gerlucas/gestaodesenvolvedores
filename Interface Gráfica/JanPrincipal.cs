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
    public partial class Entrada : Form
    {
        private static Entrada _instance;
        private Entrada(Desenvolvedor dev)
        {
            InitializeComponent();
            if(dev.Credencial.Administrador == true)
            {
                desenvolvedorToolStripMenuItem1.Visible = true;
                projetosToolStripMenuItem.Visible = true;
                alocaçãoToolStripMenuItem.Visible = true;
                tarefasToolStripMenuItem.Visible = true;
            }
        }

        public static Entrada GetInstance(Desenvolvedor dev)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Entrada(dev);
            }

            return _instance;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanLogin janlogin = JanLogin.GetInstance();
            janlogin.Show();
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

        private void Entrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            JanLogin janlogin = JanLogin.GetInstance();
            janlogin.Show();
        }

        private void desenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanPesquisaDev janpesquisadev = JanPesquisaDev.GetInstance();
            janpesquisadev.MdiParent = this;
            janpesquisadev.WindowState = FormWindowState.Normal;
            janpesquisadev.Show();
        }
    }
}
   
       