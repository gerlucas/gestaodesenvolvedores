namespace AtividadeAvaliativaBD
{
    partial class JanCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanCadastrar));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cbxNivel = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAdm = new System.Windows.Forms.GroupBox();
            this.rdbAdmSim = new System.Windows.Forms.RadioButton();
            this.rdbAdmNao = new System.Windows.Forms.RadioButton();
            this.grpAtivo = new System.Windows.Forms.GroupBox();
            this.rdbAtivoSim = new System.Windows.Forms.RadioButton();
            this.rdbAtivoNao = new System.Windows.Forms.RadioButton();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblbirthday = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.grpAdm.SuspendLayout();
            this.grpAtivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cbxNivel);
            this.pnlMain.Controls.Add(this.lblNivel);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.grpAdm);
            this.pnlMain.Controls.Add(this.grpAtivo);
            this.pnlMain.Controls.Add(this.lblCadastro);
            this.pnlMain.Controls.Add(this.btnCadastro);
            this.pnlMain.Controls.Add(this.dtpNascimento);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.txtSenha);
            this.pnlMain.Controls.Add(this.txtNome);
            this.pnlMain.Controls.Add(this.lblPassword);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.lblbirthday);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(447, 291);
            this.pnlMain.TabIndex = 22;
            // 
            // cbxNivel
            // 
            this.cbxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNivel.FormattingEnabled = true;
            this.cbxNivel.Location = new System.Drawing.Point(107, 172);
            this.cbxNivel.Name = "cbxNivel";
            this.cbxNivel.Size = new System.Drawing.Size(156, 24);
            this.cbxNivel.TabIndex = 5;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(49, 177);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(41, 16);
            this.lblNivel.TabIndex = 29;
            this.lblNivel.Text = "Nível:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(323, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "LIMPAR CAMPOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpAdm
            // 
            this.grpAdm.Controls.Add(this.rdbAdmSim);
            this.grpAdm.Controls.Add(this.rdbAdmNao);
            this.grpAdm.Location = new System.Drawing.Point(273, 144);
            this.grpAdm.Name = "grpAdm";
            this.grpAdm.Size = new System.Drawing.Size(159, 53);
            this.grpAdm.TabIndex = 7;
            this.grpAdm.TabStop = false;
            this.grpAdm.Text = "Administrador";
            // 
            // rdbAdmSim
            // 
            this.rdbAdmSim.AutoSize = true;
            this.rdbAdmSim.Location = new System.Drawing.Point(6, 21);
            this.rdbAdmSim.Name = "rdbAdmSim";
            this.rdbAdmSim.Size = new System.Drawing.Size(48, 20);
            this.rdbAdmSim.TabIndex = 15;
            this.rdbAdmSim.TabStop = true;
            this.rdbAdmSim.Text = "Sim";
            this.rdbAdmSim.UseVisualStyleBackColor = true;
            // 
            // rdbAdmNao
            // 
            this.rdbAdmNao.AutoSize = true;
            this.rdbAdmNao.Location = new System.Drawing.Point(102, 21);
            this.rdbAdmNao.Name = "rdbAdmNao";
            this.rdbAdmNao.Size = new System.Drawing.Size(51, 20);
            this.rdbAdmNao.TabIndex = 17;
            this.rdbAdmNao.TabStop = true;
            this.rdbAdmNao.Text = "Não";
            this.rdbAdmNao.UseVisualStyleBackColor = true;
            // 
            // grpAtivo
            // 
            this.grpAtivo.Controls.Add(this.rdbAtivoSim);
            this.grpAtivo.Controls.Add(this.rdbAtivoNao);
            this.grpAtivo.Location = new System.Drawing.Point(273, 71);
            this.grpAtivo.Name = "grpAtivo";
            this.grpAtivo.Size = new System.Drawing.Size(159, 53);
            this.grpAtivo.TabIndex = 6;
            this.grpAtivo.TabStop = false;
            this.grpAtivo.Text = "Desenvolvedor ativo";
            // 
            // rdbAtivoSim
            // 
            this.rdbAtivoSim.AutoSize = true;
            this.rdbAtivoSim.Location = new System.Drawing.Point(6, 21);
            this.rdbAtivoSim.Name = "rdbAtivoSim";
            this.rdbAtivoSim.Size = new System.Drawing.Size(48, 20);
            this.rdbAtivoSim.TabIndex = 15;
            this.rdbAtivoSim.TabStop = true;
            this.rdbAtivoSim.Text = "Sim";
            this.rdbAtivoSim.UseVisualStyleBackColor = true;
            // 
            // rdbAtivoNao
            // 
            this.rdbAtivoNao.AutoSize = true;
            this.rdbAtivoNao.Location = new System.Drawing.Point(102, 21);
            this.rdbAtivoNao.Name = "rdbAtivoNao";
            this.rdbAtivoNao.Size = new System.Drawing.Size(51, 20);
            this.rdbAtivoNao.TabIndex = 17;
            this.rdbAtivoNao.TabStop = true;
            this.rdbAtivoNao.Text = "Não";
            this.rdbAtivoNao.UseVisualStyleBackColor = true;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCadastro.Location = new System.Drawing.Point(21, 4);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(405, 29);
            this.lblCadastro.TabIndex = 25;
            this.lblCadastro.Text = "CADASTRO DE DESENVOLVEDOR";
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Black;
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(282, 250);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(156, 32);
            this.btnCadastro.TabIndex = 8;
            this.btnCadastro.Text = "CADASTRAR";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(107, 79);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(156, 22);
            this.dtpNascimento.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(107, 144);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(156, 22);
            this.txtSenha.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(107, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 22);
            this.txtNome.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(49, 147);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(49, 16);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(45, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail: ";
            // 
            // lblbirthday
            // 
            this.lblbirthday.AutoSize = true;
            this.lblbirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbirthday.Location = new System.Drawing.Point(14, 82);
            this.lblbirthday.Name = "lblbirthday";
            this.lblbirthday.Size = new System.Drawing.Size(82, 16);
            this.lblbirthday.TabIndex = 2;
            this.lblbirthday.Text = "Nascimento:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(49, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome:";
            // 
            // JanCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 294);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JanCadastrar";
            this.Text = "Cadastro de Desenvolvedores";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.grpAdm.ResumeLayout(false);
            this.grpAdm.PerformLayout();
            this.grpAtivo.ResumeLayout(false);
            this.grpAtivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.RadioButton rdbAtivoNao;
        private System.Windows.Forms.RadioButton rdbAtivoSim;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblbirthday;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.GroupBox grpAdm;
        private System.Windows.Forms.RadioButton rdbAdmSim;
        private System.Windows.Forms.RadioButton rdbAdmNao;
        private System.Windows.Forms.GroupBox grpAtivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cbxNivel;
    }
}