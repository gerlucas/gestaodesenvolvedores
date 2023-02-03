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
    public partial class JanSobre : Form
    {
        private static JanSobre _instance;
        private JanSobre()
        {
            InitializeComponent();
        }
        public static JanSobre GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanSobre();
            }

            return _instance;
        }
    }
}
