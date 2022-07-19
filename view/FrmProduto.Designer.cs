namespace ProjetoDS.view
{
    partial class FrmProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCadastroTitulo = new System.Windows.Forms.Label();
            this.TabPrdouto = new System.Windows.Forms.TabControl();
            this.TabCadastro = new System.Windows.Forms.TabPage();
            this.CampoPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.txtDescricaoDoProduto = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDescricoDoProduto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabConsulta = new System.Windows.Forms.TabPage();
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.comoBoxFiltro = new System.Windows.Forms.ComboBox();
            this.CampoPesquisa = new System.Windows.Forms.TextBox();
            this.txtFiltro = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TabPrdouto.SuspendLayout();
            this.TabCadastro.SuspendLayout();
            this.TabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.txtCadastroTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtCadastroTitulo
            // 
            this.txtCadastroTitulo.AutoSize = true;
            this.txtCadastroTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroTitulo.ForeColor = System.Drawing.Color.White;
            this.txtCadastroTitulo.Location = new System.Drawing.Point(52, 44);
            this.txtCadastroTitulo.Name = "txtCadastroTitulo";
            this.txtCadastroTitulo.Size = new System.Drawing.Size(221, 25);
            this.txtCadastroTitulo.TabIndex = 0;
            this.txtCadastroTitulo.Text = "Cadastro de Produtos";
            // 
            // TabPrdouto
            // 
            this.TabPrdouto.Controls.Add(this.TabCadastro);
            this.TabPrdouto.Controls.Add(this.TabConsulta);
            this.TabPrdouto.Location = new System.Drawing.Point(12, 120);
            this.TabPrdouto.Name = "TabPrdouto";
            this.TabPrdouto.SelectedIndex = 0;
            this.TabPrdouto.Size = new System.Drawing.Size(776, 276);
            this.TabPrdouto.TabIndex = 1;
            // 
            // TabCadastro
            // 
            this.TabCadastro.Controls.Add(this.CampoPreco);
            this.TabCadastro.Controls.Add(this.label2);
            this.TabCadastro.Controls.Add(this.tbFornecedor);
            this.TabCadastro.Controls.Add(this.txtqtd);
            this.TabCadastro.Controls.Add(this.txtDescricaoDoProduto);
            this.TabCadastro.Controls.Add(this.txtid);
            this.TabCadastro.Controls.Add(this.label4);
            this.TabCadastro.Controls.Add(this.label3);
            this.TabCadastro.Controls.Add(this.lbDescricoDoProduto);
            this.TabCadastro.Controls.Add(this.label1);
            this.TabCadastro.Location = new System.Drawing.Point(4, 22);
            this.TabCadastro.Name = "TabCadastro";
            this.TabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.TabCadastro.Size = new System.Drawing.Size(768, 250);
            this.TabCadastro.TabIndex = 0;
            this.TabCadastro.Text = "Cadastro";
            this.TabCadastro.UseVisualStyleBackColor = true;
            // 
            // CampoPreco
            // 
            this.CampoPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoPreco.Location = new System.Drawing.Point(614, 144);
            this.CampoPreco.Name = "CampoPreco";
            this.CampoPreco.Size = new System.Drawing.Size(104, 29);
            this.CampoPreco.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Preço :";
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFornecedor.FormattingEnabled = true;
            this.tbFornecedor.Location = new System.Drawing.Point(179, 146);
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.Size = new System.Drawing.Size(233, 32);
            this.tbFornecedor.TabIndex = 27;
            // 
            // txtqtd
            // 
            this.txtqtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtd.Location = new System.Drawing.Point(614, 92);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(104, 29);
            this.txtqtd.TabIndex = 26;
            // 
            // txtDescricaoDoProduto
            // 
            this.txtDescricaoDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoDoProduto.Location = new System.Drawing.Point(253, 92);
            this.txtDescricaoDoProduto.Name = "txtDescricaoDoProduto";
            this.txtDescricaoDoProduto.Size = new System.Drawing.Size(286, 29);
            this.txtDescricaoDoProduto.TabIndex = 25;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(132, 37);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(61, 29);
            this.txtid.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Qtd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fornecedor :";
            // 
            // lbDescricoDoProduto
            // 
            this.lbDescricoDoProduto.AutoSize = true;
            this.lbDescricoDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricoDoProduto.Location = new System.Drawing.Point(45, 94);
            this.lbDescricoDoProduto.Name = "lbDescricoDoProduto";
            this.lbDescricoDoProduto.Size = new System.Drawing.Size(202, 24);
            this.lbDescricoDoProduto.TabIndex = 21;
            this.lbDescricoDoProduto.Text = "Descrição do Produto :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Código :";
            // 
            // TabConsulta
            // 
            this.TabConsulta.Controls.Add(this.dgProduto);
            this.TabConsulta.Controls.Add(this.BtnBuscar);
            this.TabConsulta.Controls.Add(this.comoBoxFiltro);
            this.TabConsulta.Controls.Add(this.CampoPesquisa);
            this.TabConsulta.Controls.Add(this.txtFiltro);
            this.TabConsulta.Controls.Add(this.txtPesquisa);
            this.TabConsulta.Location = new System.Drawing.Point(4, 22);
            this.TabConsulta.Name = "TabConsulta";
            this.TabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.TabConsulta.Size = new System.Drawing.Size(768, 250);
            this.TabConsulta.TabIndex = 1;
            this.TabConsulta.Text = "Consulta";
            this.TabConsulta.UseVisualStyleBackColor = true;
            // 
            // dgProduto
            // 
            this.dgProduto.AllowUserToAddRows = false;
            this.dgProduto.AllowUserToDeleteRows = false;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Location = new System.Drawing.Point(6, 70);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.ReadOnly = true;
            this.dgProduto.Size = new System.Drawing.Size(756, 174);
            this.dgProduto.TabIndex = 4;
            this.dgProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduto_CellClick);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(595, 27);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // comoBoxFiltro
            // 
            this.comoBoxFiltro.FormattingEnabled = true;
            this.comoBoxFiltro.Location = new System.Drawing.Point(398, 29);
            this.comoBoxFiltro.Name = "comoBoxFiltro";
            this.comoBoxFiltro.Size = new System.Drawing.Size(167, 21);
            this.comoBoxFiltro.TabIndex = 1;
            // 
            // CampoPesquisa
            // 
            this.CampoPesquisa.Location = new System.Drawing.Point(100, 32);
            this.CampoPesquisa.Name = "CampoPesquisa";
            this.CampoPesquisa.Size = new System.Drawing.Size(223, 20);
            this.CampoPesquisa.TabIndex = 2;
            // 
            // txtFiltro
            // 
            this.txtFiltro.AutoSize = true;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(340, 30);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(52, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.Text = "Filtro :";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AutoSize = true;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(12, 30);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(82, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.Text = "Pesquisa :";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(241, 415);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 2;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(353, 415);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 3;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(470, 415);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 4;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TabPrdouto);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AX SOFT  SUPORTE (11) 9-6323-1887";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabPrdouto.ResumeLayout(false);
            this.TabCadastro.ResumeLayout(false);
            this.TabCadastro.PerformLayout();
            this.TabConsulta.ResumeLayout(false);
            this.TabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtCadastroTitulo;
        private System.Windows.Forms.TabControl TabPrdouto;
        private System.Windows.Forms.TabPage TabCadastro;
        private System.Windows.Forms.TabPage TabConsulta;
        private System.Windows.Forms.DataGridView dgProduto;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox comoBoxFiltro;
        private System.Windows.Forms.TextBox CampoPesquisa;
        private System.Windows.Forms.Label txtFiltro;
        private System.Windows.Forms.Label txtPesquisa;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.ComboBox tbFornecedor;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.TextBox txtDescricaoDoProduto;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDescricoDoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CampoPreco;
        private System.Windows.Forms.Label label2;
    }
}