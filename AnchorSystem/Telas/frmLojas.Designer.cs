
namespace AnchorSystem.Telas
{
    partial class frmLojas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLojas));
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblLojas = new System.Windows.Forms.Label();
            this.tdgRegistro = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCódigo = new System.Windows.Forms.TextBox();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbResponsavel = new System.Windows.Forms.ComboBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.ptbUploadProduto = new System.Windows.Forms.PictureBox();
            this.txtAddTelefone = new System.Windows.Forms.TextBox();
            this.txtAddEndereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddCnpj = new System.Windows.Forms.TextBox();
            this.txtAddNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlLojas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCadastrarLoja = new System.Windows.Forms.Button();
            this.btnLocalizarLoja = new System.Windows.Forms.Button();
            this.pnllocLoja = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlCadasLoja = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tdgRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUploadProduto)).BeginInit();
            this.pnlLojas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnllocLoja.SuspendLayout();
            this.pnlCadasLoja.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(1350, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 22);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblLojas
            // 
            this.lblLojas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLojas.AutoSize = true;
            this.lblLojas.BackColor = System.Drawing.Color.Transparent;
            this.lblLojas.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLojas.Location = new System.Drawing.Point(658, 9);
            this.lblLojas.Name = "lblLojas";
            this.lblLojas.Size = new System.Drawing.Size(83, 27);
            this.lblLojas.TabIndex = 4;
            this.lblLojas.Text = "Lojas ";
            // 
            // tdgRegistro
            // 
            this.tdgRegistro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tdgRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tdgRegistro.GridColor = System.Drawing.SystemColors.Control;
            this.tdgRegistro.Location = new System.Drawing.Point(3, 135);
            this.tdgRegistro.Name = "tdgRegistro";
            this.tdgRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tdgRegistro.Size = new System.Drawing.Size(493, 248);
            this.tdgRegistro.TabIndex = 7;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.Location = new System.Drawing.Point(613, 147);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 95);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.Location = new System.Drawing.Point(613, 254);
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
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.Location = new System.Drawing.Point(613, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 95);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCódigo
            // 
            this.txtBuscarCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCódigo.Location = new System.Drawing.Point(99, 58);
            this.txtBuscarCódigo.Name = "txtBuscarCódigo";
            this.txtBuscarCódigo.Size = new System.Drawing.Size(394, 29);
            this.txtBuscarCódigo.TabIndex = 3;
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNome.Location = new System.Drawing.Point(99, 17);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(394, 29);
            this.txtBuscarNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // txtAddCodigo
            // 
            this.txtAddCodigo.Enabled = false;
            this.txtAddCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCodigo.Location = new System.Drawing.Point(297, 70);
            this.txtAddCodigo.Name = "txtAddCodigo";
            this.txtAddCodigo.Size = new System.Drawing.Size(217, 29);
            this.txtAddCodigo.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Código:";
            // 
            // cbbResponsavel
            // 
            this.cbbResponsavel.Enabled = false;
            this.cbbResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbResponsavel.FormattingEnabled = true;
            this.cbbResponsavel.Location = new System.Drawing.Point(297, 218);
            this.cbbResponsavel.Name = "cbbResponsavel";
            this.cbbResponsavel.Size = new System.Drawing.Size(217, 32);
            this.cbbResponsavel.TabIndex = 29;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpload.Enabled = false;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(723, 79);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(94, 81);
            this.btnUpload.TabIndex = 28;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
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
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.Location = new System.Drawing.Point(923, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 95);
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
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.Location = new System.Drawing.Point(923, 114);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 95);
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
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.Location = new System.Drawing.Point(923, 7);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(116, 95);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "Novo";
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
            this.ptbUploadProduto.Location = new System.Drawing.Point(576, 35);
            this.ptbUploadProduto.Name = "ptbUploadProduto";
            this.ptbUploadProduto.Size = new System.Drawing.Size(132, 126);
            this.ptbUploadProduto.TabIndex = 22;
            this.ptbUploadProduto.TabStop = false;
            this.ptbUploadProduto.WaitOnLoad = true;
            // 
            // txtAddTelefone
            // 
            this.txtAddTelefone.Enabled = false;
            this.txtAddTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTelefone.Location = new System.Drawing.Point(297, 178);
            this.txtAddTelefone.Name = "txtAddTelefone";
            this.txtAddTelefone.Size = new System.Drawing.Size(217, 29);
            this.txtAddTelefone.TabIndex = 18;
            // 
            // txtAddEndereco
            // 
            this.txtAddEndereco.Enabled = false;
            this.txtAddEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddEndereco.Location = new System.Drawing.Point(297, 142);
            this.txtAddEndereco.Name = "txtAddEndereco";
            this.txtAddEndereco.Size = new System.Drawing.Size(217, 29);
            this.txtAddEndereco.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Funcionário Responsável:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefone:";
            // 
            // txtAddCnpj
            // 
            this.txtAddCnpj.Enabled = false;
            this.txtAddCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCnpj.Location = new System.Drawing.Point(297, 107);
            this.txtAddCnpj.Name = "txtAddCnpj";
            this.txtAddCnpj.Size = new System.Drawing.Size(217, 29);
            this.txtAddCnpj.TabIndex = 11;
            // 
            // txtAddNome
            // 
            this.txtAddNome.Enabled = false;
            this.txtAddNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNome.Location = new System.Drawing.Point(297, 29);
            this.txtAddNome.Name = "txtAddNome";
            this.txtAddNome.Size = new System.Drawing.Size(217, 29);
            this.txtAddNome.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "CNPJ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome:";
            // 
            // pnlLojas
            // 
            this.pnlLojas.BackColor = System.Drawing.Color.Transparent;
            this.pnlLojas.Controls.Add(this.lblLojas);
            this.pnlLojas.Controls.Add(this.btnFechar);
            this.pnlLojas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLojas.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.pnlLojas.ForeColor = System.Drawing.Color.Transparent;
            this.pnlLojas.Location = new System.Drawing.Point(0, 0);
            this.pnlLojas.Name = "pnlLojas";
            this.pnlLojas.Size = new System.Drawing.Size(1386, 40);
            this.pnlLojas.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnCadastrarLoja);
            this.panel2.Controls.Add(this.btnLocalizarLoja);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 60);
            this.panel2.TabIndex = 8;
            // 
            // btnCadastrarLoja
            // 
            this.btnCadastrarLoja.BackColor = System.Drawing.Color.Gray;
            this.btnCadastrarLoja.FlatAppearance.BorderSize = 0;
            this.btnCadastrarLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarLoja.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnCadastrarLoja.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarLoja.Location = new System.Drawing.Point(215, 7);
            this.btnCadastrarLoja.Name = "btnCadastrarLoja";
            this.btnCadastrarLoja.Size = new System.Drawing.Size(188, 45);
            this.btnCadastrarLoja.TabIndex = 3;
            this.btnCadastrarLoja.Text = "Cadastrar";
            this.btnCadastrarLoja.UseVisualStyleBackColor = false;
            this.btnCadastrarLoja.Click += new System.EventHandler(this.btnCadastrarLoja_Click);
            // 
            // btnLocalizarLoja
            // 
            this.btnLocalizarLoja.BackColor = System.Drawing.Color.Gray;
            this.btnLocalizarLoja.FlatAppearance.BorderSize = 0;
            this.btnLocalizarLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarLoja.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnLocalizarLoja.ForeColor = System.Drawing.Color.White;
            this.btnLocalizarLoja.Location = new System.Drawing.Point(12, 7);
            this.btnLocalizarLoja.Name = "btnLocalizarLoja";
            this.btnLocalizarLoja.Size = new System.Drawing.Size(188, 45);
            this.btnLocalizarLoja.TabIndex = 2;
            this.btnLocalizarLoja.Text = "Localizar";
            this.btnLocalizarLoja.UseVisualStyleBackColor = false;
            this.btnLocalizarLoja.Click += new System.EventHandler(this.btnLocalizarLoja_Click);
            // 
            // pnllocLoja
            // 
            this.pnllocLoja.BackColor = System.Drawing.Color.Transparent;
            this.pnllocLoja.Controls.Add(this.tdgRegistro);
            this.pnllocLoja.Controls.Add(this.textBox1);
            this.pnllocLoja.Controls.Add(this.btnExcluir);
            this.pnllocLoja.Controls.Add(this.label10);
            this.pnllocLoja.Controls.Add(this.btnBuscar);
            this.pnllocLoja.Controls.Add(this.btnEditar);
            this.pnllocLoja.Controls.Add(this.label2);
            this.pnllocLoja.Controls.Add(this.txtBuscarNome);
            this.pnllocLoja.Controls.Add(this.txtBuscarCódigo);
            this.pnllocLoja.Controls.Add(this.label3);
            this.pnllocLoja.Location = new System.Drawing.Point(12, 106);
            this.pnllocLoja.Name = "pnllocLoja";
            this.pnllocLoja.Size = new System.Drawing.Size(745, 386);
            this.pnllocLoja.TabIndex = 9;
            this.pnllocLoja.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(99, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 29);
            this.textBox1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(7, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "CNPJ:";
            // 
            // pnlCadasLoja
            // 
            this.pnlCadasLoja.BackColor = System.Drawing.Color.Transparent;
            this.pnlCadasLoja.Controls.Add(this.btnUpload);
            this.pnlCadasLoja.Controls.Add(this.btnCancelar);
            this.pnlCadasLoja.Controls.Add(this.cbbResponsavel);
            this.pnlCadasLoja.Controls.Add(this.txtAddCodigo);
            this.pnlCadasLoja.Controls.Add(this.btnSalvar);
            this.pnlCadasLoja.Controls.Add(this.ptbUploadProduto);
            this.pnlCadasLoja.Controls.Add(this.btnNovo);
            this.pnlCadasLoja.Controls.Add(this.label7);
            this.pnlCadasLoja.Controls.Add(this.label8);
            this.pnlCadasLoja.Controls.Add(this.label5);
            this.pnlCadasLoja.Controls.Add(this.label4);
            this.pnlCadasLoja.Controls.Add(this.label6);
            this.pnlCadasLoja.Controls.Add(this.txtAddTelefone);
            this.pnlCadasLoja.Controls.Add(this.label9);
            this.pnlCadasLoja.Controls.Add(this.txtAddEndereco);
            this.pnlCadasLoja.Controls.Add(this.txtAddNome);
            this.pnlCadasLoja.Controls.Add(this.txtAddCnpj);
            this.pnlCadasLoja.Location = new System.Drawing.Point(763, 123);
            this.pnlCadasLoja.Name = "pnlCadasLoja";
            this.pnlCadasLoja.Size = new System.Drawing.Size(1084, 350);
            this.pnlCadasLoja.TabIndex = 10;
            this.pnlCadasLoja.Visible = false;
            // 
            // frmLojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1386, 504);
            this.Controls.Add(this.pnlCadasLoja);
            this.Controls.Add(this.pnllocLoja);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlLojas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLojas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLojas";
            this.Load += new System.EventHandler(this.frmLojas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tdgRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUploadProduto)).EndInit();
            this.pnlLojas.ResumeLayout(false);
            this.pnlLojas.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnllocLoja.ResumeLayout(false);
            this.pnllocLoja.PerformLayout();
            this.pnlCadasLoja.ResumeLayout(false);
            this.pnlCadasLoja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblLojas;
        private System.Windows.Forms.DataGridView tdgRegistro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCódigo;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.PictureBox ptbUploadProduto;
        private System.Windows.Forms.TextBox txtAddTelefone;
        private System.Windows.Forms.TextBox txtAddEndereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddCnpj;
        private System.Windows.Forms.TextBox txtAddNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbResponsavel;
        private System.Windows.Forms.TextBox txtAddCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlLojas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCadastrarLoja;
        private System.Windows.Forms.Button btnLocalizarLoja;
        private System.Windows.Forms.Panel pnllocLoja;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlCadasLoja;
    }
}