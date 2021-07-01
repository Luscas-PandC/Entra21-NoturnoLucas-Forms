
namespace Forms_Projeto_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.LblAluno = new System.Windows.Forms.Label();
            this.TxtNome_Aluno = new System.Windows.Forms.TextBox();
            this.LtbMatricula_Aluno = new System.Windows.Forms.ListBox();
            this.DtpData_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.MTB_CPF_1Responsavel = new System.Windows.Forms.MaskedTextBox();
            this.lblData_Nascimento = new System.Windows.Forms.Label();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.CbxMatricula = new System.Windows.Forms.ComboBox();
            this.LblSexo = new System.Windows.Forms.Label();
            this.CbxGenero = new System.Windows.Forms.ComboBox();
            this.LblNome_1Responsavel = new System.Windows.Forms.Label();
            this.TxtNome_1Responsavel = new System.Windows.Forms.TextBox();
            this.LblCPF_1Responsavel = new System.Windows.Forms.Label();
            this.LblCPF_2Responsavel = new System.Windows.Forms.Label();
            this.TxtNome_2Responsavel = new System.Windows.Forms.TextBox();
            this.LblNome_2Responsavel = new System.Windows.Forms.Label();
            this.MTB_CPF_2Responsavel = new System.Windows.Forms.MaskedTextBox();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.Location = new System.Drawing.Point(408, 361);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // LblAluno
            // 
            this.LblAluno.AutoSize = true;
            this.LblAluno.Location = new System.Drawing.Point(12, 25);
            this.LblAluno.Name = "LblAluno";
            this.LblAluno.Size = new System.Drawing.Size(95, 15);
            this.LblAluno.TabIndex = 1;
            this.LblAluno.Text = "Nome do Aluno:";
            // 
            // TxtNome_Aluno
            // 
            this.TxtNome_Aluno.Location = new System.Drawing.Point(12, 43);
            this.TxtNome_Aluno.Name = "TxtNome_Aluno";
            this.TxtNome_Aluno.Size = new System.Drawing.Size(275, 23);
            this.TxtNome_Aluno.TabIndex = 2;
            // 
            // LtbMatricula_Aluno
            // 
            this.LtbMatricula_Aluno.FormattingEnabled = true;
            this.LtbMatricula_Aluno.ItemHeight = 15;
            this.LtbMatricula_Aluno.Location = new System.Drawing.Point(327, 25);
            this.LtbMatricula_Aluno.Name = "LtbMatricula_Aluno";
            this.LtbMatricula_Aluno.Size = new System.Drawing.Size(237, 319);
            this.LtbMatricula_Aluno.TabIndex = 3;
            this.LtbMatricula_Aluno.SelectedIndexChanged += new System.EventHandler(this.LtbMatricula_Aluno_SelectedIndexChanged);
            // 
            // DtpData_Nascimento
            // 
            this.DtpData_Nascimento.Location = new System.Drawing.Point(12, 112);
            this.DtpData_Nascimento.Name = "DtpData_Nascimento";
            this.DtpData_Nascimento.Size = new System.Drawing.Size(275, 23);
            this.DtpData_Nascimento.TabIndex = 4;
            // 
            // MTB_CPF_1Responsavel
            // 
            this.MTB_CPF_1Responsavel.Location = new System.Drawing.Point(208, 250);
            this.MTB_CPF_1Responsavel.Mask = "000,000,00-00";
            this.MTB_CPF_1Responsavel.Name = "MTB_CPF_1Responsavel";
            this.MTB_CPF_1Responsavel.Size = new System.Drawing.Size(79, 23);
            this.MTB_CPF_1Responsavel.TabIndex = 5;
            // 
            // lblData_Nascimento
            // 
            this.lblData_Nascimento.AutoSize = true;
            this.lblData_Nascimento.Location = new System.Drawing.Point(12, 84);
            this.lblData_Nascimento.Name = "lblData_Nascimento";
            this.lblData_Nascimento.Size = new System.Drawing.Size(115, 15);
            this.lblData_Nascimento.TabIndex = 6;
            this.lblData_Nascimento.Text = "Data de nascimento:";
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Location = new System.Drawing.Point(12, 161);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(60, 15);
            this.LblMatricula.TabIndex = 7;
            this.LblMatricula.Text = "Matrícula:";
            // 
            // CbxMatricula
            // 
            this.CbxMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMatricula.FormattingEnabled = true;
            this.CbxMatricula.Items.AddRange(new object[] {
            "Selecione",
            "1°Ano",
            "2°Ano",
            "3°Ano",
            "4°Ano",
            "5°Ano",
            "6°Ano",
            "7°Ano",
            "8°Ano",
            "9°Ano"});
            this.CbxMatricula.Location = new System.Drawing.Point(12, 179);
            this.CbxMatricula.Name = "CbxMatricula";
            this.CbxMatricula.Size = new System.Drawing.Size(131, 23);
            this.CbxMatricula.TabIndex = 8;
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(156, 161);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(48, 15);
            this.LblSexo.TabIndex = 9;
            this.LblSexo.Text = "Genero:";
            // 
            // CbxGenero
            // 
            this.CbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGenero.FormattingEnabled = true;
            this.CbxGenero.Items.AddRange(new object[] {
            "Selecione",
            "Masculino",
            "Femenino",
            "Outro"});
            this.CbxGenero.Location = new System.Drawing.Point(156, 179);
            this.CbxGenero.Name = "CbxGenero";
            this.CbxGenero.Size = new System.Drawing.Size(131, 23);
            this.CbxGenero.TabIndex = 10;
            // 
            // LblNome_1Responsavel
            // 
            this.LblNome_1Responsavel.AutoSize = true;
            this.LblNome_1Responsavel.Location = new System.Drawing.Point(12, 232);
            this.LblNome_1Responsavel.Name = "LblNome_1Responsavel";
            this.LblNome_1Responsavel.Size = new System.Drawing.Size(173, 15);
            this.LblNome_1Responsavel.TabIndex = 11;
            this.LblNome_1Responsavel.Text = "Nome do primeiro responsavel:";
            // 
            // TxtNome_1Responsavel
            // 
            this.TxtNome_1Responsavel.Location = new System.Drawing.Point(12, 250);
            this.TxtNome_1Responsavel.Name = "TxtNome_1Responsavel";
            this.TxtNome_1Responsavel.Size = new System.Drawing.Size(173, 23);
            this.TxtNome_1Responsavel.TabIndex = 12;
            // 
            // LblCPF_1Responsavel
            // 
            this.LblCPF_1Responsavel.AutoSize = true;
            this.LblCPF_1Responsavel.Location = new System.Drawing.Point(208, 232);
            this.LblCPF_1Responsavel.Name = "LblCPF_1Responsavel";
            this.LblCPF_1Responsavel.Size = new System.Drawing.Size(31, 15);
            this.LblCPF_1Responsavel.TabIndex = 13;
            this.LblCPF_1Responsavel.Text = "CPF:";
            // 
            // LblCPF_2Responsavel
            // 
            this.LblCPF_2Responsavel.AutoSize = true;
            this.LblCPF_2Responsavel.Location = new System.Drawing.Point(208, 296);
            this.LblCPF_2Responsavel.Name = "LblCPF_2Responsavel";
            this.LblCPF_2Responsavel.Size = new System.Drawing.Size(31, 15);
            this.LblCPF_2Responsavel.TabIndex = 17;
            this.LblCPF_2Responsavel.Text = "CPF:";
            // 
            // TxtNome_2Responsavel
            // 
            this.TxtNome_2Responsavel.Location = new System.Drawing.Point(12, 314);
            this.TxtNome_2Responsavel.Name = "TxtNome_2Responsavel";
            this.TxtNome_2Responsavel.Size = new System.Drawing.Size(173, 23);
            this.TxtNome_2Responsavel.TabIndex = 16;
            // 
            // LblNome_2Responsavel
            // 
            this.LblNome_2Responsavel.AutoSize = true;
            this.LblNome_2Responsavel.Location = new System.Drawing.Point(12, 296);
            this.LblNome_2Responsavel.Name = "LblNome_2Responsavel";
            this.LblNome_2Responsavel.Size = new System.Drawing.Size(174, 15);
            this.LblNome_2Responsavel.TabIndex = 15;
            this.LblNome_2Responsavel.Text = "Nome do segundo responsavel:";
            // 
            // MTB_CPF_2Responsavel
            // 
            this.MTB_CPF_2Responsavel.Location = new System.Drawing.Point(208, 314);
            this.MTB_CPF_2Responsavel.Mask = "000,000,000-00";
            this.MTB_CPF_2Responsavel.Name = "MTB_CPF_2Responsavel";
            this.MTB_CPF_2Responsavel.Size = new System.Drawing.Size(79, 23);
            this.MTB_CPF_2Responsavel.TabIndex = 14;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Enabled = false;
            this.BtnDeletar.Location = new System.Drawing.Point(489, 361);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(75, 23);
            this.BtnDeletar.TabIndex = 18;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(327, 361);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 19;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 399);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.LblCPF_2Responsavel);
            this.Controls.Add(this.TxtNome_2Responsavel);
            this.Controls.Add(this.LblNome_2Responsavel);
            this.Controls.Add(this.MTB_CPF_2Responsavel);
            this.Controls.Add(this.LblCPF_1Responsavel);
            this.Controls.Add(this.TxtNome_1Responsavel);
            this.Controls.Add(this.LblNome_1Responsavel);
            this.Controls.Add(this.CbxGenero);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.CbxMatricula);
            this.Controls.Add(this.LblMatricula);
            this.Controls.Add(this.lblData_Nascimento);
            this.Controls.Add(this.MTB_CPF_1Responsavel);
            this.Controls.Add(this.DtpData_Nascimento);
            this.Controls.Add(this.LtbMatricula_Aluno);
            this.Controls.Add(this.TxtNome_Aluno);
            this.Controls.Add(this.LblAluno);
            this.Controls.Add(this.BtnSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label LblAluno;
        private System.Windows.Forms.TextBox TxtNome_Aluno;
        private System.Windows.Forms.ListBox LtbMatricula_Aluno;
        private System.Windows.Forms.DateTimePicker DtpData_Nascimento;
        private System.Windows.Forms.MaskedTextBox MTB_CPF_1Responsavel;
        private System.Windows.Forms.Label lblData_Nascimento;
        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.ComboBox CbxMatricula;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.ComboBox CbxGenero;
        private System.Windows.Forms.Label LblNome_1Responsavel;
        private System.Windows.Forms.TextBox TxtNome_1Responsavel;
        private System.Windows.Forms.Label LblCPF_1Responsavel;
        private System.Windows.Forms.Label LblCPF_2Responsavel;
        private System.Windows.Forms.TextBox TxtNome_2Responsavel;
        private System.Windows.Forms.Label LblNome_2Responsavel;
        private System.Windows.Forms.MaskedTextBox MTB_CPF_2Responsavel;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnNovo;
    }
}

