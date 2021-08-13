
namespace AcademiaEF6
{
    partial class FormModalidade
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeModalidade = new System.Windows.Forms.TextBox();
            this.txtVezesSemana = new System.Windows.Forms.TextBox();
            this.txtPrecoHora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxProfessor = new System.Windows.Forms.ComboBox();
            this.btnSalvarMo = new System.Windows.Forms.Button();
            this.BtnCancelarMo = new System.Windows.Forms.Button();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome";
            // 
            // txtNomeModalidade
            // 
            this.txtNomeModalidade.Location = new System.Drawing.Point(12, 31);
            this.txtNomeModalidade.Name = "txtNomeModalidade";
            this.txtNomeModalidade.Size = new System.Drawing.Size(100, 20);
            this.txtNomeModalidade.TabIndex = 11;
            // 
            // txtVezesSemana
            // 
            this.txtVezesSemana.Location = new System.Drawing.Point(130, 30);
            this.txtVezesSemana.Name = "txtVezesSemana";
            this.txtVezesSemana.Size = new System.Drawing.Size(105, 20);
            this.txtVezesSemana.TabIndex = 10;
            // 
            // txtPrecoHora
            // 
            this.txtPrecoHora.Location = new System.Drawing.Point(12, 86);
            this.txtPrecoHora.Name = "txtPrecoHora";
            this.txtPrecoHora.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoHora.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vezes por Semana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Preço por Hora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Professor";
            // 
            // cbxProfessor
            // 
            this.cbxProfessor.DataSource = this.professorBindingSource;
            this.cbxProfessor.FormattingEnabled = true;
            this.cbxProfessor.Location = new System.Drawing.Point(130, 85);
            this.cbxProfessor.Name = "cbxProfessor";
            this.cbxProfessor.Size = new System.Drawing.Size(105, 21);
            this.cbxProfessor.TabIndex = 17;
            // 
            // btnSalvarMo
            // 
            this.btnSalvarMo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvarMo.Location = new System.Drawing.Point(160, 128);
            this.btnSalvarMo.Name = "btnSalvarMo";
            this.btnSalvarMo.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarMo.TabIndex = 18;
            this.btnSalvarMo.Text = "Salvar";
            this.btnSalvarMo.UseVisualStyleBackColor = true;
            // 
            // BtnCancelarMo
            // 
            this.BtnCancelarMo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarMo.Location = new System.Drawing.Point(79, 128);
            this.BtnCancelarMo.Name = "BtnCancelarMo";
            this.BtnCancelarMo.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarMo.TabIndex = 18;
            this.BtnCancelarMo.Text = "Cancelar";
            this.BtnCancelarMo.UseVisualStyleBackColor = true;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(AcademiaEF6.Dominio.Professor);
            // 
            // FormModalidade
            // 
            this.ClientSize = new System.Drawing.Size(247, 173);
            this.Controls.Add(this.BtnCancelarMo);
            this.Controls.Add(this.btnSalvarMo);
            this.Controls.Add(this.cbxProfessor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecoHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeModalidade);
            this.Controls.Add(this.txtVezesSemana);
            this.Name = "FormModalidade";
            this.Load += new System.EventHandler(this.FormModalidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalarioHora;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeModalidade;
        private System.Windows.Forms.TextBox txtVezesSemana;
        private System.Windows.Forms.TextBox txtPrecoHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxProfessor;
        private System.Windows.Forms.Button btnSalvarMo;
        private System.Windows.Forms.Button BtnCancelarMo;
        private System.Windows.Forms.BindingSource professorBindingSource;
    }
}