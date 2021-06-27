
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio_1));
            this.BntVoltar = new System.Windows.Forms.Button();
            this.ltbQuestoes = new System.Windows.Forms.ListBox();
            this.BtnComecar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BntVoltar
            // 
            this.BntVoltar.BackColor = System.Drawing.Color.White;
            this.BntVoltar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BntVoltar.Location = new System.Drawing.Point(22, 308);
            this.BntVoltar.Name = "BntVoltar";
            this.BntVoltar.Size = new System.Drawing.Size(110, 30);
            this.BntVoltar.TabIndex = 0;
            this.BntVoltar.Text = "Voltar";
            this.BntVoltar.UseVisualStyleBackColor = false;
            this.BntVoltar.Click += new System.EventHandler(this.BntVoltar_Click);
            // 
            // ltbQuestoes
            // 
            this.ltbQuestoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.ltbQuestoes.Location = new System.Drawing.Point(22, 24);
            this.ltbQuestoes.Name = "ltbQuestoes";
            this.ltbQuestoes.Size = new System.Drawing.Size(110, 220);
            this.ltbQuestoes.TabIndex = 1;
            // 
            // BtnComecar
            // 
            this.BtnComecar.BackColor = System.Drawing.Color.White;
            this.BtnComecar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnComecar.Location = new System.Drawing.Point(22, 262);
            this.BtnComecar.Name = "BtnComecar";
            this.BtnComecar.Size = new System.Drawing.Size(110, 29);
            this.BtnComecar.TabIndex = 2;
            this.BtnComecar.Text = "Começar";
            this.BtnComecar.UseVisualStyleBackColor = false;
            this.BtnComecar.Click += new System.EventHandler(this.BtnComecar_Click);
            // 
            // Exercicio_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(155, 366);
            this.Controls.Add(this.BtnComecar);
            this.Controls.Add(this.ltbQuestoes);
            this.Controls.Add(this.BntVoltar);
            this.Name = "Exercicio_1";
            this.Text = "Exercicio_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BntVoltar;
        private System.Windows.Forms.ListBox ltbQuestoes;
        private System.Windows.Forms.Button BtnComecar;
    }
}