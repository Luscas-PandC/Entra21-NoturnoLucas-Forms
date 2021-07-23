
namespace AcademiaGinastica
{
    partial class FrmModalidade
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
            this.CmbProfessor = new System.Windows.Forms.ComboBox();
            this.CmbDiasSemanas = new System.Windows.Forms.ComboBox();
            this.LblProfessor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomeModalidade = new System.Windows.Forms.TextBox();
            this.BtnNovaModalidade = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.LbxCadastrados = new System.Windows.Forms.ListBox();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCadastrarModalidade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MskPrecoHora = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // CmbProfessor
            // 
            this.CmbProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProfessor.FormattingEnabled = true;
            this.CmbProfessor.Location = new System.Drawing.Point(23, 47);
            this.CmbProfessor.Name = "CmbProfessor";
            this.CmbProfessor.Size = new System.Drawing.Size(121, 23);
            this.CmbProfessor.TabIndex = 1;
            // 
            // CmbDiasSemanas
            // 
            this.CmbDiasSemanas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDiasSemanas.FormattingEnabled = true;
            this.CmbDiasSemanas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CmbDiasSemanas.Location = new System.Drawing.Point(170, 47);
            this.CmbDiasSemanas.Name = "CmbDiasSemanas";
            this.CmbDiasSemanas.Size = new System.Drawing.Size(121, 23);
            this.CmbDiasSemanas.TabIndex = 2;
            // 
            // LblProfessor
            // 
            this.LblProfessor.AutoSize = true;
            this.LblProfessor.Location = new System.Drawing.Point(23, 29);
            this.LblProfessor.Name = "LblProfessor";
            this.LblProfessor.Size = new System.Drawing.Size(56, 15);
            this.LblProfessor.TabIndex = 2;
            this.LblProfessor.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dias da Semana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome da Modalidade";
            // 
            // TxtNomeModalidade
            // 
            this.TxtNomeModalidade.Location = new System.Drawing.Point(23, 122);
            this.TxtNomeModalidade.Name = "TxtNomeModalidade";
            this.TxtNomeModalidade.Size = new System.Drawing.Size(121, 23);
            this.TxtNomeModalidade.TabIndex = 3;
            // 
            // BtnNovaModalidade
            // 
            this.BtnNovaModalidade.Location = new System.Drawing.Point(330, 180);
            this.BtnNovaModalidade.Name = "BtnNovaModalidade";
            this.BtnNovaModalidade.Size = new System.Drawing.Size(113, 23);
            this.BtnNovaModalidade.TabIndex = 8;
            this.BtnNovaModalidade.Text = "Nova Modalidade";
            this.BtnNovaModalidade.UseVisualStyleBackColor = true;
            this.BtnNovaModalidade.Click += new System.EventHandler(this.BtnNovaModalidade_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Location = new System.Drawing.Point(459, 180);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(113, 23);
            this.BtnDeletar.TabIndex = 9;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // LbxCadastrados
            // 
            this.LbxCadastrados.FormattingEnabled = true;
            this.LbxCadastrados.ItemHeight = 15;
            this.LbxCadastrados.Location = new System.Drawing.Point(330, 29);
            this.LbxCadastrados.Name = "LbxCadastrados";
            this.LbxCadastrados.Size = new System.Drawing.Size(309, 139);
            this.LbxCadastrados.TabIndex = 7;
            this.LbxCadastrados.SelectedIndexChanged += new System.EventHandler(this.LbxCadastrados_SelectedIndexChanged);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(170, 180);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(121, 23);
            this.BtnNovo.TabIndex = 6;
            this.BtnNovo.Text = "Nova Modalidade";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnCadastrarModalidade
            // 
            this.BtnCadastrarModalidade.Location = new System.Drawing.Point(23, 180);
            this.BtnCadastrarModalidade.Name = "BtnCadastrarModalidade";
            this.BtnCadastrarModalidade.Size = new System.Drawing.Size(121, 23);
            this.BtnCadastrarModalidade.TabIndex = 5;
            this.BtnCadastrarModalidade.Text = "Cadastrar Modalidade";
            this.BtnCadastrarModalidade.UseVisualStyleBackColor = true;
            this.BtnCadastrarModalidade.Click += new System.EventHandler(this.BtnCadastrarModalidade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Preço por Hora";
            // 
            // MskPrecoHora
            // 
            this.MskPrecoHora.Location = new System.Drawing.Point(170, 122);
            this.MskPrecoHora.Name = "MskPrecoHora";
            this.MskPrecoHora.Size = new System.Drawing.Size(121, 23);
            this.MskPrecoHora.TabIndex = 4;
            this.MskPrecoHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskPrecoHora_KeyPress);
            // 
            // FrmModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 224);
            this.Controls.Add(this.MskPrecoHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNovaModalidade);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.LbxCadastrados);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnCadastrarModalidade);
            this.Controls.Add(this.TxtNomeModalidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblProfessor);
            this.Controls.Add(this.CmbDiasSemanas);
            this.Controls.Add(this.CmbProfessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmModalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modalidade";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModalidade_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbProfessor;
        private System.Windows.Forms.ComboBox CmbDiasSemanas;
        private System.Windows.Forms.Label LblProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNomeModalidade;
        private System.Windows.Forms.Button BtnNovaModalidade;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.ListBox LbxCadastrados;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCadastrarModalidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskPrecoHora;
    }
}