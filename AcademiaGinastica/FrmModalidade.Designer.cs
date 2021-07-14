
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomeModalidade = new System.Windows.Forms.TextBox();
            this.LblMensalidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbProfessor
            // 
            this.CmbProfessor.FormattingEnabled = true;
            this.CmbProfessor.Location = new System.Drawing.Point(92, 78);
            this.CmbProfessor.Name = "CmbProfessor";
            this.CmbProfessor.Size = new System.Drawing.Size(121, 23);
            this.CmbProfessor.TabIndex = 0;
            // 
            // CmbDiasSemanas
            // 
            this.CmbDiasSemanas.FormattingEnabled = true;
            this.CmbDiasSemanas.Location = new System.Drawing.Point(302, 78);
            this.CmbDiasSemanas.Name = "CmbDiasSemanas";
            this.CmbDiasSemanas.Size = new System.Drawing.Size(121, 23);
            this.CmbDiasSemanas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dias da Semana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome da Modalidade";
            // 
            // TxtNomeModalidade
            // 
            this.TxtNomeModalidade.Location = new System.Drawing.Point(92, 191);
            this.TxtNomeModalidade.Name = "TxtNomeModalidade";
            this.TxtNomeModalidade.Size = new System.Drawing.Size(100, 23);
            this.TxtNomeModalidade.TabIndex = 5;
            // 
            // LblMensalidade
            // 
            this.LblMensalidade.AutoSize = true;
            this.LblMensalidade.Location = new System.Drawing.Point(407, 186);
            this.LblMensalidade.Name = "LblMensalidade";
            this.LblMensalidade.Size = new System.Drawing.Size(80, 15);
            this.LblMensalidade.TabIndex = 8;
            this.LblMensalidade.Text = "Mensalidade: ";
            // 
            // FrmModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 283);
            this.Controls.Add(this.LblMensalidade);
            this.Controls.Add(this.TxtNomeModalidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbDiasSemanas);
            this.Controls.Add(this.CmbProfessor);
            this.Name = "FrmModalidade";
            this.Text = "Modalidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbProfessor;
        private System.Windows.Forms.ComboBox CmbDiasSemanas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNomeModalidade;
        private System.Windows.Forms.Label LblMensalidade;
    }
}