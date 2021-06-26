
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
            this.bntConfirmar_Escolha_Questoes = new System.Windows.Forms.Button();
            this.cnxEscolhaQuestao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bntConfirmar_Escolha_Questoes
            // 
            this.bntConfirmar_Escolha_Questoes.Location = new System.Drawing.Point(344, 31);
            this.bntConfirmar_Escolha_Questoes.Name = "bntConfirmar_Escolha_Questoes";
            this.bntConfirmar_Escolha_Questoes.Size = new System.Drawing.Size(75, 23);
            this.bntConfirmar_Escolha_Questoes.TabIndex = 0;
            this.bntConfirmar_Escolha_Questoes.Text = "Confirmar";
            this.bntConfirmar_Escolha_Questoes.UseVisualStyleBackColor = true;
            this.bntConfirmar_Escolha_Questoes.Click += new System.EventHandler(this.bntConfirmar_Escolha_Questoes_Click);
            // 
            // cnxEscolhaQuestao
            // 
            this.cnxEscolhaQuestao.FormattingEnabled = true;
            this.cnxEscolhaQuestao.Items.AddRange(new object[] {
            "Exercicio 1",
            "Exercicio 2",
            "Exercicio 3"});
            this.cnxEscolhaQuestao.Location = new System.Drawing.Point(19, 31);
            this.cnxEscolhaQuestao.Name = "cnxEscolhaQuestao";
            this.cnxEscolhaQuestao.Size = new System.Drawing.Size(293, 23);
            this.cnxEscolhaQuestao.TabIndex = 1;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.cnxEscolhaQuestao);
            this.Controls.Add(this.bntConfirmar_Escolha_Questoes);
            this.Name = "FormularioPrincipal";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntConfirmar_Escolha_Questoes;
        private System.Windows.Forms.ComboBox cnxEscolhaQuestao;
    }
}

