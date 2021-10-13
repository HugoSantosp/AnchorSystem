using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnchorSystem.Telas
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            lblClientes.Location = new Point((pnlClientes.Width / 2) - (lblClientes.Size.Width / 2), (pnlClientes.Height / 2) - (lblClientes.Size.Height / 2));
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
