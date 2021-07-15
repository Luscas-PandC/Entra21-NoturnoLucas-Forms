
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
            this.SuspendLayout();
            // 
            // btnProfessores
            // 
            this.btnProfessores.Location = new System.Drawing.Point(93, 168);
            this.btnProfessores.Name = "btnProfessores";
            this.btnProfessores.Size = new System.Drawing.Size(75, 23);
            this.btnProfessores.TabIndex = 0;
            this.btnProfessores.Text = "Professores";
            this.btnProfessores.UseVisualStyleBackColor = true;
            this.btnProfessores.Click += new System.EventHandler(this.btnProfessores_Click);
            // 
            // BtnModalidade
            // 
            this.BtnModalidade.Location = new System.Drawing.Point(219, 168);
            this.BtnModalidade.Name = "BtnModalidade";
            this.BtnModalidade.Size = new System.Drawing.Size(88, 23);
            this.BtnModalidade.TabIndex = 1;
            this.BtnModalidade.Text = "Modalidade";
            this.BtnModalidade.UseVisualStyleBackColor = true;
            this.BtnModalidade.Click += new System.EventHandler(this.BtnModalidade_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnModalidade);
            this.Controls.Add(this.btnProfessores);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfessores;
        private System.Windows.Forms.Button BtnModalidade;
    }
}