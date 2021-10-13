using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AnchorSystem
{
    public partial class frmTelaLoguin : Form
    {
        public frmTelaLoguin()
        {
            InitializeComponent();
            pnlLoguin.Visible = false;
            
        }

        private void frmTelaLoguin_Load(object sender, EventArgs e)
        {
            pnlLoguin.Location = new Point((this.Width / 2) - (pnlLoguin.Size.Width /2), (this.Height /2)- (pnlLoguin.Size.Height / 2) );
            pnlLoguin.Visible = true;
            txtUsuario.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            ConfirmaLoguin();
        }


        // Evento para Precionar a Tecla Enter para Logar
        private void frmTelaLoguin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ConfirmaLoguin();
              
            }
        }

        // ERRO DE LOGUIN DE USUÁRIO OU SENHA
        private void ErroLoguin()
        {
            if (txtUsuario.Text == "" )
            {
                MessageBox.Show("Preencha o campo Usuário Corretamente");
                txtUsuario.Focus();
                return;
            }
            if (txtSenha.Text == "" )
            {
                MessageBox.Show("Preencha o campo Senha Corretamente");
                txtSenha.Focus();
                return;
            }

            if (txtSenha.Text != "admin" )
            {
                MessageBox.Show("As credencias não estão corretas. Tente Novamente");
                LimparCampos();
                txtUsuario.Focus();
                return;
            }
            if (txtUsuario.Text != "Admin")
            {
                MessageBox.Show("As credencias não estão corretas. Tente Novamente");
                LimparCampos();
                txtUsuario.Focus();
                return;
            }

        }

     
        // CÓDIGO PARA CONFIRMAR SE O LOGUIN CORRETO É USUÁRIO: Admin E SENHA: admin
        private void ConfirmaLoguin()
        {
         

            if (txtUsuario.Text == "Admin" && txtSenha.Text == "admin")
            {
                Telas.frmMenuPrincipal form = new Telas.frmMenuPrincipal();
                LimparCampos();
                form.Show();
            }else
            {
                ErroLoguin();
            }
        }

        //LIMPAR CAMPOS
        private void LimparCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }

       
    }
}
