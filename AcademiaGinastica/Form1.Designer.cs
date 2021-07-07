
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
            this.MtbMensalidade = new System.Windows.Forms.MaskedTextBox();
            this.CmbTurma = new System.Windows.Forms.ComboBox();
            this.CkbPago = new System.Windows.Forms.CheckBox();
            this.LbxCadastrados = new System.Windows.Forms.ListBox();
            this.BtnIncerir = new System.Windows.Forms.Button();
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
            this.label5.Location = new System.Drawing.Point(171, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mensalidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 135);
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
            this.MtbRG.Size = new System.Drawing.Size(100, 23);
            this.MtbRG.TabIndex = 9;
            // 
            // MtbMensalidade
            // 
            this.MtbMensalidade.Location = new System.Drawing.Point(171, 153);
            this.MtbMensalidade.Name = "MtbMensalidade";
            this.MtbMensalidade.Size = new System.Drawing.Size(100, 23);
            this.MtbMensalidade.TabIndex = 10;
            // 
            // CmbTurma
            // 
            this.CmbTurma.FormattingEnabled = true;
            this.CmbTurma.Location = new System.Drawing.Point(24, 153);
            this.CmbTurma.Name = "CmbTurma";
            this.CmbTurma.Size = new System.Drawing.Size(121, 23);
            this.CmbTurma.TabIndex = 11;
            // 
            // CkbPago
            // 
            this.CkbPago.AutoSize = true;
            this.CkbPago.Location = new System.Drawing.Point(277, 155);
            this.CkbPago.Name = "CkbPago";
            this.CkbPago.Size = new System.Drawing.Size(53, 19);
            this.CkbPago.TabIndex = 12;
            this.CkbPago.Text = "Pago";
            this.CkbPago.UseVisualStyleBackColor = true;
            // 
            // LbxCadastrados
            // 
            this.LbxCadastrados.FormattingEnabled = true;
            this.LbxCadastrados.ItemHeight = 15;
            this.LbxCadastrados.Location = new System.Drawing.Point(347, 21);
            this.LbxCadastrados.Name = "LbxCadastrados";
            this.LbxCadastrados.Size = new System.Drawing.Size(295, 154);
            this.LbxCadastrados.TabIndex = 13;
            // 
            // BtnIncerir
            // 
            this.BtnIncerir.Location = new System.Drawing.Point(347, 200);
            this.BtnIncerir.Name = "BtnIncerir";
            this.BtnIncerir.Size = new System.Drawing.Size(75, 23);
            this.BtnIncerir.TabIndex = 14;
            this.BtnIncerir.Text = "Incerir";
            this.BtnIncerir.UseVisualStyleBackColor = true;
            this.BtnIncerir.Click += new System.EventHandler(this.BtnIncerir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 308);
            this.Controls.Add(this.BtnIncerir);
            this.Controls.Add(this.LbxCadastrados);
            this.Controls.Add(this.CkbPago);
            this.Controls.Add(this.CmbTurma);
            this.Controls.Add(this.MtbMensalidade);
            this.Controls.Add(this.MtbRG);
            this.Controls.Add(this.MtbCPF);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.MaskedTextBox MtbMensalidade;
        private System.Windows.Forms.ComboBox CmbTurma;
        private System.Windows.Forms.CheckBox CkbPago;
        private System.Windows.Forms.ListBox LbxCadastrados;
        private System.Windows.Forms.Button BtnIncerir;
    }
}

