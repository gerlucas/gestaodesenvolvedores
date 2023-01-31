namespace AtividadeAvaliativaBD
{
    partial class JanAlocacao
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lstProjetos = new System.Windows.Forms.ListBox();
            this.lstDevs = new System.Windows.Forms.ListBox();
            this.txtRemuneracao = new System.Windows.Forms.TextBox();
            this.lblRemuneracao = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.nmrHoras = new System.Windows.Forms.NumericUpDown();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.lblTermino = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.txtProjeto = new System.Windows.Forms.TextBox();
            this.txtDev = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnRegistrar);
            this.pnlMain.Controls.Add(this.lstProjetos);
            this.pnlMain.Controls.Add(this.lstDevs);
            this.pnlMain.Controls.Add(this.txtRemuneracao);
            this.pnlMain.Controls.Add(this.lblRemuneracao);
            this.pnlMain.Controls.Add(this.lblHoras);
            this.pnlMain.Controls.Add(this.nmrHoras);
            this.pnlMain.Controls.Add(this.dtpTermino);
            this.pnlMain.Controls.Add(this.lblTermino);
            this.pnlMain.Controls.Add(this.lblInicio);
            this.pnlMain.Controls.Add(this.dtpInicio);
            this.pnlMain.Controls.Add(this.txtProjeto);
            this.pnlMain.Controls.Add(this.txtDev);
            this.pnlMain.Controls.Add(this.lblProject);
            this.pnlMain.Controls.Add(this.lblDeveloper);
            this.pnlMain.Controls.Add(this.lblCadastro);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(576, 338);
            this.pnlMain.TabIndex = 23;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(354, 289);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(199, 46);
            this.btnRegistrar.TabIndex = 41;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lstProjetos
            // 
            this.lstProjetos.FormattingEnabled = true;
            this.lstProjetos.ItemHeight = 16;
            this.lstProjetos.Location = new System.Drawing.Point(326, 90);
            this.lstProjetos.Name = "lstProjetos";
            this.lstProjetos.Size = new System.Drawing.Size(227, 84);
            this.lstProjetos.TabIndex = 40;
            // 
            // lstDevs
            // 
            this.lstDevs.FormattingEnabled = true;
            this.lstDevs.ItemHeight = 16;
            this.lstDevs.Location = new System.Drawing.Point(66, 90);
            this.lstDevs.Name = "lstDevs";
            this.lstDevs.Size = new System.Drawing.Size(227, 84);
            this.lstDevs.TabIndex = 39;
            // 
            // txtRemuneracao
            // 
            this.txtRemuneracao.Location = new System.Drawing.Point(408, 226);
            this.txtRemuneracao.Name = "txtRemuneracao";
            this.txtRemuneracao.Size = new System.Drawing.Size(145, 22);
            this.txtRemuneracao.TabIndex = 37;
            // 
            // lblRemuneracao
            // 
            this.lblRemuneracao.AutoSize = true;
            this.lblRemuneracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblRemuneracao.Location = new System.Drawing.Point(310, 229);
            this.lblRemuneracao.Name = "lblRemuneracao";
            this.lblRemuneracao.Size = new System.Drawing.Size(96, 16);
            this.lblRemuneracao.TabIndex = 36;
            this.lblRemuneracao.Text = "Remuneração:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblHoras.Location = new System.Drawing.Point(297, 203);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(109, 16);
            this.lblHoras.TabIndex = 35;
            this.lblHoras.Text = "Horas semanais:";
            // 
            // nmrHoras
            // 
            this.nmrHoras.Location = new System.Drawing.Point(408, 200);
            this.nmrHoras.Name = "nmrHoras";
            this.nmrHoras.Size = new System.Drawing.Size(145, 22);
            this.nmrHoras.TabIndex = 34;
            this.nmrHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpTermino
            // 
            this.dtpTermino.Location = new System.Drawing.Point(148, 226);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(145, 22);
            this.dtpTermino.TabIndex = 33;
            // 
            // lblTermino
            // 
            this.lblTermino.AutoSize = true;
            this.lblTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblTermino.Location = new System.Drawing.Point(81, 232);
            this.lblTermino.Name = "lblTermino";
            this.lblTermino.Size = new System.Drawing.Size(60, 16);
            this.lblTermino.TabIndex = 32;
            this.lblTermino.Text = "Término:";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblInicio.Location = new System.Drawing.Point(105, 205);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(41, 16);
            this.lblInicio.TabIndex = 31;
            this.lblInicio.Text = "Inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(148, 200);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(145, 22);
            this.dtpInicio.TabIndex = 30;
            // 
            // txtProjeto
            // 
            this.txtProjeto.Location = new System.Drawing.Point(453, 62);
            this.txtProjeto.Name = "txtProjeto";
            this.txtProjeto.Size = new System.Drawing.Size(100, 22);
            this.txtProjeto.TabIndex = 29;
            this.txtProjeto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProjeto_KeyUp);
            // 
            // txtDev
            // 
            this.txtDev.Location = new System.Drawing.Point(193, 62);
            this.txtDev.Name = "txtDev";
            this.txtDev.Size = new System.Drawing.Size(100, 22);
            this.txtDev.TabIndex = 28;
            this.txtDev.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDev_KeyUp);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblProject.Location = new System.Drawing.Point(323, 65);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(123, 16);
            this.lblProject.TabIndex = 27;
            this.lblProject.Text = "Pesquise o projeto:";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblDeveloper.Location = new System.Drawing.Point(13, 65);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(172, 16);
            this.lblDeveloper.TabIndex = 26;
            this.lblDeveloper.Text = "Pesquise o desenvolvedor:";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCadastro.Location = new System.Drawing.Point(116, 12);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(335, 29);
            this.lblCadastro.TabIndex = 25;
            this.lblCadastro.Text = "CADASTRO DE ALOCAÇÕES";
            // 
            // JanAlocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 345);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JanAlocacao";
            this.Text = "Alocação";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.ListBox lstProjetos;
        private System.Windows.Forms.ListBox lstDevs;
        private System.Windows.Forms.TextBox txtRemuneracao;
        private System.Windows.Forms.Label lblRemuneracao;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.NumericUpDown nmrHoras;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.Label lblTermino;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.TextBox txtProjeto;
        private System.Windows.Forms.TextBox txtDev;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Button btnRegistrar;
    }
}