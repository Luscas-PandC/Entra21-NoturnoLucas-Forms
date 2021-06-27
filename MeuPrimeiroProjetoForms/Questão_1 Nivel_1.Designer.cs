
namespace MeuPrimeiroProjetoForms
{
    partial class Questão_1_Nivel_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questão_1_Nivel_1));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.TxtQuantidade_Minima = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.TxtQuantidade_Maxima = new System.Windows.Forms.TextBox();
            this.LblQuantidade_Minima = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblQuantidade_Maxima = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(291, 56);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "                Calculadora\r\nEstoque médio de uma peça.";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.White;
            this.BtnCalcular.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCalcular.Location = new System.Drawing.Point(85, 288);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(93, 31);
            this.BtnCalcular.TabIndex = 1;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.White;
            this.BtnVoltar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVoltar.Location = new System.Drawing.Point(198, 288);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(93, 31);
            this.BtnVoltar.TabIndex = 2;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // TxtQuantidade_Minima
            // 
            this.TxtQuantidade_Minima.BackColor = System.Drawing.Color.White;
            this.TxtQuantidade_Minima.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtQuantidade_Minima.ForeColor = System.Drawing.Color.Black;
            this.TxtQuantidade_Minima.Location = new System.Drawing.Point(174, 103);
            this.TxtQuantidade_Minima.Name = "TxtQuantidade_Minima";
            this.TxtQuantidade_Minima.Size = new System.Drawing.Size(117, 29);
            this.TxtQuantidade_Minima.TabIndex = 3;
            // 
            // TxtResultado
            // 
            this.TxtResultado.BackColor = System.Drawing.Color.White;
            this.TxtResultado.Enabled = false;
            this.TxtResultado.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtResultado.ForeColor = System.Drawing.Color.Black;
            this.TxtResultado.Location = new System.Drawing.Point(174, 215);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(117, 29);
            this.TxtResultado.TabIndex = 4;
            this.TxtResultado.WordWrap = false;
            // 
            // TxtQuantidade_Maxima
            // 
            this.TxtQuantidade_Maxima.BackColor = System.Drawing.Color.White;
            this.TxtQuantidade_Maxima.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtQuantidade_Maxima.ForeColor = System.Drawing.Color.Black;
            this.TxtQuantidade_Maxima.Location = new System.Drawing.Point(174, 155);
            this.TxtQuantidade_Maxima.Name = "TxtQuantidade_Maxima";
            this.TxtQuantidade_Maxima.Size = new System.Drawing.Size(117, 29);
            this.TxtQuantidade_Maxima.TabIndex = 5;
            // 
            // LblQuantidade_Minima
            // 
            this.LblQuantidade_Minima.AutoSize = true;
            this.LblQuantidade_Minima.BackColor = System.Drawing.Color.Transparent;
            this.LblQuantidade_Minima.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblQuantidade_Minima.ForeColor = System.Drawing.Color.White;
            this.LblQuantidade_Minima.Location = new System.Drawing.Point(12, 103);
            this.LblQuantidade_Minima.Name = "LblQuantidade_Minima";
            this.LblQuantidade_Minima.Size = new System.Drawing.Size(153, 22);
            this.LblQuantidade_Minima.TabIndex = 6;
            this.LblQuantidade_Minima.Text = "Quantidade Minima:";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.BackColor = System.Drawing.Color.Transparent;
            this.LblResultado.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResultado.ForeColor = System.Drawing.Color.White;
            this.LblResultado.Location = new System.Drawing.Point(85, 215);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(80, 22);
            this.LblResultado.TabIndex = 7;
            this.LblResultado.Text = "Resultado:";
            // 
            // LblQuantidade_Maxima
            // 
            this.LblQuantidade_Maxima.AutoSize = true;
            this.LblQuantidade_Maxima.BackColor = System.Drawing.Color.Transparent;
            this.LblQuantidade_Maxima.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblQuantidade_Maxima.ForeColor = System.Drawing.Color.White;
            this.LblQuantidade_Maxima.Location = new System.Drawing.Point(12, 155);
            this.LblQuantidade_Maxima.Name = "LblQuantidade_Maxima";
            this.LblQuantidade_Maxima.Size = new System.Drawing.Size(156, 22);
            this.LblQuantidade_Maxima.TabIndex = 8;
            this.LblQuantidade_Maxima.Text = "Quantidade Máxima:";
            // 
            // Questão_1_Nivel_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(318, 351);
            this.Controls.Add(this.LblQuantidade_Maxima);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblQuantidade_Minima);
            this.Controls.Add(this.TxtQuantidade_Maxima);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtQuantidade_Minima);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblTitulo);
            this.Name = "Questão_1_Nivel_1";
            this.Text = "Questão 1 - Nivel 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.TextBox TxtQuantidade_Minima;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.TextBox TxtQuantidade_Maxima;
        private System.Windows.Forms.Label LblQuantidade_Minima;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblQuantidade_Maxima;
    }
}