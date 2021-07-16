
namespace AcademiaGinastica
{
    partial class FrmAluno
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
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCPF = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblMensalidade = new System.Windows.Forms.Label();
            this.LblTurma = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.MtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.MtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.LbxCadastrados = new System.Windows.Forms.ListBox();
            this.BtnCadastrarAluno = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnConfirmarPagamentos = new System.Windows.Forms.Button();
            this.BtnNovoAluno = new System.Windows.Forms.Button();
            this.LblModalidade = new System.Windows.Forms.Label();
            this.TxtMensalidade = new System.Windows.Forms.TextBox();
            this.CmbModalidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtProfessor = new System.Windows.Forms.TextBox();
            this.TxtTurno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(24, 21);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(40, 15);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome";
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Location = new System.Drawing.Point(24, 79);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(28, 15);
            this.LblCPF.TabIndex = 2;
            this.LblCPF.Text = "CPF";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(155, 79);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(52, 15);
            this.LblTelefone.TabIndex = 3;
            this.LblTelefone.Text = "Telefone";
            // 
            // LblMensalidade
            // 
            this.LblMensalidade.AutoSize = true;
            this.LblMensalidade.Location = new System.Drawing.Point(156, 208);
            this.LblMensalidade.Name = "LblMensalidade";
            this.LblMensalidade.Size = new System.Drawing.Size(74, 15);
            this.LblMensalidade.TabIndex = 5;
            this.LblMensalidade.Text = "Mensalidade";
            // 
            // LblTurma
            // 
            this.LblTurma.AutoSize = true;
            this.LblTurma.Location = new System.Drawing.Point(24, 209);
            this.LblTurma.Name = "LblTurma";
            this.LblTurma.Size = new System.Drawing.Size(39, 15);
            this.LblTurma.TabIndex = 4;
            this.LblTurma.Text = "Turno";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(24, 39);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(237, 23);
            this.TxtNome.TabIndex = 1;
            // 
            // MtbCPF
            // 
            this.MtbCPF.Location = new System.Drawing.Point(24, 97);
            this.MtbCPF.Mask = "000,000,000-00";
            this.MtbCPF.Name = "MtbCPF";
            this.MtbCPF.Size = new System.Drawing.Size(105, 23);
            this.MtbCPF.TabIndex = 3;
            // 
            // MtbTelefone
            // 
            this.MtbTelefone.Location = new System.Drawing.Point(156, 97);
            this.MtbTelefone.Mask = "(00) 00000-0000";
            this.MtbTelefone.Name = "MtbTelefone";
            this.MtbTelefone.Size = new System.Drawing.Size(105, 23);
            this.MtbTelefone.TabIndex = 4;
            // 
            // LbxCadastrados
            // 
            this.LbxCadastrados.FormattingEnabled = true;
            this.LbxCadastrados.ItemHeight = 15;
            this.LbxCadastrados.Location = new System.Drawing.Point(300, 39);
            this.LbxCadastrados.Name = "LbxCadastrados";
            this.LbxCadastrados.Size = new System.Drawing.Size(309, 154);
            this.LbxCadastrados.TabIndex = 9;
            this.LbxCadastrados.SelectedIndexChanged += new System.EventHandler(this.LbxCadastrados_SelectedIndexChanged);
            // 
            // BtnCadastrarAluno
            // 
            this.BtnCadastrarAluno.Location = new System.Drawing.Point(24, 278);
            this.BtnCadastrarAluno.Name = "BtnCadastrarAluno";
            this.BtnCadastrarAluno.Size = new System.Drawing.Size(105, 23);
            this.BtnCadastrarAluno.TabIndex = 7;
            this.BtnCadastrarAluno.Text = "Cadastrar Aluno";
            this.BtnCadastrarAluno.UseVisualStyleBackColor = true;
            this.BtnCadastrarAluno.Click += new System.EventHandler(this.BtnIncerir_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(156, 278);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(105, 23);
            this.BtnNovo.TabIndex = 8;
            this.BtnNovo.Text = "Novo Aluno";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Location = new System.Drawing.Point(405, 209);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(99, 23);
            this.BtnDeletar.TabIndex = 11;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnConfirmarPagamentos
            // 
            this.BtnConfirmarPagamentos.Location = new System.Drawing.Point(300, 244);
            this.BtnConfirmarPagamentos.Name = "BtnConfirmarPagamentos";
            this.BtnConfirmarPagamentos.Size = new System.Drawing.Size(204, 23);
            this.BtnConfirmarPagamentos.TabIndex = 12;
            this.BtnConfirmarPagamentos.Text = "Confirmar Pagamentos";
            this.BtnConfirmarPagamentos.UseVisualStyleBackColor = true;
            this.BtnConfirmarPagamentos.Click += new System.EventHandler(this.BtnConfirmarPagamentos_Click);
            // 
            // BtnNovoAluno
            // 
            this.BtnNovoAluno.Location = new System.Drawing.Point(300, 209);
            this.BtnNovoAluno.Name = "BtnNovoAluno";
            this.BtnNovoAluno.Size = new System.Drawing.Size(99, 23);
            this.BtnNovoAluno.TabIndex = 13;
            this.BtnNovoAluno.Text = "Novo Aluno";
            this.BtnNovoAluno.UseVisualStyleBackColor = true;
            this.BtnNovoAluno.Click += new System.EventHandler(this.BtnNovoAluno_Click);
            // 
            // LblModalidade
            // 
            this.LblModalidade.AutoSize = true;
            this.LblModalidade.Location = new System.Drawing.Point(24, 145);
            this.LblModalidade.Name = "LblModalidade";
            this.LblModalidade.Size = new System.Drawing.Size(70, 15);
            this.LblModalidade.TabIndex = 14;
            this.LblModalidade.Text = "Modalidade";
            // 
            // TxtMensalidade
            // 
            this.TxtMensalidade.Location = new System.Drawing.Point(155, 226);
            this.TxtMensalidade.Name = "TxtMensalidade";
            this.TxtMensalidade.ReadOnly = true;
            this.TxtMensalidade.Size = new System.Drawing.Size(106, 23);
            this.TxtMensalidade.TabIndex = 15;
            // 
            // CmbModalidade
            // 
            this.CmbModalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModalidade.FormattingEnabled = true;
            this.CmbModalidade.Location = new System.Drawing.Point(24, 163);
            this.CmbModalidade.Name = "CmbModalidade";
            this.CmbModalidade.Size = new System.Drawing.Size(105, 23);
            this.CmbModalidade.TabIndex = 16;
            this.CmbModalidade.SelectedIndexChanged += new System.EventHandler(this.CmbModalidade_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Professor";
            // 
            // TxtProfessor
            // 
            this.TxtProfessor.Location = new System.Drawing.Point(156, 163);
            this.TxtProfessor.Name = "TxtProfessor";
            this.TxtProfessor.ReadOnly = true;
            this.TxtProfessor.Size = new System.Drawing.Size(105, 23);
            this.TxtProfessor.TabIndex = 18;
            // 
            // TxtTurno
            // 
            this.TxtTurno.Location = new System.Drawing.Point(24, 227);
            this.TxtTurno.Name = "TxtTurno";
            this.TxtTurno.ReadOnly = true;
            this.TxtTurno.Size = new System.Drawing.Size(105, 23);
            this.TxtTurno.TabIndex = 19;
            // 
            // FrmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 325);
            this.Controls.Add(this.TxtTurno);
            this.Controls.Add(this.TxtProfessor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbModalidade);
            this.Controls.Add(this.TxtMensalidade);
            this.Controls.Add(this.LblModalidade);
            this.Controls.Add(this.BtnNovoAluno);
            this.Controls.Add(this.BtnConfirmarPagamentos);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnCadastrarAluno);
            this.Controls.Add(this.LbxCadastrados);
            this.Controls.Add(this.MtbTelefone);
            this.Controls.Add(this.MtbCPF);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblMensalidade);
            this.Controls.Add(this.LblTurma);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblCPF);
            this.Controls.Add(this.LblNome);
            this.Name = "FrmAluno";
            this.Text = "Academia Ginastica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.Label LblMensalidade;
        private System.Windows.Forms.Label LblTurma;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.MaskedTextBox MtbCPF;
        private System.Windows.Forms.MaskedTextBox MtbTelefone;
        private System.Windows.Forms.ListBox LbxCadastrados;
        private System.Windows.Forms.Button BtnCadastrarAluno;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnConfirmarPagamentos;
        private System.Windows.Forms.Button BtnNovoAluno;
        private System.Windows.Forms.Label LblModalidade;
        private System.Windows.Forms.TextBox TxtMensalidade;
        private System.Windows.Forms.ComboBox CmbModalidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtProfessor;
        private System.Windows.Forms.TextBox TxtTurno;
    }
}

