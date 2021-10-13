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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
            CustomPanel();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        //Método PARA LIMPAR OS CAMPOS
        private void Limpar()
        {
            txtAddCodigo.Text = "";
            txtAddNome.Text = "";
            txtAddEndereco.Text = "";
            txtAddTelefone.Text = "";
            cbbAddEstadoCivil.Text = "";
            cbbAddFuncao.Text = "";
            cbbAddSexo.Text = "";
            cbbAddVinculo.Text = "";
            

        }

        private void CustomPanel()
        {
            pnlLocFuncionario.Visible = false;
           pnlCdastrarFunc.Visible = false;
        }
        private void ocultarPainel()
        {
            if (pnlCdastrarFunc.Visible == true) pnlCdastrarFunc.Visible = false;
            if (pnlLocFuncionario.Visible == true) pnlLocFuncionario.Visible = false;
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



        private void btnLocalizarFuncionario_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlLocFuncionario);
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlCdastrarFunc);
        }
    }
}
