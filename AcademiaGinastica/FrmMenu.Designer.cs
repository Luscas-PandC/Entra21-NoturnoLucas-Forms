
namespace AcademiaGinastica
{
    partial class FrmMenu
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
            this.btnProfessores = new System.Windows.Forms.Button();
            this.BtnModalidade = new System.Windows.Forms.Button();
            this.BtnAlunos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfessores
            // 
            this.btnProfessores.Location = new System.Drawing.Point(36, 111);
            this.btnProfessores.Name = "btnProfessores";
            this.btnProfessores.Size = new System.Drawing.Size(101, 40);
            this.btnProfessores.TabIndex = 0;
            this.btnProfessores.Text = "Professores";
            this.btnProfessores.UseVisualStyleBackColor = true;
            this.btnProfessores.Click += new System.EventHandler(this.btnProfessores_Click);
            // 
            // BtnModalidade
            // 
            this.BtnModalidade.Location = new System.Drawing.Point(189, 111);
            this.BtnModalidade.Name = "BtnModalidade";
            this.BtnModalidade.Size = new System.Drawing.Size(114, 40);
            this.BtnModalidade.TabIndex = 1;
            this.BtnModalidade.Text = "Modalidade";
            this.BtnModalidade.UseVisualStyleBackColor = true;
            this.BtnModalidade.Click += new System.EventHandler(this.BtnModalidade_Click);
            // 
            // BtnAlunos
            // 
            this.BtnAlunos.Location = new System.Drawing.Point(357, 111);
            this.BtnAlunos.Name = "BtnAlunos";
            this.BtnAlunos.Size = new System.Drawing.Size(114, 40);
            this.BtnAlunos.TabIndex = 2;
            this.BtnAlunos.Text = "Alunos";
            this.BtnAlunos.UseVisualStyleBackColor = true;
            this.BtnAlunos.Click += new System.EventHandler(this.BtnAlunos_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 249);
            this.Controls.Add(this.BtnAlunos);
            this.Controls.Add(this.BtnModalidade);
            this.Controls.Add(this.btnProfessores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfessores;
        private System.Windows.Forms.Button BtnModalidade;
        private System.Windows.Forms.Button BtnAlunos;
    }
}