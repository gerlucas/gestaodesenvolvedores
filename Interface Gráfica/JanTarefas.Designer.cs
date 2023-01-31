namespace AtividadeAvaliativaBD
{
    partial class JanTarefas
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
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstTarefas = new System.Windows.Forms.ListBox();
            this.lblTarefas = new System.Windows.Forms.Label();
            this.lstAlocacao = new System.Windows.Forms.ListBox();
            this.txtAlocacao = new System.Windows.Forms.TextBox();
            this.lblAlocacao = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtTarefa);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.lstTarefas);
            this.pnlMain.Controls.Add(this.lblTarefas);
            this.pnlMain.Controls.Add(this.lstAlocacao);
            this.pnlMain.Controls.Add(this.txtAlocacao);
            this.pnlMain.Controls.Add(this.lblAlocacao);
            this.pnlMain.Controls.Add(this.lblCadastro);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(686, 280);
            this.pnlMain.TabIndex = 24;
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(363, 106);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(235, 22);
            this.txtTarefa.TabIndex = 46;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(604, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 22);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstTarefas
            // 
            this.lstTarefas.FormattingEnabled = true;
            this.lstTarefas.ItemHeight = 16;
            this.lstTarefas.Location = new System.Drawing.Point(363, 151);
            this.lstTarefas.Name = "lstTarefas";
            this.lstTarefas.Size = new System.Drawing.Size(235, 84);
            this.lstTarefas.TabIndex = 44;
            this.lstTarefas.DoubleClick += new System.EventHandler(this.lstTarefas_DoubleClick);
            // 
            // lblTarefas
            // 
            this.lblTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblTarefas.Location = new System.Drawing.Point(360, 67);
            this.lblTarefas.Name = "lblTarefas";
            this.lblTarefas.Size = new System.Drawing.Size(181, 41);
            this.lblTarefas.TabIndex = 42;
            this.lblTarefas.Text = "Adicione a tarefa para a alocação designada.";
            // 
            // lstAlocacao
            // 
            this.lstAlocacao.FormattingEnabled = true;
            this.lstAlocacao.ItemHeight = 16;
            this.lstAlocacao.Location = new System.Drawing.Point(59, 151);
            this.lstAlocacao.Name = "lstAlocacao";
            this.lstAlocacao.Size = new System.Drawing.Size(235, 84);
            this.lstAlocacao.TabIndex = 39;
            this.lstAlocacao.SelectedIndexChanged += new System.EventHandler(this.lstAlocacao_SelectedIndexChanged);
            // 
            // txtAlocacao
            // 
            this.txtAlocacao.Location = new System.Drawing.Point(59, 106);
            this.txtAlocacao.Name = "txtAlocacao";
            this.txtAlocacao.Size = new System.Drawing.Size(235, 22);
            this.txtAlocacao.TabIndex = 28;
            this.txtAlocacao.TextChanged += new System.EventHandler(this.txtAlocacao_TextChanged);
            // 
            // lblAlocacao
            // 
            this.lblAlocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblAlocacao.Location = new System.Drawing.Point(56, 67);
            this.lblAlocacao.Name = "lblAlocacao";
            this.lblAlocacao.Size = new System.Drawing.Size(228, 36);
            this.lblAlocacao.TabIndex = 26;
            this.lblAlocacao.Text = "Pesquise por um desenvolvedor ou projeto para encontrar sua alocação.";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCadastro.Location = new System.Drawing.Point(191, 9);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(299, 29);
            this.lblCadastro.TabIndex = 25;
            this.lblCadastro.Text = "CADASTRO DE TAREFAS";
            // 
            // JanTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 281);
            this.Controls.Add(this.pnlMain);
            this.Name = "JanTarefas";
            this.Text = "JanTarefas";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListBox lstAlocacao;
        private System.Windows.Forms.TextBox txtAlocacao;
        private System.Windows.Forms.Label lblAlocacao;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.ListBox lstTarefas;
        private System.Windows.Forms.Label lblTarefas;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.Button btnAdd;
    }
}