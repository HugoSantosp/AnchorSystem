
namespace AnchorSystem.Telas
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbBuscarLoja = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tdgRegistro = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCódigo = new System.Windows.Forms.TextBox();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddCPF = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbAddFuncao = new System.Windows.Forms.ComboBox();
            this.cbbAddSexo = new System.Windows.Forms.ComboBox();
            this.txtAddEndereco = new System.Windows.Forms.TextBox();
            this.cbbAddVinculo = new System.Windows.Forms.ComboBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.ptbUploadProduto = new System.Windows.Forms.PictureBox();
            this.cbbAddEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtAddTelefone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddCodigo = new System.Windows.Forms.TextBox();
            this.txtAddNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnLocalizarFuncionario = new System.Windows.Forms.Button();
            this.pnlLocFuncionario = new System.Windows.Forms.Panel();
            this.pnlCdastrarFunc = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tdgRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUploadProduto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLocFuncionario.SuspendLayout();
            this.pnlCdastrarFunc.SuspendLayout();
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
            this.btnFechar.Location = new System.Drawing.Point(1353, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 22);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Funcionários";
            // 
            // cbbBuscarLoja
            // 
            this.cbbBuscarLoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBuscarLoja.FormattingEnabled = true;
            this.cbbBuscarLoja.Location = new System.Drawing.Point(99, 98);
            this.cbbBuscarLoja.Name = "cbbBuscarLoja";
            this.cbbBuscarLoja.Size = new System.Drawing.Size(315, 32);
            this.cbbBuscarLoja.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 22);
            this.label12.TabIndex = 8;
            this.label12.Text = "Vínculo:";
            // 
            // tdgRegistro
            // 
            this.tdgRegistro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tdgRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tdgRegistro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tdgRegistro.GridColor = System.Drawing.SystemColors.Control;
            this.tdgRegistro.Location = new System.Drawing.Point(0, 148);
            this.tdgRegistro.Name = "tdgRegistro";
            this.tdgRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tdgRegistro.Size = new System.Drawing.Size(424, 195);
            this.tdgRegistro.TabIndex = 7;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(515, 41);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(65, 65);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(586, 41);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 65);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(444, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 65);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCódigo
            // 
            this.txtBuscarCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCódigo.Location = new System.Drawing.Point(99, 12);
            this.txtBuscarCódigo.Name = "txtBuscarCódigo";
            this.txtBuscarCódigo.Size = new System.Drawing.Size(315, 29);
            this.txtBuscarCódigo.TabIndex = 3;
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNome.Location = new System.Drawing.Point(99, 56);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(315, 29);
            this.txtBuscarNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // txtAddCPF
            // 
            this.txtAddCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCPF.Location = new System.Drawing.Point(131, 101);
            this.txtAddCPF.Name = "txtAddCPF";
            this.txtAddCPF.Size = new System.Drawing.Size(319, 29);
            this.txtAddCPF.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(10, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 22);
            this.label13.TabIndex = 33;
            this.label13.Text = "CPF:";
            // 
            // cbbAddFuncao
            // 
            this.cbbAddFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAddFuncao.FormattingEnabled = true;
            this.cbbAddFuncao.Items.AddRange(new object[] {
            "CLT",
            "Contrato",
            "Estágiario",
            "Tercerizado"});
            this.cbbAddFuncao.Location = new System.Drawing.Point(579, 224);
            this.cbbAddFuncao.Name = "cbbAddFuncao";
            this.cbbAddFuncao.Size = new System.Drawing.Size(221, 32);
            this.cbbAddFuncao.TabIndex = 32;
            // 
            // cbbAddSexo
            // 
            this.cbbAddSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAddSexo.FormattingEnabled = true;
            this.cbbAddSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.cbbAddSexo.Location = new System.Drawing.Point(131, 229);
            this.cbbAddSexo.Name = "cbbAddSexo";
            this.cbbAddSexo.Size = new System.Drawing.Size(318, 32);
            this.cbbAddSexo.TabIndex = 31;
            // 
            // txtAddEndereco
            // 
            this.txtAddEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddEndereco.Location = new System.Drawing.Point(131, 144);
            this.txtAddEndereco.Name = "txtAddEndereco";
            this.txtAddEndereco.Size = new System.Drawing.Size(318, 29);
            this.txtAddEndereco.TabIndex = 30;
            // 
            // cbbAddVinculo
            // 
            this.cbbAddVinculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAddVinculo.FormattingEnabled = true;
            this.cbbAddVinculo.Items.AddRange(new object[] {
            "CLT",
            "Contrato",
            "Estágiario",
            "Tercerizado"});
            this.cbbAddVinculo.Location = new System.Drawing.Point(579, 275);
            this.cbbAddVinculo.Name = "cbbAddVinculo";
            this.cbbAddVinculo.Size = new System.Drawing.Size(221, 32);
            this.cbbAddVinculo.TabIndex = 29;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(634, 92);
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
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(482, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 22);
            this.label11.TabIndex = 26;
            this.label11.Text = "Vínculo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(870, 224);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 65);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(870, 144);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 65);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(870, 56);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(65, 65);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // ptbUploadProduto
            // 
            this.ptbUploadProduto.BackColor = System.Drawing.Color.Transparent;
            this.ptbUploadProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbUploadProduto.BackgroundImage")));
            this.ptbUploadProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbUploadProduto.Location = new System.Drawing.Point(486, 47);
            this.ptbUploadProduto.Name = "ptbUploadProduto";
            this.ptbUploadProduto.Size = new System.Drawing.Size(132, 126);
            this.ptbUploadProduto.TabIndex = 22;
            this.ptbUploadProduto.TabStop = false;
            this.ptbUploadProduto.WaitOnLoad = true;
            // 
            // cbbAddEstadoCivil
            // 
            this.cbbAddEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAddEstadoCivil.FormattingEnabled = true;
            this.cbbAddEstadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Divorsiado",
            "Viúvo"});
            this.cbbAddEstadoCivil.Location = new System.Drawing.Point(131, 276);
            this.cbbAddEstadoCivil.Name = "cbbAddEstadoCivil";
            this.cbbAddEstadoCivil.Size = new System.Drawing.Size(319, 32);
            this.cbbAddEstadoCivil.TabIndex = 21;
            // 
            // txtAddTelefone
            // 
            this.txtAddTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTelefone.Location = new System.Drawing.Point(131, 187);
            this.txtAddTelefone.Name = "txtAddTelefone";
            this.txtAddTelefone.Size = new System.Drawing.Size(319, 29);
            this.txtAddTelefone.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(482, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Função:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estado Civíl:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefone:";
            // 
            // txtAddCodigo
            // 
            this.txtAddCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCodigo.Location = new System.Drawing.Point(131, 16);
            this.txtAddCodigo.Name = "txtAddCodigo";
            this.txtAddCodigo.Size = new System.Drawing.Size(318, 29);
            this.txtAddCodigo.TabIndex = 11;
            // 
            // txtAddNome
            // 
            this.txtAddNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNome.Location = new System.Drawing.Point(131, 58);
            this.txtAddNome.Name = "txtAddNome";
            this.txtAddNome.Size = new System.Drawing.Size(316, 29);
            this.txtAddNome.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 40);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCadastrarFuncionario);
            this.panel2.Controls.Add(this.btnLocalizarFuncionario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 85);
            this.panel2.TabIndex = 10;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.Gray;
            this.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(215, 5);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(188, 73);
            this.btnCadastrarFuncionario.TabIndex = 1;
            this.btnCadastrarFuncionario.Text = "Cadastrar";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // btnLocalizarFuncionario
            // 
            this.btnLocalizarFuncionario.BackColor = System.Drawing.Color.Gray;
            this.btnLocalizarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnLocalizarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarFuncionario.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnLocalizarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnLocalizarFuncionario.Location = new System.Drawing.Point(12, 5);
            this.btnLocalizarFuncionario.Name = "btnLocalizarFuncionario";
            this.btnLocalizarFuncionario.Size = new System.Drawing.Size(188, 73);
            this.btnLocalizarFuncionario.TabIndex = 0;
            this.btnLocalizarFuncionario.Text = "Localizar";
            this.btnLocalizarFuncionario.UseVisualStyleBackColor = false;
            this.btnLocalizarFuncionario.Click += new System.EventHandler(this.btnLocalizarFuncionario_Click);
            // 
            // pnlLocFuncionario
            // 
            this.pnlLocFuncionario.Controls.Add(this.tdgRegistro);
            this.pnlLocFuncionario.Controls.Add(this.label2);
            this.pnlLocFuncionario.Controls.Add(this.cbbBuscarLoja);
            this.pnlLocFuncionario.Controls.Add(this.txtBuscarCódigo);
            this.pnlLocFuncionario.Controls.Add(this.btnBuscar);
            this.pnlLocFuncionario.Controls.Add(this.btnExcluir);
            this.pnlLocFuncionario.Controls.Add(this.btnEditar);
            this.pnlLocFuncionario.Controls.Add(this.label12);
            this.pnlLocFuncionario.Controls.Add(this.label3);
            this.pnlLocFuncionario.Controls.Add(this.txtBuscarNome);
            this.pnlLocFuncionario.Location = new System.Drawing.Point(12, 140);
            this.pnlLocFuncionario.Name = "pnlLocFuncionario";
            this.pnlLocFuncionario.Size = new System.Drawing.Size(424, 343);
            this.pnlLocFuncionario.TabIndex = 11;
            // 
            // pnlCdastrarFunc
            // 
            this.pnlCdastrarFunc.Controls.Add(this.btnNovo);
            this.pnlCdastrarFunc.Controls.Add(this.cbbAddVinculo);
            this.pnlCdastrarFunc.Controls.Add(this.btnSalvar);
            this.pnlCdastrarFunc.Controls.Add(this.label11);
            this.pnlCdastrarFunc.Controls.Add(this.txtAddCPF);
            this.pnlCdastrarFunc.Controls.Add(this.btnUpload);
            this.pnlCdastrarFunc.Controls.Add(this.btnCancelar);
            this.pnlCdastrarFunc.Controls.Add(this.cbbAddFuncao);
            this.pnlCdastrarFunc.Controls.Add(this.label10);
            this.pnlCdastrarFunc.Controls.Add(this.cbbAddSexo);
            this.pnlCdastrarFunc.Controls.Add(this.ptbUploadProduto);
            this.pnlCdastrarFunc.Controls.Add(this.label4);
            this.pnlCdastrarFunc.Controls.Add(this.txtAddEndereco);
            this.pnlCdastrarFunc.Controls.Add(this.label13);
            this.pnlCdastrarFunc.Controls.Add(this.label5);
            this.pnlCdastrarFunc.Controls.Add(this.label6);
            this.pnlCdastrarFunc.Controls.Add(this.cbbAddEstadoCivil);
            this.pnlCdastrarFunc.Controls.Add(this.label7);
            this.pnlCdastrarFunc.Controls.Add(this.label8);
            this.pnlCdastrarFunc.Controls.Add(this.label9);
            this.pnlCdastrarFunc.Controls.Add(this.txtAddCodigo);
            this.pnlCdastrarFunc.Controls.Add(this.txtAddTelefone);
            this.pnlCdastrarFunc.Controls.Add(this.txtAddNome);
            this.pnlCdastrarFunc.Location = new System.Drawing.Point(442, 140);
            this.pnlCdastrarFunc.Name = "pnlCdastrarFunc";
            this.pnlCdastrarFunc.Size = new System.Drawing.Size(957, 343);
            this.pnlCdastrarFunc.TabIndex = 12;
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1386, 526);
            this.Controls.Add(this.pnlCdastrarFunc);
            this.Controls.Add(this.pnlLocFuncionario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.tdgRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUploadProduto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlLocFuncionario.ResumeLayout(false);
            this.pnlLocFuncionario.PerformLayout();
            this.pnlCdastrarFunc.ResumeLayout(false);
            this.pnlCdastrarFunc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tdgRegistro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCódigo;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbAddVinculo;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.PictureBox ptbUploadProduto;
        private System.Windows.Forms.ComboBox cbbAddEstadoCivil;
        private System.Windows.Forms.TextBox txtAddTelefone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddCodigo;
        private System.Windows.Forms.TextBox txtAddNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbBuscarLoja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbAddSexo;
        private System.Windows.Forms.TextBox txtAddEndereco;
        private System.Windows.Forms.ComboBox cbbAddFuncao;
        private System.Windows.Forms.TextBox txtAddCPF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnLocalizarFuncionario;
        private System.Windows.Forms.Panel pnlLocFuncionario;
        private System.Windows.Forms.Panel pnlCdastrarFunc;
    }
}