
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio_2));
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
            this.BtnVoltar.Location = new System.Drawing.Point(102, 446);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(119, 30);
            this.BtnVoltar.TabIndex = 0;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // ltbQuestoes_Nivel2
            // 
            this.ltbQuestoes_Nivel2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltbQuestoes_Nivel2.FormattingEnabled = true;
            this.ltbQuestoes_Nivel2.ItemHeight = 28;
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
            "Questão 10",
            "Questão 11",
            "Questão 12"});
            this.ltbQuestoes_Nivel2.Location = new System.Drawing.Point(13, 43);
            this.ltbQuestoes_Nivel2.Name = "ltbQuestoes_Nivel2";
            this.ltbQuestoes_Nivel2.Size = new System.Drawing.Size(119, 340);
            this.ltbQuestoes_Nivel2.TabIndex = 1;
            // 
            // lblNivel2
            // 
            this.lblNivel2.AutoSize = true;
            this.lblNivel2.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblNivel2.ForeColor = System.Drawing.Color.White;
            this.lblNivel2.Location = new System.Drawing.Point(13, 13);
            this.lblNivel2.Name = "lblNivel2";
            this.lblNivel2.Size = new System.Drawing.Size(83, 28);
            this.lblNivel2.TabIndex = 2;
            this.lblNivel2.Text = "Nivel 2";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Items.AddRange(new object[] {
            "Questão 1",
            "Questão 2",
            "Questão 3"});
            this.listBox1.Location = new System.Drawing.Point(196, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(119, 340);
            this.listBox1.TabIndex = 3;
            // 
            // lblNivel3
            // 
            this.lblNivel3.AutoSize = true;
            this.lblNivel3.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblNivel3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNivel3.Location = new System.Drawing.Point(196, 13);
            this.lblNivel3.Name = "lblNivel3";
            this.lblNivel3.Size = new System.Drawing.Size(83, 28);
            this.lblNivel3.TabIndex = 4;
            this.lblNivel3.Text = "Nivel 3";
            // 
            // btnComeçar
            // 
            this.btnComeçar.Location = new System.Drawing.Point(102, 400);
            this.btnComeçar.Name = "btnComeçar";
            this.btnComeçar.Size = new System.Drawing.Size(119, 30);
            this.btnComeçar.TabIndex = 5;
            this.btnComeçar.Text = "Começar";
            this.btnComeçar.UseVisualStyleBackColor = true;
            // 
            // Exercicio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 488);
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