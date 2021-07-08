
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "RG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mensalidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Turma";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(24, 39);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 23);
            this.TxtNome.TabIndex = 7;
            // 
            // MtbCPF
            // 
            this.MtbCPF.Location = new System.Drawing.Point(24, 97);
            this.MtbCPF.Name = "MtbCPF";
            this.MtbCPF.Size = new System.Drawing.Size(100, 23);
            this.MtbCPF.TabIndex = 8;
            // 
            // MtbRG
            // 
            this.MtbRG.Location = new System.Drawing.Point(155, 97);
            this.MtbRG.Name = "MtbRG";
            this.MtbRG.Size = new System.Drawing.Size(121, 23);
            this.MtbRG.TabIndex = 9;
            // 
            // CmbTurma
            // 
            this.CmbTurma.FormattingEnabled = true;
            this.CmbTurma.Location = new System.Drawing.Point(155, 39);
            this.CmbTurma.Name = "CmbTurma";
            this.CmbTurma.Size = new System.Drawing.Size(121, 23);
            this.CmbTurma.TabIndex = 11;
            // 
            // LbxCadastrados
            // 
            this.LbxCadastrados.FormattingEnabled = true;
            this.LbxCadastrados.ItemHeight = 15;
            this.LbxCadastrados.Location = new System.Drawing.Point(362, 21);
            this.LbxCadastrados.Name = "LbxCadastrados";
            this.LbxCadastrados.Size = new System.Drawing.Size(306, 154);
            this.LbxCadastrados.TabIndex = 13;
            // 
            // BtnIncerir
            // 
            this.BtnIncerir.Location = new System.Drawing.Point(24, 226);
            this.BtnIncerir.Name = "BtnIncerir";
            this.BtnIncerir.Size = new System.Drawing.Size(120, 23);
            this.BtnIncerir.TabIndex = 14;
            this.BtnIncerir.Text = "Cadastrar Usuario";
            this.BtnIncerir.UseVisualStyleBackColor = true;
            this.BtnIncerir.Click += new System.EventHandler(this.BtnIncerir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(362, 191);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(93, 23);
            this.BtnEditar.TabIndex = 16;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // RbtnBasic
            // 
            this.RbtnBasic.AutoSize = true;
            this.RbtnBasic.Location = new System.Drawing.Point(24, 170);
            this.RbtnBasic.Name = "RbtnBasic";
            this.RbtnBasic.Size = new System.Drawing.Size(86, 19);
            this.RbtnBasic.TabIndex = 17;
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
            this.RbtnAdvanced.TabIndex = 18;
            this.RbtnAdvanced.TabStop = true;
            this.RbtnAdvanced.Text = "Advanced R$169";
            this.RbtnAdvanced.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(155, 226);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(121, 23);
            this.BtnNovo.TabIndex = 20;
            this.BtnNovo.Text = "Novo Usuario";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Location = new System.Drawing.Point(461, 191);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(93, 23);
            this.BtnDeletar.TabIndex = 21;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnConfirmarPagamentos
            // 
            this.BtnConfirmarPagamentos.Location = new System.Drawing.Point(362, 233);
            this.BtnConfirmarPagamentos.Name = "BtnConfirmarPagamentos";
            this.BtnConfirmarPagamentos.Size = new System.Drawing.Size(144, 23);
            this.BtnConfirmarPagamentos.TabIndex = 22;
            this.BtnConfirmarPagamentos.Text = "Confirmar Pagamentos";
            this.BtnConfirmarPagamentos.UseVisualStyleBackColor = true;
            this.BtnConfirmarPagamentos.Click += new System.EventHandler(this.BtnConfirmarPagamentos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 268);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Academia Ginastica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
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
    }
}

