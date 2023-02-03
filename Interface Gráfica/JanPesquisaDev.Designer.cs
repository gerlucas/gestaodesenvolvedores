namespace AtividadeAvaliativaBD
{
    partial class JanPesquisaDev
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.chkAdm = new System.Windows.Forms.CheckBox();
            this.lblAdm = new System.Windows.Forms.Label();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.lstAlocacoesDev = new System.Windows.Forms.ListBox();
            this.lstDevsPesquisa = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxNivelDev = new System.Windows.Forms.ComboBox();
            this.txtEmailDev = new System.Windows.Forms.TextBox();
            this.txtNomeDev = new System.Windows.Forms.TextBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblLimpar = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpNascimentoDev = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblbirthday = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnAtualizar);
            this.pnlMain.Controls.Add(this.chkAtivo);
            this.pnlMain.Controls.Add(this.chkAdm);
            this.pnlMain.Controls.Add(this.lblAdm);
            this.pnlMain.Controls.Add(this.lblAtivo);
            this.pnlMain.Controls.Add(this.lstAlocacoesDev);
            this.pnlMain.Controls.Add(this.lstDevsPesquisa);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.cbxNivelDev);
            this.pnlMain.Controls.Add(this.txtEmailDev);
            this.pnlMain.Controls.Add(this.txtNomeDev);
            this.pnlMain.Controls.Add(this.lblNivel);
            this.pnlMain.Controls.Add(this.lblLimpar);
            this.pnlMain.Controls.Add(this.lblCadastro);
            this.pnlMain.Controls.Add(this.btnPesquisar);
            this.pnlMain.Controls.Add(this.dtpNascimentoDev);
            this.pnlMain.Controls.Add(this.txtNome);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.lblbirthday);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(2, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(673, 316);
            this.pnlMain.TabIndex = 24;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(392, 276);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(238, 32);
            this.btnAtualizar.TabIndex = 43;
            this.btnAtualizar.Text = "ATUALIZAR DADOS";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Location = new System.Drawing.Point(615, 149);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(15, 14);
            this.chkAtivo.TabIndex = 42;
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.Click += new System.EventHandler(this.chkAtivo_Click);
            // 
            // chkAdm
            // 
            this.chkAdm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAdm.AutoSize = true;
            this.chkAdm.Enabled = false;
            this.chkAdm.Location = new System.Drawing.Point(615, 131);
            this.chkAdm.Name = "chkAdm";
            this.chkAdm.Size = new System.Drawing.Size(15, 14);
            this.chkAdm.TabIndex = 41;
            this.chkAdm.UseVisualStyleBackColor = true;
            this.chkAdm.Click += new System.EventHandler(this.chkAdm_Click);
            // 
            // lblAdm
            // 
            this.lblAdm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdm.AutoSize = true;
            this.lblAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblAdm.Location = new System.Drawing.Point(512, 131);
            this.lblAdm.Name = "lblAdm";
            this.lblAdm.Size = new System.Drawing.Size(93, 16);
            this.lblAdm.TabIndex = 39;
            this.lblAdm.Text = "Administrador:";
            // 
            // lblAtivo
            // 
            this.lblAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblAtivo.Location = new System.Drawing.Point(472, 147);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(135, 16);
            this.lblAtivo.TabIndex = 40;
            this.lblAtivo.Text = "Desenvolvedor ativo:";
            // 
            // lstAlocacoesDev
            // 
            this.lstAlocacoesDev.FormattingEnabled = true;
            this.lstAlocacoesDev.HorizontalScrollbar = true;
            this.lstAlocacoesDev.ItemHeight = 16;
            this.lstAlocacoesDev.Location = new System.Drawing.Point(392, 169);
            this.lstAlocacoesDev.Name = "lstAlocacoesDev";
            this.lstAlocacoesDev.Size = new System.Drawing.Size(238, 100);
            this.lstAlocacoesDev.TabIndex = 38;
            // 
            // lstDevsPesquisa
            // 
            this.lstDevsPesquisa.FormattingEnabled = true;
            this.lstDevsPesquisa.ItemHeight = 16;
            this.lstDevsPesquisa.Location = new System.Drawing.Point(152, 113);
            this.lstDevsPesquisa.Name = "lstDevsPesquisa";
            this.lstDevsPesquisa.Size = new System.Drawing.Size(156, 84);
            this.lstDevsPesquisa.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(358, -19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 375);
            this.panel1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Pesquisar pelo nome:";
            // 
            // cbxNivelDev
            // 
            this.cbxNivelDev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNivelDev.Enabled = false;
            this.cbxNivelDev.FormattingEnabled = true;
            this.cbxNivelDev.Location = new System.Drawing.Point(474, 92);
            this.cbxNivelDev.Name = "cbxNivelDev";
            this.cbxNivelDev.Size = new System.Drawing.Size(156, 24);
            this.cbxNivelDev.TabIndex = 33;
            // 
            // txtEmailDev
            // 
            this.txtEmailDev.Enabled = false;
            this.txtEmailDev.Location = new System.Drawing.Point(474, 64);
            this.txtEmailDev.Name = "txtEmailDev";
            this.txtEmailDev.Size = new System.Drawing.Size(156, 22);
            this.txtEmailDev.TabIndex = 31;
            // 
            // txtNomeDev
            // 
            this.txtNomeDev.Enabled = false;
            this.txtNomeDev.Location = new System.Drawing.Point(474, 8);
            this.txtNomeDev.Name = "txtNomeDev";
            this.txtNomeDev.Size = new System.Drawing.Size(156, 22);
            this.txtNomeDev.TabIndex = 30;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(430, 96);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(41, 16);
            this.lblNivel.TabIndex = 29;
            this.lblNivel.Text = "Nível:";
            // 
            // lblLimpar
            // 
            this.lblLimpar.AutoSize = true;
            this.lblLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimpar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLimpar.Location = new System.Drawing.Point(190, 219);
            this.lblLimpar.Name = "lblLimpar";
            this.lblLimpar.Size = new System.Drawing.Size(115, 16);
            this.lblLimpar.TabIndex = 28;
            this.lblLimpar.Text = "LIMPAR CAMPOS";
            this.lblLimpar.Click += new System.EventHandler(this.lblLimpar_Click);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCadastro.Location = new System.Drawing.Point(65, 5);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(257, 29);
            this.lblCadastro.TabIndex = 25;
            this.lblCadastro.Text = "DESENVOLVEDORES";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Black;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(152, 237);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(156, 32);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtpNascimentoDev
            // 
            this.dtpNascimentoDev.Enabled = false;
            this.dtpNascimentoDev.Location = new System.Drawing.Point(474, 38);
            this.dtpNascimentoDev.Name = "dtpNascimentoDev";
            this.dtpNascimentoDev.Size = new System.Drawing.Size(156, 22);
            this.dtpNascimentoDev.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(152, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(420, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail: ";
            // 
            // lblbirthday
            // 
            this.lblbirthday.AutoSize = true;
            this.lblbirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbirthday.Location = new System.Drawing.Point(389, 41);
            this.lblbirthday.Name = "lblbirthday";
            this.lblbirthday.Size = new System.Drawing.Size(82, 16);
            this.lblbirthday.TabIndex = 2;
            this.lblbirthday.Text = "Nascimento:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(424, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome:";
            // 
            // JanPesquisaDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 320);
            this.Controls.Add(this.pnlMain);
            this.Name = "JanPesquisaDev";
            this.Text = "Pesquisa de Desenvolvedores";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListBox lstDevsPesquisa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxNivelDev;
        private System.Windows.Forms.TextBox txtEmailDev;
        private System.Windows.Forms.TextBox txtNomeDev;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblLimpar;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dtpNascimentoDev;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblbirthday;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lstAlocacoesDev;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.CheckBox chkAdm;
        private System.Windows.Forms.Label lblAdm;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Button btnAtualizar;
    }
}