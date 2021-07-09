
namespace AcademiaGinastica
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
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCPF = new System.Windows.Forms.Label();
            this.LblRG = new System.Windows.Forms.Label();
            this.LblMensalidade = new System.Windows.Forms.Label();
            this.LblTurma = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.MtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.MtbRG = new System.Windows.Forms.MaskedTextBox();
            this.CmbTurma = new System.Windows.Forms.ComboBox();
            this.LbxCadastrados = new System.Windows.Forms.ListBox();
            this.BtnIncerir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.RbtnBasic = new System.Windows.Forms.RadioButton();
            this.RbtnAdvanced = new System.Windows.Forms.RadioButton();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnConfirmarPagamentos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // LblRG
            // 
            this.LblRG.AutoSize = true;
            this.LblRG.Location = new System.Drawing.Point(155, 79);
            this.LblRG.Name = "LblRG";
            this.LblRG.Size = new System.Drawing.Size(22, 15);
            this.LblRG.TabIndex = 3;
            this.LblRG.Text = "RG";
            // 
            // LblMensalidade
            // 
            this.LblMensalidade.AutoSize = true;
            this.LblMensalidade.Location = new System.Drawing.Point(24, 141);
            this.LblMensalidade.Name = "LblMensalidade";
            this.LblMensalidade.Size = new System.Drawing.Size(74, 15);
            this.LblMensalidade.TabIndex = 5;
            this.LblMensalidade.Text = "Mensalidade";
            // 
            // LblTurma
            // 
            this.LblTurma.AutoSize = true;
            this.LblTurma.Location = new System.Drawing.Point(155, 21);
            this.LblTurma.Name = "LblTurma";
            this.LblTurma.Size = new System.Drawing.Size(42, 15);
            this.LblTurma.TabIndex = 4;
            this.LblTurma.Text = "Turma";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(24, 39);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 23);
            this.TxtNome.TabIndex = 1;
            // 
            // MtbCPF
            // 
            this.MtbCPF.Location = new System.Drawing.Point(24, 97);
            this.MtbCPF.Mask = "000,000,000-00";
            this.MtbCPF.Name = "MtbCPF";
            this.MtbCPF.Size = new System.Drawing.Size(100, 23);
            this.MtbCPF.TabIndex = 3;
            // 
            // MtbRG
            // 
            this.MtbRG.Location = new System.Drawing.Point(155, 97);
            this.MtbRG.Mask = "0,000,000";
            this.MtbRG.Name = "MtbRG";
            this.MtbRG.Size = new System.Drawing.Size(121, 23);
            this.MtbRG.TabIndex = 4;
            // 
            // CmbTurma
            // 
            this.CmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTurma.FormattingEnabled = true;
            this.CmbTurma.Items.AddRange(new object[] {
            "Manha",
            "Tarde",
            "Noite"});
            this.CmbTurma.Location = new System.Drawing.Point(155, 39);
            this.CmbTurma.Name = "CmbTurma";
            this.CmbTurma.Size = new System.Drawing.Size(121, 23);
            this.CmbTurma.TabIndex = 2;
            // 
            // LbxCadastrados
            // 
            this.LbxCadastrados.FormattingEnabled = true;
            this.LbxCadastrados.ItemHeight = 15;
            this.LbxCadastrados.Location = new System.Drawing.Point(359, 21);
            this.LbxCadastrados.Name = "LbxCadastrados";
            this.LbxCadastrados.Size = new System.Drawing.Size(309, 154);
            this.LbxCadastrados.TabIndex = 9;
            this.LbxCadastrados.SelectedIndexChanged += new System.EventHandler(this.LbxCadastrados_SelectedIndexChanged);
            // 
            // BtnIncerir
            // 
            this.BtnIncerir.Location = new System.Drawing.Point(24, 226);
            this.BtnIncerir.Name = "BtnIncerir";
            this.BtnIncerir.Size = new System.Drawing.Size(120, 23);
            this.BtnIncerir.TabIndex = 7;
            this.BtnIncerir.Text = "Cadastrar Aluno";
            this.BtnIncerir.UseVisualStyleBackColor = true;
            this.BtnIncerir.Click += new System.EventHandler(this.BtnIncerir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(359, 191);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(99, 23);
            this.BtnEditar.TabIndex = 10;
            this.BtnEditar.Text = "Exibir";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // RbtnBasic
            // 
            this.RbtnBasic.AutoSize = true;
            this.RbtnBasic.Location = new System.Drawing.Point(24, 170);
            this.RbtnBasic.Name = "RbtnBasic";
            this.RbtnBasic.Size = new System.Drawing.Size(86, 19);
            this.RbtnBasic.TabIndex = 5;
            this.RbtnBasic.TabStop = true;
            this.RbtnBasic.Text = "Basic R$100";
            this.RbtnBasic.UseVisualStyleBackColor = true;
            // 
            // RbtnAdvanced
            // 
            this.RbtnAdvanced.AutoSize = true;
            this.RbtnAdvanced.Location = new System.Drawing.Point(155, 170);
            this.RbtnAdvanced.Name = "RbtnAdvanced";
            this.RbtnAdvanced.Size = new System.Drawing.Size(112, 19);
            this.RbtnAdvanced.TabIndex = 6;
            this.RbtnAdvanced.TabStop = true;
            this.RbtnAdvanced.Text = "Advanced R$169";
            this.RbtnAdvanced.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(155, 226);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(121, 23);
            this.BtnNovo.TabIndex = 8;
            this.BtnNovo.Text = "Novo Usuario";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Location = new System.Drawing.Point(569, 191);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(99, 23);
            this.BtnDeletar.TabIndex = 11;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnConfirmarPagamentos
            // 
            this.BtnConfirmarPagamentos.Location = new System.Drawing.Point(359, 226);
            this.BtnConfirmarPagamentos.Name = "BtnConfirmarPagamentos";
            this.BtnConfirmarPagamentos.Size = new System.Drawing.Size(144, 23);
            this.BtnConfirmarPagamentos.TabIndex = 12;
            this.BtnConfirmarPagamentos.Text = "Confirmar Pagamentos";
            this.BtnConfirmarPagamentos.UseVisualStyleBackColor = true;
            this.BtnConfirmarPagamentos.Click += new System.EventHandler(this.BtnConfirmarPagamentos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Novo Usuario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnConfirmarPagamentos);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.RbtnAdvanced);
            this.Controls.Add(this.RbtnBasic);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnIncerir);
            this.Controls.Add(this.LbxCadastrados);
            this.Controls.Add(this.CmbTurma);
            this.Controls.Add(this.MtbRG);
            this.Controls.Add(this.MtbCPF);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblMensalidade);
            this.Controls.Add(this.LblTurma);
            this.Controls.Add(this.LblRG);
            this.Controls.Add(this.LblCPF);
            this.Controls.Add(this.LblNome);
            this.Name = "Form1";
            this.Text = "Academia Ginastica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.Label LblRG;
        private System.Windows.Forms.Label LblMensalidade;
        private System.Windows.Forms.Label LblTurma;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.MaskedTextBox MtbCPF;
        private System.Windows.Forms.MaskedTextBox MtbRG;
        private System.Windows.Forms.ComboBox CmbTurma;
        private System.Windows.Forms.ListBox LbxCadastrados;
        private System.Windows.Forms.Button BtnIncerir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.RadioButton RbtnBasic;
        private System.Windows.Forms.RadioButton RbtnAdvanced;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnConfirmarPagamentos;
        private System.Windows.Forms.Button button1;
    }
}

