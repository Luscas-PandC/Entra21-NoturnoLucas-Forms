
namespace AcademiaGinastica
{
    partial class FrmProfessor
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
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCadastrarProfessor = new System.Windows.Forms.Button();
            this.MskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.MskCPF = new System.Windows.Forms.MaskedTextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCPF = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnNovoProfessor = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.LbxCadastrados = new System.Windows.Forms.ListBox();
            this.CmbTurno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(184, 151);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(120, 23);
            this.BtnNovo.TabIndex = 6;
            this.BtnNovo.Text = "Novo Professor";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnCadastrarProfessor
            // 
            this.BtnCadastrarProfessor.Location = new System.Drawing.Point(28, 151);
            this.BtnCadastrarProfessor.Name = "BtnCadastrarProfessor";
            this.BtnCadastrarProfessor.Size = new System.Drawing.Size(120, 23);
            this.BtnCadastrarProfessor.TabIndex = 5;
            this.BtnCadastrarProfessor.Text = "Cadastrar Professor";
            this.BtnCadastrarProfessor.UseVisualStyleBackColor = true;
            this.BtnCadastrarProfessor.Click += new System.EventHandler(this.BtnCadastrarProfessor_Click);
            // 
            // MskTelefone
            // 
            this.MskTelefone.Location = new System.Drawing.Point(183, 45);
            this.MskTelefone.Mask = "(00) 00000-0000";
            this.MskTelefone.Name = "MskTelefone";
            this.MskTelefone.Size = new System.Drawing.Size(121, 23);
            this.MskTelefone.TabIndex = 2;
            // 
            // MskCPF
            // 
            this.MskCPF.Location = new System.Drawing.Point(28, 98);
            this.MskCPF.Mask = "000,000,000-00";
            this.MskCPF.Name = "MskCPF";
            this.MskCPF.Size = new System.Drawing.Size(120, 23);
            this.MskCPF.TabIndex = 3;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(28, 45);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(120, 23);
            this.TxtNome.TabIndex = 1;
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(184, 27);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(52, 15);
            this.LblTelefone.TabIndex = 19;
            this.LblTelefone.Text = "Telefone";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(28, 27);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(40, 15);
            this.LblNome.TabIndex = 34;
            this.LblNome.Text = "Nome";
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Location = new System.Drawing.Point(28, 80);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(28, 15);
            this.LblCPF.TabIndex = 35;
            this.LblCPF.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Turno";
            // 
            // BtnNovoProfessor
            // 
            this.BtnNovoProfessor.Location = new System.Drawing.Point(341, 151);
            this.BtnNovoProfessor.Name = "BtnNovoProfessor";
            this.BtnNovoProfessor.Size = new System.Drawing.Size(99, 23);
            this.BtnNovoProfessor.TabIndex = 8;
            this.BtnNovoProfessor.Text = "Novo Professor";
            this.BtnNovoProfessor.UseVisualStyleBackColor = true;
            this.BtnNovoProfessor.Click += new System.EventHandler(this.BtnNovoProfessor_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Location = new System.Drawing.Point(460, 151);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(99, 23);
            this.BtnDeletar.TabIndex = 9;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // LbxCadastrados
            // 
            this.LbxCadastrados.FormattingEnabled = true;
            this.LbxCadastrados.ItemHeight = 15;
            this.LbxCadastrados.Location = new System.Drawing.Point(341, 27);
            this.LbxCadastrados.Name = "LbxCadastrados";
            this.LbxCadastrados.Size = new System.Drawing.Size(306, 94);
            this.LbxCadastrados.TabIndex = 7;
            this.LbxCadastrados.SelectedIndexChanged += new System.EventHandler(this.LbxCadastrados_SelectedIndexChanged);
            // 
            // CmbTurno
            // 
            this.CmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTurno.FormattingEnabled = true;
            this.CmbTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.CmbTurno.Location = new System.Drawing.Point(183, 98);
            this.CmbTurno.Name = "CmbTurno";
            this.CmbTurno.Size = new System.Drawing.Size(121, 23);
            this.CmbTurno.TabIndex = 4;
            // 
            // FrmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 212);
            this.Controls.Add(this.CmbTurno);
            this.Controls.Add(this.BtnNovoProfessor);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.LbxCadastrados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblCPF);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnCadastrarProfessor);
            this.Controls.Add(this.MskTelefone);
            this.Controls.Add(this.MskCPF);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblTelefone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProfessor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProfessor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCadastrarProfessor;
        private System.Windows.Forms.MaskedTextBox MskTelefone;
        private System.Windows.Forms.MaskedTextBox MskCPF;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnNovoProfessor;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.ListBox LbxCadastrados;
        private System.Windows.Forms.ComboBox CmbTurno;
    }
}