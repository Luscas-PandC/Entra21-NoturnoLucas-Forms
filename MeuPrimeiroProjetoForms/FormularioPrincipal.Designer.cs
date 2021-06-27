
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
            this.BntConfirmar_Escolha_Questoes = new System.Windows.Forms.Button();
            this.CnxEscolhaQuestao = new System.Windows.Forms.ComboBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BntConfirmar_Escolha_Questoes
            // 
            this.BntConfirmar_Escolha_Questoes.BackColor = System.Drawing.Color.White;
            this.BntConfirmar_Escolha_Questoes.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BntConfirmar_Escolha_Questoes.Location = new System.Drawing.Point(199, 199);
            this.BntConfirmar_Escolha_Questoes.Name = "BntConfirmar_Escolha_Questoes";
            this.BntConfirmar_Escolha_Questoes.Size = new System.Drawing.Size(109, 31);
            this.BntConfirmar_Escolha_Questoes.TabIndex = 0;
            this.BntConfirmar_Escolha_Questoes.Text = "Confirmar";
            this.BntConfirmar_Escolha_Questoes.UseVisualStyleBackColor = false;
            this.BntConfirmar_Escolha_Questoes.Click += new System.EventHandler(this.BntConfirmar_Escolha_Questoes_Click);
            // 
            // CnxEscolhaQuestao
            // 
            this.CnxEscolhaQuestao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CnxEscolhaQuestao.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CnxEscolhaQuestao.FormattingEnabled = true;
            this.CnxEscolhaQuestao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CnxEscolhaQuestao.Items.AddRange(new object[] {
            "Exercicio 1",
            "Exercicio 2",
            "Exercicio 3"});
            this.CnxEscolhaQuestao.Location = new System.Drawing.Point(19, 138);
            this.CnxEscolhaQuestao.Name = "CnxEscolhaQuestao";
            this.CnxEscolhaQuestao.Size = new System.Drawing.Size(289, 30);
            this.CnxEscolhaQuestao.TabIndex = 1;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(12, 43);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(296, 56);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "Selecione a lista de exercicio \r\nque desejas usar a seguir.";
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.White;
            this.BtnSair.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSair.Location = new System.Drawing.Point(19, 199);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(109, 31);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 259);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.CnxEscolhaQuestao);
            this.Controls.Add(this.BntConfirmar_Escolha_Questoes);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormularioPrincipal";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BntConfirmar_Escolha_Questoes;
        private System.Windows.Forms.ComboBox CnxEscolhaQuestao;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnSair;
    }
}

