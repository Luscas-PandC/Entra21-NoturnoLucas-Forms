
namespace MeuPrimeiroProjetoForms
{
    partial class Exercicio_2
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
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.ltbQuestoes_Nivel2 = new System.Windows.Forms.ListBox();
            this.lblNivel2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblNivel3 = new System.Windows.Forms.Label();
            this.btnComeçar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVoltar.Location = new System.Drawing.Point(179, 550);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(201, 40);
            this.BtnVoltar.TabIndex = 0;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // ltbQuestoes_Nivel2
            // 
            this.ltbQuestoes_Nivel2.BackColor = System.Drawing.Color.Black;
            this.ltbQuestoes_Nivel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltbQuestoes_Nivel2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ltbQuestoes_Nivel2.ForeColor = System.Drawing.Color.White;
            this.ltbQuestoes_Nivel2.FormattingEnabled = true;
            this.ltbQuestoes_Nivel2.ItemHeight = 37;
            this.ltbQuestoes_Nivel2.Items.AddRange(new object[] {
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
            this.ltbQuestoes_Nivel2.Location = new System.Drawing.Point(86, 65);
            this.ltbQuestoes_Nivel2.Name = "ltbQuestoes_Nivel2";
            this.ltbQuestoes_Nivel2.Size = new System.Drawing.Size(147, 372);
            this.ltbQuestoes_Nivel2.TabIndex = 1;
            // 
            // lblNivel2
            // 
            this.lblNivel2.AutoSize = true;
            this.lblNivel2.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblNivel2.ForeColor = System.Drawing.Color.White;
            this.lblNivel2.Location = new System.Drawing.Point(104, 25);
            this.lblNivel2.Name = "lblNivel2";
            this.lblNivel2.Size = new System.Drawing.Size(107, 37);
            this.lblNivel2.TabIndex = 2;
            this.lblNivel2.Text = "Nivel 2";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Items.AddRange(new object[] {
            "Questão 1",
            "Questão 2",
            "Questão 3"});
            this.listBox1.Location = new System.Drawing.Point(329, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 372);
            this.listBox1.TabIndex = 3;
            // 
            // lblNivel3
            // 
            this.lblNivel3.AutoSize = true;
            this.lblNivel3.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblNivel3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNivel3.Location = new System.Drawing.Point(349, 25);
            this.lblNivel3.Name = "lblNivel3";
            this.lblNivel3.Size = new System.Drawing.Size(107, 37);
            this.lblNivel3.TabIndex = 4;
            this.lblNivel3.Text = "Nivel 3";
            // 
            // btnComeçar
            // 
            this.btnComeçar.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComeçar.Location = new System.Drawing.Point(179, 476);
            this.btnComeçar.Name = "btnComeçar";
            this.btnComeçar.Size = new System.Drawing.Size(201, 40);
            this.btnComeçar.TabIndex = 5;
            this.btnComeçar.Text = "Começar";
            this.btnComeçar.UseVisualStyleBackColor = true;
            // 
            // Exercicio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 617);
            this.Controls.Add(this.btnComeçar);
            this.Controls.Add(this.lblNivel3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblNivel2);
            this.Controls.Add(this.ltbQuestoes_Nivel2);
            this.Controls.Add(this.BtnVoltar);
            this.Name = "Exercicio_2";
            this.Text = "Exercicio_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.ListBox ltbQuestoes_Nivel2;
        private System.Windows.Forms.Label lblNivel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblNivel3;
        private System.Windows.Forms.Button btnComeçar;
    }
}