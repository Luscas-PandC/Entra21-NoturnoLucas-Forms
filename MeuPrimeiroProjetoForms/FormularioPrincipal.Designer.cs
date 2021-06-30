
namespace MeuPrimeiroProjetoForms
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.BtnLista2 = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLista3 = new System.Windows.Forms.Button();
            this.BtnLista1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLista2
            // 
            this.BtnLista2.AutoSize = true;
            this.BtnLista2.BackColor = System.Drawing.Color.White;
            this.BtnLista2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLista2.Location = new System.Drawing.Point(103, 280);
            this.BtnLista2.Name = "BtnLista2";
            this.BtnLista2.Size = new System.Drawing.Size(563, 49);
            this.BtnLista2.TabIndex = 0;
            this.BtnLista2.Text = "Lista de Exercicio 2";
            this.BtnLista2.UseVisualStyleBackColor = false;
            this.BtnLista2.Click += new System.EventHandler(this.BtnLista2_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(27, 73);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(739, 39);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "Selecione a lista de exercicio que desejas usar a seguir.";
            // 
            // BtnSair
            // 
            this.BtnSair.AutoSize = true;
            this.BtnSair.BackColor = System.Drawing.Color.White;
            this.BtnSair.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSair.Location = new System.Drawing.Point(263, 477);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(235, 49);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLista3
            // 
            this.BtnLista3.AutoSize = true;
            this.BtnLista3.BackColor = System.Drawing.Color.White;
            this.BtnLista3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLista3.Location = new System.Drawing.Point(103, 377);
            this.BtnLista3.Name = "BtnLista3";
            this.BtnLista3.Size = new System.Drawing.Size(563, 49);
            this.BtnLista3.TabIndex = 5;
            this.BtnLista3.Text = "Lista de Exercicio 3";
            this.BtnLista3.UseVisualStyleBackColor = false;
            this.BtnLista3.Click += new System.EventHandler(this.BtnLista3_Click);
            // 
            // BtnLista1
            // 
            this.BtnLista1.AutoSize = true;
            this.BtnLista1.BackColor = System.Drawing.Color.White;
            this.BtnLista1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLista1.Location = new System.Drawing.Point(103, 199);
            this.BtnLista1.Name = "BtnLista1";
            this.BtnLista1.Size = new System.Drawing.Size(563, 49);
            this.BtnLista1.TabIndex = 6;
            this.BtnLista1.Text = "Lista de Exercicio 1";
            this.BtnLista1.UseVisualStyleBackColor = false;
            this.BtnLista1.Click += new System.EventHandler(this.BtnLista1_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(778, 628);
            this.Controls.Add(this.BtnLista1);
            this.Controls.Add(this.BtnLista3);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnLista2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioPrincipal";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLista2;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLista3;
        private System.Windows.Forms.Button BtnLista1;
    }
}

