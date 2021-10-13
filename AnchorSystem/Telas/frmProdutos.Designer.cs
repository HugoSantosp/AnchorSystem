
namespace AnchorSystem.Telas
{
    partial class frmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCódigo = new System.Windows.Forms.TextBox();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbAddLoja = new System.Windows.Forms.ComboBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.ptbUploadProduto = new System.Windows.Forms.PictureBox();
            this.cbbAddFornecedor = new System.Windows.Forms.ComboBox();
            this.cbbAddCategoria = new System.Windows.Forms.ComboBox();
            this.txtAddQuantidade = new System.Windows.Forms.TextBox();
            this.txtAddPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtAddPrecoCusto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddCodigo = new System.Windows.Forms.TextBox();
            this.txtAddNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlProdutos = new System.Windows.Forms.Panel();
            this.pnlControleProdutos = new System.Windows.Forms.Panel();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnLocalizarProdutos = new System.Windows.Forms.Button();
            this.pnllocprod = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCadastroProd = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUploadProduto)).BeginInit();
            this.pnlProdutos.SuspendLayout();
            this.pnlControleProdutos.SuspendLayout();
            this.pnllocprod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlCadastroProd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.Location = new System.Drawing.Point(57, 140);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 95);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.Location = new System.Drawing.Point(57, 246);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 95);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.Location = new System.Drawing.Point(57, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 95);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCódigo
            // 
            this.txtBuscarCódigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCódigo.Location = new System.Drawing.Point(111, 64);
            this.txtBuscarCódigo.Name = "txtBuscarCódigo";
            this.txtBuscarCódigo.Size = new System.Drawing.Size(216, 29);
            this.txtBuscarCódigo.TabIndex = 2;
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNome.Location = new System.Drawing.Point(111, 32);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(216, 29);
            this.txtBuscarNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // cbbAddLoja
            // 
            this.cbbAddLoja.Enabled = false;
            this.cbbAddLoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAddLoja.FormattingEnabled = true;
            this.cbbAddLoja.Location = new System.Drawing.Point(635, 236);
            this.cbbAddLoja.Name = "cbbAddLoja";
            this.cbbAddLoja.Size = new System.Drawing.Size(221, 32);
            this.cbbAddLoja.TabIndex = 8;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpload.Enabled = false;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(654, 98);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(94, 81);
            this.btnUpload.TabIndex = 28;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label11.Location = new System.Drawing.Point(517, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 22);
            this.label11.TabIndex = 26;
            this.label11.Text = "Loja:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.Location = new System.Drawing.Point(64, 217);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 81);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(64, 115);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 96);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.Location = new System.Drawing.Point(64, 22);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(88, 87);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "Adicionar";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // ptbUploadProduto
            // 
            this.ptbUploadProduto.BackColor = System.Drawing.Color.Transparent;
            this.ptbUploadProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbUploadProduto.BackgroundImage")));
            this.ptbUploadProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbUploadProduto.Location = new System.Drawing.Point(507, 53);
            this.ptbUploadProduto.Name = "ptbUploadProduto";
            this.ptbUploadProduto.Size = new System.Drawing.Size(132, 126);
            this.ptbUploadProduto.TabIndex = 22;
            this.ptbUploadProduto.TabStop = false;
            this.ptbUploadProduto.WaitOnLoad = true;
            // 
            // cbbAddFornecedor
            // 
            this.cbbAddFornecedor.Enabled = false;
            this.cbbAddFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAddFornecedor.FormattingEnabled = true;
            this.cbbAddFornecedor.Location = new System.Drawing.Point(193, 285);
            this.cbbAddFornecedor.Name = "cbbAddFornecedor";
            this.cbbAddFornecedor.Size = new System.Drawing.Size(185, 32);
            this.cbbAddFornecedor.TabIndex = 6;
            // 
            // cbbAddCategoria
            // 
            this.cbbAddCategoria.Enabled = false;
            this.cbbAddCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAddCategoria.FormattingEnabled = true;
            this.cbbAddCategoria.Location = new System.Drawing.Point(193, 147);
            this.cbbAddCategoria.Name = "cbbAddCategoria";
            this.cbbAddCategoria.Size = new System.Drawing.Size(217, 32);
            this.cbbAddCategoria.TabIndex = 3;
            // 
            // txtAddQuantidade
            // 
            this.txtAddQuantidade.Enabled = false;
            this.txtAddQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQuantidade.Location = new System.Drawing.Point(635, 200);
            this.txtAddQuantidade.Name = "txtAddQuantidade";
            this.txtAddQuantidade.Size = new System.Drawing.Size(123, 29);
            this.txtAddQuantidade.TabIndex = 7;
            // 
            // txtAddPrecoVenda
            // 
            this.txtAddPrecoVenda.Enabled = false;
            this.txtAddPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPrecoVenda.Location = new System.Drawing.Point(193, 239);
            this.txtAddPrecoVenda.Name = "txtAddPrecoVenda";
            this.txtAddPrecoVenda.Size = new System.Drawing.Size(123, 29);
            this.txtAddPrecoVenda.TabIndex = 5;
            // 
            // txtAddPrecoCusto
            // 
            this.txtAddPrecoCusto.Enabled = false;
            this.txtAddPrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPrecoCusto.Location = new System.Drawing.Point(193, 194);
            this.txtAddPrecoCusto.Name = "txtAddPrecoCusto";
            this.txtAddPrecoCusto.Size = new System.Drawing.Size(123, 29);
            this.txtAddPrecoCusto.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label10.Location = new System.Drawing.Point(517, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Quantidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label9.Location = new System.Drawing.Point(3, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Categoria:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label8.Location = new System.Drawing.Point(3, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fornecedor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label7.Location = new System.Drawing.Point(3, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Preço de Venda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Preço de Custo:";
            // 
            // txtAddCodigo
            // 
            this.txtAddCodigo.Enabled = false;
            this.txtAddCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCodigo.Location = new System.Drawing.Point(193, 64);
            this.txtAddCodigo.Name = "txtAddCodigo";
            this.txtAddCodigo.Size = new System.Drawing.Size(217, 29);
            this.txtAddCodigo.TabIndex = 1;
            // 
            // txtAddNome
            // 
            this.txtAddNome.Enabled = false;
            this.txtAddNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNome.Location = new System.Drawing.Point(193, 103);
            this.txtAddNome.Name = "txtAddNome";
            this.txtAddNome.Size = new System.Drawing.Size(217, 29);
            this.txtAddNome.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label4.Location = new System.Drawing.Point(4, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label5.Location = new System.Drawing.Point(4, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome:";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblProdutos.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.lblProdutos.Location = new System.Drawing.Point(693, 5);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(119, 29);
            this.lblProdutos.TabIndex = 1;
            this.lblProdutos.Text = "Produtos";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(1353, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 22);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnlProdutos
            // 
            this.pnlProdutos.BackColor = System.Drawing.Color.Transparent;
            this.pnlProdutos.Controls.Add(this.lblProdutos);
            this.pnlProdutos.Controls.Add(this.btnFechar);
            this.pnlProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProdutos.Location = new System.Drawing.Point(0, 0);
            this.pnlProdutos.Name = "pnlProdutos";
            this.pnlProdutos.Size = new System.Drawing.Size(1386, 40);
            this.pnlProdutos.TabIndex = 3;
            // 
            // pnlControleProdutos
            // 
            this.pnlControleProdutos.BackColor = System.Drawing.Color.Transparent;
            this.pnlControleProdutos.Controls.Add(this.btnCadastrarProduto);
            this.pnlControleProdutos.Controls.Add(this.btnLocalizarProdutos);
            this.pnlControleProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControleProdutos.Location = new System.Drawing.Point(0, 40);
            this.pnlControleProdutos.Name = "pnlControleProdutos";
            this.pnlControleProdutos.Size = new System.Drawing.Size(1386, 58);
            this.pnlControleProdutos.TabIndex = 26;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.DimGray;
            this.btnCadastrarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarProduto.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnCadastrarProduto.Location = new System.Drawing.Point(226, 6);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(188, 45);
            this.btnCadastrarProduto.TabIndex = 1;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnLocalizarProdutos
            // 
            this.btnLocalizarProdutos.BackColor = System.Drawing.Color.DimGray;
            this.btnLocalizarProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalizarProdutos.FlatAppearance.BorderSize = 0;
            this.btnLocalizarProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLocalizarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarProdutos.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnLocalizarProdutos.Location = new System.Drawing.Point(14, 6);
            this.btnLocalizarProdutos.Name = "btnLocalizarProdutos";
            this.btnLocalizarProdutos.Size = new System.Drawing.Size(188, 45);
            this.btnLocalizarProdutos.TabIndex = 0;
            this.btnLocalizarProdutos.Text = "Localizar ";
            this.btnLocalizarProdutos.UseVisualStyleBackColor = false;
            this.btnLocalizarProdutos.Click += new System.EventHandler(this.btnLocalizarProdutos_Click);
            // 
            // pnllocprod
            // 
            this.pnllocprod.Controls.Add(this.label13);
            this.pnllocprod.Controls.Add(this.label12);
            this.pnllocprod.Controls.Add(this.dataGridView1);
            this.pnllocprod.Controls.Add(this.panel1);
            this.pnllocprod.Controls.Add(this.txtBuscarNome);
            this.pnllocprod.Controls.Add(this.txtBuscarCódigo);
            this.pnllocprod.Controls.Add(this.label2);
            this.pnllocprod.Controls.Add(this.label3);
            this.pnllocprod.Location = new System.Drawing.Point(0, 123);
            this.pnllocprod.Name = "pnllocprod";
            this.pnllocprod.Size = new System.Drawing.Size(558, 366);
            this.pnllocprod.TabIndex = 27;
            this.pnllocprod.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(119, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 22);
            this.label13.TabIndex = 11;
            this.label13.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 22);
            this.label12.TabIndex = 10;
            this.label12.Text = "Registros:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(333, 226);
            this.dataGridView1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(333, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 366);
            this.panel1.TabIndex = 8;
            // 
            // pnlCadastroProd
            // 
            this.pnlCadastroProd.Controls.Add(this.panel2);
            this.pnlCadastroProd.Controls.Add(this.btnUpload);
            this.pnlCadastroProd.Controls.Add(this.label11);
            this.pnlCadastroProd.Controls.Add(this.cbbAddLoja);
            this.pnlCadastroProd.Controls.Add(this.txtAddCodigo);
            this.pnlCadastroProd.Controls.Add(this.txtAddNome);
            this.pnlCadastroProd.Controls.Add(this.ptbUploadProduto);
            this.pnlCadastroProd.Controls.Add(this.label4);
            this.pnlCadastroProd.Controls.Add(this.cbbAddFornecedor);
            this.pnlCadastroProd.Controls.Add(this.label5);
            this.pnlCadastroProd.Controls.Add(this.cbbAddCategoria);
            this.pnlCadastroProd.Controls.Add(this.label6);
            this.pnlCadastroProd.Controls.Add(this.txtAddQuantidade);
            this.pnlCadastroProd.Controls.Add(this.label7);
            this.pnlCadastroProd.Controls.Add(this.txtAddPrecoVenda);
            this.pnlCadastroProd.Controls.Add(this.label8);
            this.pnlCadastroProd.Controls.Add(this.txtAddPrecoCusto);
            this.pnlCadastroProd.Controls.Add(this.label9);
            this.pnlCadastroProd.Controls.Add(this.label10);
            this.pnlCadastroProd.Location = new System.Drawing.Point(564, 123);
            this.pnlCadastroProd.Name = "pnlCadastroProd";
            this.pnlCadastroProd.Size = new System.Drawing.Size(675, 366);
            this.pnlCadastroProd.TabIndex = 29;
            this.pnlCadastroProd.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(475, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 366);
            this.panel2.TabIndex = 29;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1386, 778);
            this.Controls.Add(this.pnlCadastroProd);
            this.Controls.Add(this.pnllocprod);
            this.Controls.Add(this.pnlControleProdutos);
            this.Controls.Add(this.pnlProdutos);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbUploadProduto)).EndInit();
            this.pnlProdutos.ResumeLayout(false);
            this.pnlProdutos.PerformLayout();
            this.pnlControleProdutos.ResumeLayout(false);
            this.pnllocprod.ResumeLayout(false);
            this.pnllocprod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlCadastroProd.ResumeLayout(false);
            this.pnlCadastroProd.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCódigo;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.PictureBox ptbUploadProduto;
        private System.Windows.Forms.ComboBox cbbAddFornecedor;
        private System.Windows.Forms.ComboBox cbbAddCategoria;
        private System.Windows.Forms.TextBox txtAddQuantidade;
        private System.Windows.Forms.TextBox txtAddPrecoVenda;
        private System.Windows.Forms.TextBox txtAddPrecoCusto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddCodigo;
        private System.Windows.Forms.TextBox txtAddNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbAddLoja;
        private System.Windows.Forms.Panel pnlProdutos;
        private System.Windows.Forms.Panel pnlControleProdutos;
        private System.Windows.Forms.Button btnLocalizarProdutos;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Panel pnllocprod;
        private System.Windows.Forms.Panel pnlCadastroProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}