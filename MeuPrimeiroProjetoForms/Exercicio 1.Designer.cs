
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
            this.bntVoltar = new System.Windows.Forms.Button();
            this.ltbQuestoes = new System.Windows.Forms.ListBox();
            this.btnComecar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntVoltar
            // 
            this.bntVoltar.Location = new System.Drawing.Point(12, 280);
            this.bntVoltar.Name = "bntVoltar";
            this.bntVoltar.Size = new System.Drawing.Size(110, 23);
            this.bntVoltar.TabIndex = 0;
            this.bntVoltar.Text = "Voltar";
            this.bntVoltar.UseVisualStyleBackColor = true;
            this.bntVoltar.Click += new System.EventHandler(this.bntVoltar_Click);
            // 
            // ltbQuestoes
            // 
            this.ltbQuestoes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltbQuestoes.FormattingEnabled = true;
            this.ltbQuestoes.ItemHeight = 22;
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
            this.ltbQuestoes.Location = new System.Drawing.Point(12, 12);
            this.ltbQuestoes.Name = "ltbQuestoes";
            this.ltbQuestoes.Size = new System.Drawing.Size(110, 224);
            this.ltbQuestoes.TabIndex = 1;
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(12, 251);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(110, 23);
            this.btnComecar.TabIndex = 2;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // Exercicio_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 318);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.ltbQuestoes);
            this.Controls.Add(this.bntVoltar);
            this.Name = "Exercicio_1";
            this.Text = "Exercicio_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntVoltar;
        private System.Windows.Forms.ListBox ltbQuestoes;
        private System.Windows.Forms.Button btnComecar;
    }
}