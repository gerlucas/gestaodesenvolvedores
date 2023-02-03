using AtividadeAvaliativaBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace AtividadeAvaliativaBD
{
    public partial class JanAlocacao : Form
    {
        private static JanAlocacao _instance;
        private JanAlocacao()
        {
            InitializeComponent();
        }

        public static JanAlocacao GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanAlocacao();
            }

            return _instance;
        }
       
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Alocacao alocacao = new Alocacao(dtpInicio.Value, dtpTermino.Value, Convert.ToByte(nmrHoras.Value), Convert.ToDecimal(txtRemuneracao.Text), (Desenvolvedor)lstDevs.SelectedItem, (Projeto)lstProjetos.SelectedItem);
                AlocacaoRepository.Salvar(alocacao);
                MessageBox.Show("Alocação cadastrada com sucesso.", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception)
            {
                MessageBox.Show("Campos vazios. Tente novamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtDev_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDev.Text.Length != 0)
            {
                lstDevs.DataSource = DesenvolvedorRepository.EncontrarPorNome(txtDev.Text);
            }
            else
            {
                lstDevs.DataSource = null;
            }
        }

        private void txtProjeto_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtProjeto.Text.Length != 0)
            {
                lstProjetos.DataSource = ProjetoRepository.EncontrarPorNome(txtProjeto.Text);
            }
            else
            {
                lstProjetos.DataSource = null;
            }
        }
    }
}



     


