
namespace AnchorSystem.Telas
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddDescricao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddCodigo = new System.Windows.Forms.TextBox();
            this.txtAddNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlControleProdutos = new System.Windows.Forms.Panel();
            this.btnCadastrarCategoria = new System.Windows.Forms.Button();
            this.btnLocalizarCategoria = new System.Windows.Forms.Button();
            this.pnlLocCategoria1 = new System.Windows.Forms.Panel();
            this.pnlCadastroCategoria = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlControleProdutos.SuspendLayout();
            this.pnlLocCategoria1.SuspendLayout();
            this.pnlCadastroCategoria.SuspendLayout();
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
            this.btnFechar.Location = new System.Drawing.Point(1107, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 22);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(445, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categorias de Produtos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(554, 271);
            this.dataGridView1.TabIndex = 7;
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
            this.btnEditar.Location = new System.Drawing.Point(381, 19);
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
            this.btnExcluir.Location = new System.Drawing.Point(464, 19);
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
            this.btnBuscar.Location = new System.Drawing.Point(310, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 65);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCodigo.Location = new System.Drawing.Point(100, 55);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(184, 29);
            this.txtBuscarCodigo.TabIndex = 3;
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNome.Location = new System.Drawing.Point(100, 19);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(184, 29);
            this.txtBuscarNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // txtAddDescricao
            // 
            this.txtAddDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddDescricao.Location = new System.Drawing.Point(113, 78);
            this.txtAddDescricao.Multiline = true;
            this.txtAddDescricao.Name = "txtAddDescricao";
            this.txtAddDescricao.Size = new System.Drawing.Size(355, 111);
            this.txtAddDescricao.TabIndex = 26;
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
            this.btnCancelar.Location = new System.Drawing.Point(341, 229);
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
            this.btnSalvar.Location = new System.Drawing.Point(228, 229);
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
            this.btnNovo.Location = new System.Drawing.Point(113, 229);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(65, 65);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Descrição: ";
            // 
            // txtAddCodigo
            // 
            this.txtAddCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCodigo.Location = new System.Drawing.Point(113, 43);
            this.txtAddCodigo.Name = "txtAddCodigo";
            this.txtAddCodigo.Size = new System.Drawing.Size(355, 29);
            this.txtAddCodigo.TabIndex = 11;
            // 
            // txtAddNome
            // 
            this.txtAddNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNome.Location = new System.Drawing.Point(113, 8);
            this.txtAddNome.Name = "txtAddNome";
            this.txtAddNome.Size = new System.Drawing.Size(355, 29);
            this.txtAddNome.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 47);
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
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1143, 45);
            this.panel3.TabIndex = 28;
            // 
            // pnlControleProdutos
            // 
            this.pnlControleProdutos.Controls.Add(this.btnCadastrarCategoria);
            this.pnlControleProdutos.Controls.Add(this.btnLocalizarCategoria);
            this.pnlControleProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControleProdutos.Location = new System.Drawing.Point(0, 45);
            this.pnlControleProdutos.Name = "pnlControleProdutos";
            this.pnlControleProdutos.Size = new System.Drawing.Size(1143, 96);
            this.pnlControleProdutos.TabIndex = 29;
            // 
            // btnCadastrarCategoria
            // 
            this.btnCadastrarCategoria.BackColor = System.Drawing.Color.DimGray;
            this.btnCadastrarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCategoria.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCategoria.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnCadastrarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCategoria.Location = new System.Drawing.Point(226, 10);
            this.btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            this.btnCadastrarCategoria.Size = new System.Drawing.Size(188, 73);
            this.btnCadastrarCategoria.TabIndex = 1;
            this.btnCadastrarCategoria.Text = "Cadastrar Categoria";
            this.btnCadastrarCategoria.UseVisualStyleBackColor = false;
            this.btnCadastrarCategoria.Click += new System.EventHandler(this.btnCadastrarCategoria_Click);
            // 
            // btnLocalizarCategoria
            // 
            this.btnLocalizarCategoria.BackColor = System.Drawing.Color.DimGray;
            this.btnLocalizarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalizarCategoria.FlatAppearance.BorderSize = 0;
            this.btnLocalizarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLocalizarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarCategoria.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnLocalizarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnLocalizarCategoria.Location = new System.Drawing.Point(14, 10);
            this.btnLocalizarCategoria.Name = "btnLocalizarCategoria";
            this.btnLocalizarCategoria.Size = new System.Drawing.Size(188, 73);
            this.btnLocalizarCategoria.TabIndex = 0;
            this.btnLocalizarCategoria.Text = "Localizar Categoria";
            this.btnLocalizarCategoria.UseVisualStyleBackColor = false;
            this.btnLocalizarCategoria.Click += new System.EventHandler(this.btnLocalizarCategoria_Click);
            // 
            // pnlLocCategoria1
            // 
            this.pnlLocCategoria1.Controls.Add(this.dataGridView1);
            this.pnlLocCategoria1.Controls.Add(this.btnBuscar);
            this.pnlLocCategoria1.Controls.Add(this.label2);
            this.pnlLocCategoria1.Controls.Add(this.label3);
            this.pnlLocCategoria1.Controls.Add(this.btnEditar);
            this.pnlLocCategoria1.Controls.Add(this.txtBuscarNome);
            this.pnlLocCategoria1.Controls.Add(this.btnExcluir);
            this.pnlLocCategoria1.Controls.Add(this.txtBuscarCodigo);
            this.pnlLocCategoria1.Location = new System.Drawing.Point(0, 187);
            this.pnlLocCategoria1.Name = "pnlLocCategoria1";
            this.pnlLocCategoria1.Size = new System.Drawing.Size(560, 449);
            this.pnlLocCategoria1.TabIndex = 30;
            this.pnlLocCategoria1.Visible = false;
            // 
            // pnlCadastroCategoria
            // 
            this.pnlCadastroCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlCadastroCategoria.Controls.Add(this.txtAddNome);
            this.pnlCadastroCategoria.Controls.Add(this.txtAddCodigo);
            this.pnlCadastroCategoria.Controls.Add(this.btnCancelar);
            this.pnlCadastroCategoria.Controls.Add(this.btnSalvar);
            this.pnlCadastroCategoria.Controls.Add(this.label5);
            this.pnlCadastroCategoria.Controls.Add(this.txtAddDescricao);
            this.pnlCadastroCategoria.Controls.Add(this.btnNovo);
            this.pnlCadastroCategoria.Controls.Add(this.label4);
            this.pnlCadastroCategoria.Controls.Add(this.label9);
            this.pnlCadastroCategoria.Location = new System.Drawing.Point(590, 179);
            this.pnlCadastroCategoria.Name = "pnlCadastroCategoria";
            this.pnlCadastroCategoria.Size = new System.Drawing.Size(508, 344);
            this.pnlCadastroCategoria.TabIndex = 31;
            this.pnlCadastroCategoria.Visible = false;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1143, 636);
            this.Controls.Add(this.pnlCadastroCategoria);
            this.Controls.Add(this.pnlLocCategoria1);
            this.Controls.Add(this.pnlControleProdutos);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategorias";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlControleProdutos.ResumeLayout(false);
            this.pnlLocCategoria1.ResumeLayout(false);
            this.pnlLocCategoria1.PerformLayout();
            this.pnlCadastroCategoria.ResumeLayout(false);
            this.pnlCadastroCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddCodigo;
        private System.Windows.Forms.TextBox txtAddNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAddDescricao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlControleProdutos;
        private System.Windows.Forms.Button btnCadastrarCategoria;
        private System.Windows.Forms.Button btnLocalizarCategoria;
        private System.Windows.Forms.Panel pnlLocCategoria1;
        private System.Windows.Forms.Panel pnlCadastroCategoria;
    }
}