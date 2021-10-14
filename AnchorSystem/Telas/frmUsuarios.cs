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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            
        }
        //MÉTODO DE CARREGAMENTO DO FORMULARIO

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

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

      
    }
}
