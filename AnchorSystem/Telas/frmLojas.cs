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
    public partial class frmLojas : Form
    {
        public frmLojas()
        {
            InitializeComponent();
            CustomPanel();
        }

        // MÉTODO DE CARREGAMENTO DO FORMULÁRIO
        private void frmLojas_Load(object sender, EventArgs e)
        {
           lblLojas.Location = new Point((pnlLojas.Width / 2) - (lblLojas.Size.Width / 2), (pnlLojas.Height / 2) - (lblLojas.Size.Height / 2));
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //MÉTODO PARA REALIZAR LIMPEZA NOS CAMPOS

        private void Limpar()
        {
            txtAddCnpj.Text = "";
            txtAddNome.Text = "";
            txtAddCodigo.Text = "";
            txtAddEndereco.Text = "";
            txtAddTelefone.Text = "";
            cbbResponsavel.Text = "";
        }


       

        private void Habilitar()
        {
            txtAddCodigo.Enabled = true;
            txtAddNome.Enabled = true;
            txtAddCnpj.Enabled = true;
            txtAddEndereco.Enabled = true;
            txtAddTelefone.Enabled = true;
            cbbResponsavel.Enabled = true;

            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnUpload.Enabled = true;
        }


        private void Desabilitar()
        {
            txtAddCodigo.Enabled = false;
            txtAddNome.Enabled = false;
            txtAddCnpj.Enabled = false;
            txtAddEndereco.Enabled =false;
            txtAddTelefone.Enabled = false;
            cbbResponsavel.Enabled = false;

            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnUpload.Enabled = false;
        }



        // MÉTODOS DOS BOTÕES PARA O FUNCIONAMENTO 
        // DE SALVAR, CRIAR UM NOVO CADASTRO
        // E CANCELAR A OPERAÇÃO
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Habilitar();
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loja Cadastrada Com Sucesso");
            Desabilitar();
            Limpar();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilitar();
            Limpar();
        }




        // CUSTOMIZANDO OS PAINELS COMO SUB MENU DE LOCALIZAR E CADASTRAR

        private void CustomPanel()
        {
            pnlCadasLoja.Visible = false;
            pnllocLoja.Visible = false;
        }
        private void ocultarPainel()
        {
            if (pnllocLoja.Visible == true) pnllocLoja.Visible = false;
            if (pnlCadasLoja.Visible == true) pnlCadasLoja.Visible = false;
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

        private void btnLocalizarLoja_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnllocLoja);
        }

        private void btnCadastrarLoja_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlCadasLoja);
        }

      
    }
}
