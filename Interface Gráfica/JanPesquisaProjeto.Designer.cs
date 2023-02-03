namespace AtividadeAvaliativaBD.Interface_Gráfica
{
    partial class JanPesquisaProjeto
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
            this.dtpTerminoPlanejadoProjeto = new System.Windows.Forms.DateTimePicker();
            this.dtpTerminoPlanejado = new System.Windows.Forms.Label();
            this.dtpTerminoProjeto = new System.Windows.Forms.DateTimePicker();
            this.dtpTermino = new System.Windows.Forms.Label();
            this.lstProjetos = new System.Windows.Forms.ListBox();
            this.lstProjetosPesquisa = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeProjeto = new System.Windows.Forms.TextBox();
            this.lblLimpar = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpInicioProjeto = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpInicio = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnAtualizar);
            this.pnlMain.Controls.Add(this.dtpTerminoPlanejadoProjeto);
            this.pnlMain.Controls.Add(this.dtpTerminoPlanejado);
            this.pnlMain.Controls.Add(this.dtpTerminoProjeto);
            this.pnlMain.Controls.Add(this.dtpTermino);
            this.pnlMain.Controls.Add(this.lstProjetos);
            this.pnlMain.Controls.Add(this.lstProjetosPesquisa);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtNomeProjeto);
            this.pnlMain.Controls.Add(this.lblLimpar);
            this.pnlMain.Controls.Add(this.lblCadastro);
            this.pnlMain.Controls.Add(this.btnPesquisar);
            this.pnlMain.Controls.Add(this.dtpInicioProjeto);
            this.pnlMain.Controls.Add(this.txtNome);
            this.pnlMain.Controls.Add(this.dtpInicio);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(-2, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(696, 304);
            this.pnlMain.TabIndex = 25;
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
            this.btnAtualizar.Location = new System.Drawing.Point(368, 251);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(317, 32);
            this.btnAtualizar.TabIndex = 44;
            this.btnAtualizar.Text = "ATUALIZAR DADOS";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dtpTerminoPlanejadoProjeto
            // 
            this.dtpTerminoPlanejadoProjeto.Enabled = false;
            this.dtpTerminoPlanejadoProjeto.Location = new System.Drawing.Point(528, 70);
            this.dtpTerminoPlanejadoProjeto.Name = "dtpTerminoPlanejadoProjeto";
            this.dtpTerminoPlanejadoProjeto.Size = new System.Drawing.Size(156, 22);
            this.dtpTerminoPlanejadoProjeto.TabIndex = 45;
            // 
            // dtpTerminoPlanejado
            // 
            this.dtpTerminoPlanejado.AutoSize = true;
            this.dtpTerminoPlanejado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTerminoPlanejado.Location = new System.Drawing.Point(402, 73);
            this.dtpTerminoPlanejado.Name = "dtpTerminoPlanejado";
            this.dtpTerminoPlanejado.Size = new System.Drawing.Size(124, 16);
            this.dtpTerminoPlanejado.TabIndex = 46;
            this.dtpTerminoPlanejado.Text = "Término planejado:";
            // 
            // dtpTerminoProjeto
            // 
            this.dtpTerminoProjeto.Enabled = false;
            this.dtpTerminoProjeto.Location = new System.Drawing.Point(529, 97);
            this.dtpTerminoProjeto.Name = "dtpTerminoProjeto";
            this.dtpTerminoProjeto.Size = new System.Drawing.Size(156, 22);
            this.dtpTerminoProjeto.TabIndex = 43;
            this.dtpTerminoProjeto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtpTerminoProjeto_MouseUp);
            // 
            // dtpTermino
            // 
            this.dtpTermino.AutoSize = true;
            this.dtpTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTermino.Location = new System.Drawing.Point(466, 100);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(60, 16);
            this.dtpTermino.TabIndex = 44;
            this.dtpTermino.Text = "Término:";
            // 
            // lstProjetos
            // 
            this.lstProjetos.FormattingEnabled = true;
            this.lstProjetos.HorizontalScrollbar = true;
            this.lstProjetos.ItemHeight = 16;
            this.lstProjetos.Location = new System.Drawing.Point(368, 129);
            this.lstProjetos.Name = "lstProjetos";
            this.lstProjetos.Size = new System.Drawing.Size(317, 116);
            this.lstProjetos.TabIndex = 38;
            // 
            // lstProjetosPesquisa
            // 
            this.lstProjetosPesquisa.FormattingEnabled = true;
            this.lstProjetosPesquisa.ItemHeight = 16;
            this.lstProjetosPesquisa.Location = new System.Drawing.Point(152, 113);
            this.lstProjetosPesquisa.Name = "lstProjetosPesquisa";
            this.lstProjetosPesquisa.Size = new System.Drawing.Size(156, 84);
            this.lstProjetosPesquisa.TabIndex = 37;
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
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Pesquisar pelo nome:";
            // 
            // txtNomeProjeto
            // 
            this.txtNomeProjeto.Enabled = false;
            this.txtNomeProjeto.Location = new System.Drawing.Point(529, 14);
            this.txtNomeProjeto.Name = "txtNomeProjeto";
            this.txtNomeProjeto.Size = new System.Drawing.Size(156, 22);
            this.txtNomeProjeto.TabIndex = 30;
            // 
            // lblLimpar
            // 
            this.lblLimpar.AutoSize = true;
            this.lblLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimpar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLimpar.Location = new System.Drawing.Point(190, 245);
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
            this.lblCadastro.Location = new System.Drawing.Point(138, 9);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(139, 29);
            this.lblCadastro.TabIndex = 25;
            this.lblCadastro.Text = "PROJETOS";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Black;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(152, 263);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(156, 32);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtpInicioProjeto
            // 
            this.dtpInicioProjeto.Enabled = false;
            this.dtpInicioProjeto.Location = new System.Drawing.Point(529, 42);
            this.dtpInicioProjeto.Name = "dtpInicioProjeto";
            this.dtpInicioProjeto.Size = new System.Drawing.Size(156, 22);
            this.dtpInicioProjeto.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(152, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // dtpInicio
            // 
            this.dtpInicio.AutoSize = true;
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(488, 45);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(38, 16);
            this.dtpInicio.TabIndex = 2;
            this.dtpInicio.Text = "Início";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(479, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome:";
            // 
            // JanPesquisaProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 312);
            this.Controls.Add(this.pnlMain);
            this.Name = "JanPesquisaProjeto";
            this.Text = "Pesquisa de Projetos";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListBox lstProjetos;
        private System.Windows.Forms.ListBox lstProjetosPesquisa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeProjeto;
        private System.Windows.Forms.Label lblLimpar;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dtpInicioProjeto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label dtpInicio;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpTerminoPlanejadoProjeto;
        private System.Windows.Forms.Label dtpTerminoPlanejado;
        private System.Windows.Forms.DateTimePicker dtpTerminoProjeto;
        private System.Windows.Forms.Label dtpTermino;
        private System.Windows.Forms.Button btnAtualizar;
    }
}