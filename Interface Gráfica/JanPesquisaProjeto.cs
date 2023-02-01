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
    public partial class JanPesquisaProjeto : Form
    {
        private static JanLogin _instance;
        public JanPesquisaProjeto()
        {
            InitializeComponent();
            txtEmailDev.ReadOnly = true;
            txtNomeDev.ReadOnly = true;
            txtSenhaDev.ReadOnly = true;
            dtpNascimentoDev.Enabled = false;
            cbxNivelDev.Enabled = false;
            
        }
        public static JanLogin GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanLogin();
            }

            return _instance;
        }
    }
}
