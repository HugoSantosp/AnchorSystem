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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
            
          
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            Desabilitar();

        }

        // MÉTODO PARA LIMPAR OS CAMPOS
        private void Limpar()
        {
            txtAddCodigo.Text = "";
            txtAddNome.Text = "";
            txtAddPrecoCusto.Text = "";
            txtAddPrecoVenda.Text = "";
            txtAddQuantidade.Text = "";
            cbbAddCategoria.Text = "";
            cbbAddFornecedor.Text = "";
            cbbAddLoja.Text = "";
        }

        //MÉTODO PARA HABILITAR CAMPOS E BOTÕES
        private void Habilitar()
        {
            txtAddCodigo.Enabled = true;
            txtAddNome.Enabled = true;
            txtAddPrecoCusto.Enabled = true;
            txtAddPrecoCusto.Enabled = true;
            txtAddPrecoVenda.Enabled = true;
            txtAddQuantidade.Enabled = true;
            cbbAddCategoria.Enabled = true;
            cbbAddFornecedor.Enabled = true;
            cbbAddLoja.Enabled = true;

            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnUpload.Enabled = true;
        }

        //MÉTODO PARA DESABILITAR CAMPOS E BOTÕES
        private void Desabilitar()
        {
            txtAddCodigo.Enabled = false;
            txtAddNome.Enabled = false;
            txtAddPrecoCusto.Enabled = false;
            txtAddPrecoCusto.Enabled = false;
            txtAddPrecoVenda.Enabled = false;
            txtAddQuantidade.Enabled = false;
            cbbAddCategoria.Enabled = false;
            cbbAddFornecedor.Enabled = false;
            cbbAddLoja.Enabled = false;

            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnUpload.Enabled = false;
        }

        //MÉTODO DE VERIFICAÇÃO DOS CAMPOS AO SALVAR
      
        /*
        private void VerificarCampos()
        {
            
           
            if (txtAddNome.Text == "")
            {
                MessageBox.Show("Preencha o campo (Nome)");
                txtAddNome.Focus();
                return;
            }
            if (txtAddPrecoCusto.Text == "")
            {
                MessageBox.Show("Preencha o campo (Preço de Custo)");
                txtAddPrecoCusto.Focus();
                return;
            }
            if (txtAddPrecoVenda.Text == "")
            {
                MessageBox.Show("Preencha o (Preço de Venda)");
                txtAddPrecoVenda.Focus();
                return;
            }
            if (txtAddQuantidade.Text == "")
            {
                MessageBox.Show("Preencha a Quantidade para o Estoque");
                txtAddQuantidade.Focus();
                return;
            }
            if(cbbAddCategoria.Text == "")
            {
                MessageBox.Show("Localize a Categoria do Produto");
                cbbAddCategoria.Focus();
                return;
            }
            if (cbbAddFornecedor.Text == "")
            {
                MessageBox.Show("Localize o Fonecedor do Produto");
                cbbAddFornecedor.Focus();
                return;
            }
            if (cbbAddLoja.Text == "")
            {
                MessageBox.Show("Localize a Loja à ser trabalhada");
                cbbAddLoja.Focus();
                return;
            }

        }
        */
        private void frmProdutos_Load(object sender, EventArgs e)
        {
            
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            Habilitar();
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtAddNome.Text == "")
            {
                MessageBox.Show("Preencha o campo (Nome)");
                txtAddNome.Focus();
                return;
            }
            if (txtAddPrecoCusto.Text == "")
            {
                MessageBox.Show("Preencha o campo (Preço de Custo)");
                txtAddPrecoCusto.Focus();
                return;
            }
            if (txtAddPrecoVenda.Text == "")
            {
                MessageBox.Show("Preencha o (Preço de Venda)");
                txtAddPrecoVenda.Focus();
                return;
            }
            if (txtAddQuantidade.Text == "")
            {
                MessageBox.Show("Preencha a Quantidade para o Estoque");
                txtAddQuantidade.Focus();
                return;
            }
            if (cbbAddCategoria.Text == "")
            {
                MessageBox.Show("Localize a Categoria do Produto");
                cbbAddCategoria.Focus();
                return;
            }
            if (cbbAddFornecedor.Text == "")
            {
                MessageBox.Show("Localize o Fonecedor do Produto");
                cbbAddFornecedor.Focus();
                return;
            }
            if (cbbAddLoja.Text == "")
            {
                MessageBox.Show("Localize a Loja à ser trabalhada");
                cbbAddLoja.Focus();
                return;
            }else
            {
                Desabilitar();
                MessageBox.Show("Dados Produtos Salvos Com sucesso");
                Limpar();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }



        //CUSTOMIZAÇÃO DOS PAINEIS LOCALIZAR E CADASTRAR
        
        private void CustomPanel()
        {
            pnllocprod.Visible = false;
            pnlCadastroProd.Visible = false;
        }
        private void ocultarPainel()
        {
            if (pnllocprod.Visible == true) pnllocprod.Visible = false;
            if (pnlCadastroProd.Visible == true) pnlCadastroProd.Visible = false;
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
        private void btnLocalizarProdutos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnllocprod);
            
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlCadastroProd);
           
        }
    }
}
