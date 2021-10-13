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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblData.Text = DateTime.Today.Date.ToString("dd/M/yyyy");
            CustomDesingMenu();
            
        }

        //MÉTODO PARA CARREGAR O FORM DO MENU PRINCIPAL
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            AbrirBoasvindas();
        }
        
        // MÉTODO DE CONFIGURAÇÃO PARA 
        // EXIBIR OS FORMULÁRIOS RECORRENTES
        // DENTRO DO PAINEL CENTRAL
        private void Exibirform(Object abrirform)
        {
            if (this.pnlCentral.Controls.Count >0)
            {
                this.pnlCentral.Controls.RemoveAt(0);

            }

            Form frm = abrirform as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.pnlCentral.Controls.Add(frm);
            this.pnlCentral.Tag = frm;
            frm.Show();

        }

        //Formulario de boas Vindas
        private void AbrirBoasvindas()
        {
            Exibirform(new frmBoasvindas());
        }


        //CONFIGURAÇÃO DA DATA E DA HORA ATUAL DE FORMA AUTOMATICA
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblData.Text = DateTime.Today.Date.ToString("dd/M/yyyy");
        }



        /// 
        /// Desenvolvimento 
        /// Usando Design do menu com Submenu Usando Panels
        /// 

        private void CustomDesingMenu()
        {

            pnlProdutos.Visible = false;
            pnlVendas.Visible = false;
            pnlCompras.Visible = false;
            pnlConfiguracoes.Visible = false;
            pnlConsultas.Visible = false;
            pnlFerramentas.Visible = false;


        }   

        private void OcultarSubmenu()
        {
            if (pnlProdutos.Visible == true) pnlProdutos.Visible = false;
            if (pnlVendas.Visible == true) pnlVendas.Visible = false;
            if (pnlCompras.Visible == true) pnlCompras.Visible = false;
            if (pnlConfiguracoes.Visible == true) pnlConfiguracoes.Visible = false;
            if (pnlConsultas.Visible == true) pnlConsultas.Visible = false;
            if (pnlFerramentas.Visible == true) pnlFerramentas.Visible = false;
        }

        private void MostrarSubMenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                OcultarSubmenu(); Submenu.Visible = true;
            }
            else
                Submenu.Visible = false;
        }





        //MÉTODO DE ANIMAÇÃO DO MENU
        private void btnCtrlMenu_Click(object sender, EventArgs e)
        {
            if (pnlLateral.Width == 250)
            {
                pnlLateral.Width = 70;
                btnMenuProdutos.Enabled = false; btnMenuProdutos.Text = "";
                btnMenuVendas.Enabled = false; btnMenuVendas.Text = "";
                btnMenuCompras.Enabled = false; btnMenuCompras.Text = "";
                btnMenuConsultas.Enabled = false; btnMenuConsultas.Text = "";
                btnMenuConfiguracoes.Enabled = false; btnMenuConfiguracoes.Text = "";
                btnMenuFerramentas.Enabled = false; btnMenuFerramentas.Text = "";


            }
            else
            {
                pnlLateral.Width = 250;
                btnMenuProdutos.Enabled = true; btnMenuProdutos.Text = "Produtos";
                btnMenuVendas.Enabled = true; btnMenuVendas.Text = "Vendas";
                btnMenuCompras.Enabled = true; btnMenuCompras.Text = "Compras";
                btnMenuConsultas.Enabled = true; btnMenuConsultas.Text = "Consultas";
                btnMenuConfiguracoes.Enabled = true; btnMenuConfiguracoes.Text = "Configurações";
                btnMenuFerramentas.Enabled = true; btnMenuFerramentas.Text = "Ferramentas";
            }
        }

        private void btnMenuProdutos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlProdutos);
            

        }

        private void btnMenuVendas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlVendas);
            
        }

        private void btnMenuCompras_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlCompras);
            
        }

        private void btnMenuConsultas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlConsultas);
        }

        private void btnMenuFerramentas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlFerramentas);
        }

        private void btnMenuConfiguracoes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlConfiguracoes);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja Realmente Efetuar o Logout", "Logout", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }    


        //  BOTÕES DE SUBMENU 
        private void btnSubProdutos_Click(object sender, EventArgs e)
        {
            Exibirform(new frmProdutos());
        }

        private void btnSubCategorias_Click(object sender, EventArgs e)
        {
            Exibirform(new frmCategorias());
        }

        private void btnSubVendas_Click(object sender, EventArgs e)
        {
           
        }
        private void btnSubClientes_Click(object sender, EventArgs e)
        {
            Exibirform(new frmClientes());
        }

        private void btnSubFuncionarios_Click(object sender, EventArgs e)
        {
            Exibirform(new frmFuncionarios());
        }

        private void btnSubLojas_Click(object sender, EventArgs e)
        {
            Exibirform(new frmLojas());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirBoasvindas();
        }


    }
}
