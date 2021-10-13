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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
            CustomPanel();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // MÉTODO PARA LIMPAR OS CAMPOS
        private void Limpar()
        {
            txtAddCodigo.Text = "";
            txtAddDescricao.Text = "";
            txtAddNome.Text = "";
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }


        //CUSTOMIZAÇÃO DOS PAINEIS LOCALIZAR E CADASTRAR
        private void CustomPanel()
        {
            pnlLocCategoria1.Visible = false;
            pnlCadastroCategoria.Visible = false;
        }
        private void ocultarPainel()
        {
            if (pnlCadastroCategoria.Visible == true) pnlCadastroCategoria.Visible = false;
            if (pnlLocCategoria1.Visible == true) pnlLocCategoria1.Visible = false;
        }

        private void MostrarSubMenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                ocultarPainel(); Submenu.Visible = true; Submenu.Dock = DockStyle.Fill;

            }
            else
                Submenu.Visible = false;
        }

        private void btnLocalizarCategoria_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlLocCategoria1);
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlCadastroCategoria);
        }

       
    }
}
