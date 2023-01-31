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
    public partial class JanTarefas : Form

    {
        private List<Tarefa> tarefasDesignadas;

        private static JanTarefas _instance;
        public JanTarefas()
        {
            InitializeComponent();
        }
        public static JanTarefas GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanTarefas();
            }

            return _instance;
        }

        private void txtAlocacao_TextChanged(object sender, EventArgs e)
        {
            if (txtAlocacao.Text != null)
            {
                lstAlocacao.DataSource = AlocacaoRepository.EncontrarDevProjeto(txtAlocacao.Text);
            }
            else
            {
                lstAlocacao.DataSource = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTarefa.Text.Length != 0)
            {
                Alocacao alocacao = (Alocacao)lstAlocacao.SelectedItem;
                Tarefa tarefa = new Tarefa(txtTarefa.Text);
                AlocacaoRepository.SalvarTarefa(alocacao, tarefa);

                lstTarefas.DataSource = AlocacaoRepository.TarefasDesignadas(alocacao.Id);
                MessageBox.Show("Tarefa adicionada com sucesso.", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma tarefa designada. Envie novamente.", "NENHUMA TAREFA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstAlocacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alocacao alocacao = (Alocacao)lstAlocacao.SelectedItem;
            tarefasDesignadas = AlocacaoRepository.TarefasDesignadas(alocacao.Id);
            lstTarefas.DataSource = tarefasDesignadas;
        }

        private void lstTarefas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lstTarefas.SelectedIndex;
                if (selectedIndex >= 0 && selectedIndex < tarefasDesignadas.Count)
                {
                    Tarefa tarefa = tarefasDesignadas[selectedIndex];

                    using (Repository dbContext = new Repository())
                    {
                        dbContext.Tarefas.Attach(tarefa);
                        dbContext.Tarefas.Remove(tarefa);
                        dbContext.SaveChanges();
                    }

                    tarefasDesignadas.Remove(tarefa);
                    lstTarefas.DataSource = null;
                    lstTarefas.DataSource = tarefasDesignadas;
                    MessageBox.Show("Tarefa removida com sucesso.", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }           
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel remover a tarefa. Troque de alocação e tente novamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
        }
    }


