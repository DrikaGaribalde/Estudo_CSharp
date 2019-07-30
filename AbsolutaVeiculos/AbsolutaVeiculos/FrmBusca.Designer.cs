namespace AbsolutaVeiculos
{
    partial class FrmBusca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusca));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdFoto = new System.Windows.Forms.DataGridView();
            this.picImagem4 = new System.Windows.Forms.PictureBox();
            this.picImagem3 = new System.Windows.Forms.PictureBox();
            this.picImagem1 = new System.Windows.Forms.PictureBox();
            this.picImagem2 = new System.Windows.Forms.PictureBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtCaminhoImagem1 = new System.Windows.Forms.TextBox();
            this.txtCaminhoImagem2 = new System.Windows.Forms.TextBox();
            this.btnPesquisa1 = new System.Windows.Forms.Button();
            this.btnPesquisa2 = new System.Windows.Forms.Button();
            this.txtCaminhoImagem3 = new System.Windows.Forms.TextBox();
            this.btnPesquisa3 = new System.Windows.Forms.Button();
            this.txtCaminhoImagem4 = new System.Windows.Forms.TextBox();
            this.btnPesquisa4 = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtCodFoto = new System.Windows.Forms.TextBox();
            this.dlgCaminhoImagem = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Marca:";
            // 
            // grdFoto
            // 
            this.grdFoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFoto.Location = new System.Drawing.Point(14, 119);
            this.grdFoto.Name = "grdFoto";
            this.grdFoto.ReadOnly = true;
            this.grdFoto.Size = new System.Drawing.Size(761, 138);
            this.grdFoto.TabIndex = 14;
            this.grdFoto.Click += new System.EventHandler(this.grdFoto_Click);
            // 
            // picImagem4
            // 
            this.picImagem4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagem4.Location = new System.Drawing.Point(604, 333);
            this.picImagem4.Name = "picImagem4";
            this.picImagem4.Size = new System.Drawing.Size(171, 200);
            this.picImagem4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem4.TabIndex = 15;
            this.picImagem4.TabStop = false;
            // 
            // picImagem3
            // 
            this.picImagem3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagem3.Location = new System.Drawing.Point(410, 333);
            this.picImagem3.Name = "picImagem3";
            this.picImagem3.Size = new System.Drawing.Size(171, 200);
            this.picImagem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem3.TabIndex = 16;
            this.picImagem3.TabStop = false;
            // 
            // picImagem1
            // 
            this.picImagem1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagem1.Location = new System.Drawing.Point(14, 333);
            this.picImagem1.Name = "picImagem1";
            this.picImagem1.Size = new System.Drawing.Size(171, 200);
            this.picImagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem1.TabIndex = 17;
            this.picImagem1.TabStop = false;
            // 
            // picImagem2
            // 
            this.picImagem2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagem2.Location = new System.Drawing.Point(212, 333);
            this.picImagem2.Name = "picImagem2";
            this.picImagem2.Size = new System.Drawing.Size(171, 200);
            this.picImagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem2.TabIndex = 18;
            this.picImagem2.TabStop = false;
            // 
            // cmbModelo
            // 
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(330, 77);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(251, 21);
            this.cmbModelo.TabIndex = 19;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(55, 77);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(251, 21);
            this.cmbMarca.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(56, 33);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(525, 21);
            this.cmbCliente.TabIndex = 23;
            // 
            // txtCaminhoImagem1
            // 
            this.txtCaminhoImagem1.Location = new System.Drawing.Point(15, 278);
            this.txtCaminhoImagem1.Name = "txtCaminhoImagem1";
            this.txtCaminhoImagem1.ReadOnly = true;
            this.txtCaminhoImagem1.Size = new System.Drawing.Size(171, 20);
            this.txtCaminhoImagem1.TabIndex = 24;
            this.txtCaminhoImagem1.Leave += new System.EventHandler(this.txtCaminhoImagem1_Leave);
            // 
            // txtCaminhoImagem2
            // 
            this.txtCaminhoImagem2.Location = new System.Drawing.Point(212, 278);
            this.txtCaminhoImagem2.Name = "txtCaminhoImagem2";
            this.txtCaminhoImagem2.ReadOnly = true;
            this.txtCaminhoImagem2.Size = new System.Drawing.Size(171, 20);
            this.txtCaminhoImagem2.TabIndex = 25;
            this.txtCaminhoImagem2.Leave += new System.EventHandler(this.txtCaminhoImagem2_Leave);
            // 
            // btnPesquisa1
            // 
            this.btnPesquisa1.Location = new System.Drawing.Point(111, 302);
            this.btnPesquisa1.Name = "btnPesquisa1";
            this.btnPesquisa1.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa1.TabIndex = 26;
            this.btnPesquisa1.Text = "Foto 1";
            this.btnPesquisa1.UseVisualStyleBackColor = true;
            this.btnPesquisa1.Click += new System.EventHandler(this.btnPesquisa1_Click);
            // 
            // btnPesquisa2
            // 
            this.btnPesquisa2.Location = new System.Drawing.Point(308, 304);
            this.btnPesquisa2.Name = "btnPesquisa2";
            this.btnPesquisa2.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa2.TabIndex = 27;
            this.btnPesquisa2.Text = "Foto 2";
            this.btnPesquisa2.UseVisualStyleBackColor = true;
            this.btnPesquisa2.Click += new System.EventHandler(this.btnPesquisa2_Click);
            // 
            // txtCaminhoImagem3
            // 
            this.txtCaminhoImagem3.Location = new System.Drawing.Point(410, 278);
            this.txtCaminhoImagem3.Name = "txtCaminhoImagem3";
            this.txtCaminhoImagem3.ReadOnly = true;
            this.txtCaminhoImagem3.Size = new System.Drawing.Size(171, 20);
            this.txtCaminhoImagem3.TabIndex = 28;
            this.txtCaminhoImagem3.Leave += new System.EventHandler(this.txtCaminhoImagem3_Leave);
            // 
            // btnPesquisa3
            // 
            this.btnPesquisa3.Location = new System.Drawing.Point(506, 304);
            this.btnPesquisa3.Name = "btnPesquisa3";
            this.btnPesquisa3.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa3.TabIndex = 29;
            this.btnPesquisa3.Text = "Foto 3";
            this.btnPesquisa3.UseVisualStyleBackColor = true;
            this.btnPesquisa3.Click += new System.EventHandler(this.btnPesquisa3_Click);
            // 
            // txtCaminhoImagem4
            // 
            this.txtCaminhoImagem4.Location = new System.Drawing.Point(604, 278);
            this.txtCaminhoImagem4.Name = "txtCaminhoImagem4";
            this.txtCaminhoImagem4.ReadOnly = true;
            this.txtCaminhoImagem4.Size = new System.Drawing.Size(171, 20);
            this.txtCaminhoImagem4.TabIndex = 30;
            this.txtCaminhoImagem4.Leave += new System.EventHandler(this.txtCaminhoImagem4_Leave);
            // 
            // btnPesquisa4
            // 
            this.btnPesquisa4.Location = new System.Drawing.Point(700, 304);
            this.btnPesquisa4.Name = "btnPesquisa4";
            this.btnPesquisa4.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa4.TabIndex = 31;
            this.btnPesquisa4.Text = "Foto 4";
            this.btnPesquisa4.UseVisualStyleBackColor = true;
            this.btnPesquisa4.Click += new System.EventHandler(this.btnPesquisa4_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(457, 550);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 32;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(538, 550);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 33;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(619, 550);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 34;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(700, 550);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 35;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtCodFoto
            // 
            this.txtCodFoto.Location = new System.Drawing.Point(12, 33);
            this.txtCodFoto.Name = "txtCodFoto";
            this.txtCodFoto.ReadOnly = true;
            this.txtCodFoto.Size = new System.Drawing.Size(42, 20);
            this.txtCodFoto.TabIndex = 36;
            // 
            // dlgCaminhoImagem
            // 
            this.dlgCaminhoImagem.DefaultExt = "jpg";
            this.dlgCaminhoImagem.FileName = "openFileDialog1";
            this.dlgCaminhoImagem.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            this.dlgCaminhoImagem.Title = "Localizar uma imagem";
            this.dlgCaminhoImagem.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgCaminhoImagem_FileOk);
            // 
            // FrmBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(789, 585);
            this.Controls.Add(this.txtCodFoto);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnPesquisa4);
            this.Controls.Add(this.txtCaminhoImagem4);
            this.Controls.Add(this.btnPesquisa3);
            this.Controls.Add(this.txtCaminhoImagem3);
            this.Controls.Add(this.btnPesquisa2);
            this.Controls.Add(this.btnPesquisa1);
            this.Controls.Add(this.txtCaminhoImagem2);
            this.Controls.Add(this.txtCaminhoImagem1);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.picImagem2);
            this.Controls.Add(this.picImagem1);
            this.Controls.Add(this.picImagem3);
            this.Controls.Add(this.picImagem4);
            this.Controls.Add(this.grdFoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de Automóvel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBusca_FormClosing);
            this.Load += new System.EventHandler(this.FrmBusca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdFoto;
        private System.Windows.Forms.PictureBox picImagem4;
        private System.Windows.Forms.PictureBox picImagem3;
        private System.Windows.Forms.PictureBox picImagem1;
        private System.Windows.Forms.PictureBox picImagem2;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtCaminhoImagem1;
        private System.Windows.Forms.TextBox txtCaminhoImagem2;
        private System.Windows.Forms.Button btnPesquisa1;
        private System.Windows.Forms.Button btnPesquisa2;
        private System.Windows.Forms.TextBox txtCaminhoImagem3;
        private System.Windows.Forms.Button btnPesquisa3;
        private System.Windows.Forms.TextBox txtCaminhoImagem4;
        private System.Windows.Forms.Button btnPesquisa4;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtCodFoto;
        private System.Windows.Forms.OpenFileDialog dlgCaminhoImagem;
    }
}