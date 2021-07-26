
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
            this.LblProfessor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomeModalidade = new System.Windows.Forms.TextBox();
            this.BtnNovaModalidade = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.LbxCadastrados = new System.Windows.Forms.ListBox();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCadastrarModalidade = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbProfessor
            // 
            this.CmbProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProfessor.FormattingEnabled = true;
            this.CmbProfessor.Location = new System.Drawing.Point(19, 96);
            this.CmbProfessor.Name = "CmbProfessor";
            this.CmbProfessor.Size = new System.Drawing.Size(121, 23);
            this.CmbProfessor.TabIndex = 2;
            // 
            // LblProfessor
            // 
            this.LblProfessor.AutoSize = true;
            this.LblProfessor.Location = new System.Drawing.Point(19, 78);
            this.LblProfessor.Name = "LblProfessor";
            this.LblProfessor.Size = new System.Drawing.Size(56, 15);
            this.LblProfessor.TabIndex = 2;
            this.LblProfessor.Text = "Professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome da Modalidade";
            // 
            // TxtNomeModalidade
            // 
            this.TxtNomeModalidade.Location = new System.Drawing.Point(19, 35);
            this.TxtNomeModalidade.Name = "TxtNomeModalidade";
            this.TxtNomeModalidade.Size = new System.Drawing.Size(121, 23);
            this.TxtNomeModalidade.TabIndex = 1;
            // 
            // BtnNovaModalidade
            // 
            this.BtnNovaModalidade.Location = new System.Drawing.Point(179, 189);
            this.BtnNovaModalidade.Name = "BtnNovaModalidade";
            this.BtnNovaModalidade.Size = new System.Drawing.Size(113, 23);
            this.BtnNovaModalidade.TabIndex = 6;
            this.BtnNovaModalidade.Text = "Nova Modalidade";
            this.BtnNovaModalidade.UseVisualStyleBackColor = true;
            this.BtnNovaModalidade.Click += new System.EventHandler(this.BtnNovaModalidade_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Location = new System.Drawing.Point(298, 189);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(113, 23);
            this.BtnDeletar.TabIndex = 7;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // LbxCadastrados
            // 
            this.LbxCadastrados.FormattingEnabled = true;
            this.LbxCadastrados.ItemHeight = 15;
            this.LbxCadastrados.Location = new System.Drawing.Point(179, 35);
            this.LbxCadastrados.Name = "LbxCadastrados";
            this.LbxCadastrados.Size = new System.Drawing.Size(334, 139);
            this.LbxCadastrados.TabIndex = 5;
            this.LbxCadastrados.SelectedIndexChanged += new System.EventHandler(this.LbxCadastrados_SelectedIndexChanged);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(20, 189);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(121, 23);
            this.BtnNovo.TabIndex = 4;
            this.BtnNovo.Text = "Nova Modalidade";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnCadastrarModalidade
            // 
            this.BtnCadastrarModalidade.Location = new System.Drawing.Point(19, 148);
            this.BtnCadastrarModalidade.Name = "BtnCadastrarModalidade";
            this.BtnCadastrarModalidade.Size = new System.Drawing.Size(121, 23);
            this.BtnCadastrarModalidade.TabIndex = 3;
            this.BtnCadastrarModalidade.Text = "Cadastrar Modalidade";
            this.BtnCadastrarModalidade.UseVisualStyleBackColor = true;
            this.BtnCadastrarModalidade.Click += new System.EventHandler(this.BtnCadastrarModalidade_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.Red;
            this.BtnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVoltar.Location = new System.Drawing.Point(465, 189);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(48, 22);
            this.BtnVoltar.TabIndex = 51;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FrmModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 233);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnNovaModalidade);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.LbxCadastrados);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnCadastrarModalidade);
            this.Controls.Add(this.TxtNomeModalidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblProfessor);
            this.Controls.Add(this.CmbProfessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modalidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbProfessor;
        private System.Windows.Forms.Label LblProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNomeModalidade;
        private System.Windows.Forms.Button BtnNovaModalidade;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.ListBox LbxCadastrados;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCadastrarModalidade;
        private System.Windows.Forms.Button BtnVoltar;
    }
}