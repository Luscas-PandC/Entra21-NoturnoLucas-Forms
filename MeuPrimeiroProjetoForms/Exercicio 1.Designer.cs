
namespace MeuPrimeiroProjetoForms
{
    partial class Exercicio_1
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
            this.BntVoltar = new System.Windows.Forms.Button();
            this.ltbQuestoes = new System.Windows.Forms.ListBox();
            this.BtnComecar = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BntVoltar
            // 
            this.BntVoltar.BackColor = System.Drawing.Color.White;
            this.BntVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntVoltar.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BntVoltar.Location = new System.Drawing.Point(50, 532);
            this.BntVoltar.Name = "BntVoltar";
            this.BntVoltar.Size = new System.Drawing.Size(267, 55);
            this.BntVoltar.TabIndex = 0;
            this.BntVoltar.Text = "Voltar";
            this.BntVoltar.UseVisualStyleBackColor = false;
            this.BntVoltar.Click += new System.EventHandler(this.BntVoltar_Click);
            // 
            // ltbQuestoes
            // 
            this.ltbQuestoes.BackColor = System.Drawing.Color.Black;
            this.ltbQuestoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltbQuestoes.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ltbQuestoes.ForeColor = System.Drawing.Color.White;
            this.ltbQuestoes.FormattingEnabled = true;
            this.ltbQuestoes.ItemHeight = 37;
            this.ltbQuestoes.Items.AddRange(new object[] {
            "Questão 1",
            "Questão 2",
            "Questão 3",
            "Questão 4",
            "Questão 5",
            "Questão 6",
            "Questão 7",
            "Questão 8",
            "Questão 9",
            "Questão 10"});
            this.ltbQuestoes.Location = new System.Drawing.Point(120, 65);
            this.ltbQuestoes.Name = "ltbQuestoes";
            this.ltbQuestoes.Size = new System.Drawing.Size(154, 370);
            this.ltbQuestoes.TabIndex = 1;
            // 
            // BtnComecar
            // 
            this.BtnComecar.BackColor = System.Drawing.Color.White;
            this.BtnComecar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnComecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComecar.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnComecar.Location = new System.Drawing.Point(50, 453);
            this.BtnComecar.Name = "BtnComecar";
            this.BtnComecar.Size = new System.Drawing.Size(267, 54);
            this.BtnComecar.TabIndex = 2;
            this.BtnComecar.Text = "Começar";
            this.BtnComecar.UseVisualStyleBackColor = false;
            this.BtnComecar.Click += new System.EventHandler(this.BtnComecar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(120, 13);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(123, 44);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "Nível 1";
            // 
            // Exercicio_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(380, 628);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnComecar);
            this.Controls.Add(this.ltbQuestoes);
            this.Controls.Add(this.BntVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercicio_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BntVoltar;
        private System.Windows.Forms.ListBox ltbQuestoes;
        private System.Windows.Forms.Button BtnComecar;
        private System.Windows.Forms.Label LblTitulo;
    }
}