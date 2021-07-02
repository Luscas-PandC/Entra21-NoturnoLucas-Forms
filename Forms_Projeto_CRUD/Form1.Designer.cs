
namespace Forms_Projeto_CRUD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.LblAluno = new System.Windows.Forms.Label();
            this.TxtNome_Aluno = new System.Windows.Forms.TextBox();
            this.LtbMatricula_Aluno = new System.Windows.Forms.ListBox();
            this.DtpData_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.MTB_CPF_1Responsavel = new System.Windows.Forms.MaskedTextBox();
            this.lblData_Nascimento = new System.Windows.Forms.Label();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.CbxMatricula = new System.Windows.Forms.ComboBox();
            this.LblSexo = new System.Windows.Forms.Label();
            this.CbxGenero = new System.Windows.Forms.ComboBox();
            this.LblNome_1Responsavel = new System.Windows.Forms.Label();
            this.TxtNome_1Responsavel = new System.Windows.Forms.TextBox();
            this.LblCPF_1Responsavel = new System.Windows.Forms.Label();
            this.LblCPF_2Responsavel = new System.Windows.Forms.Label();
            this.TxtNome_2Responsavel = new System.Windows.Forms.TextBox();
            this.LblNome_2Responsavel = new System.Windows.Forms.Label();
            this.MTB_CPF_2Responsavel = new System.Windows.Forms.MaskedTextBox();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            resources.ApplyResources(this.BtnSalvar, "BtnSalvar");
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // LblAluno
            // 
            resources.ApplyResources(this.LblAluno, "LblAluno");
            this.LblAluno.BackColor = System.Drawing.Color.Transparent;
            this.LblAluno.ForeColor = System.Drawing.Color.White;
            this.LblAluno.Name = "LblAluno";
            // 
            // TxtNome_Aluno
            // 
            resources.ApplyResources(this.TxtNome_Aluno, "TxtNome_Aluno");
            this.TxtNome_Aluno.Name = "TxtNome_Aluno";
            this.TxtNome_Aluno.TextChanged += new System.EventHandler(this.TxtNome_Aluno_TextChanged);
            // 
            // LtbMatricula_Aluno
            // 
            resources.ApplyResources(this.LtbMatricula_Aluno, "LtbMatricula_Aluno");
            this.LtbMatricula_Aluno.FormattingEnabled = true;
            this.LtbMatricula_Aluno.Name = "LtbMatricula_Aluno";
            this.LtbMatricula_Aluno.SelectedIndexChanged += new System.EventHandler(this.LtbMatricula_Aluno_SelectedIndexChanged);
            // 
            // DtpData_Nascimento
            // 
            resources.ApplyResources(this.DtpData_Nascimento, "DtpData_Nascimento");
            this.DtpData_Nascimento.Name = "DtpData_Nascimento";
            // 
            // MTB_CPF_1Responsavel
            // 
            resources.ApplyResources(this.MTB_CPF_1Responsavel, "MTB_CPF_1Responsavel");
            this.MTB_CPF_1Responsavel.Name = "MTB_CPF_1Responsavel";
            // 
            // lblData_Nascimento
            // 
            resources.ApplyResources(this.lblData_Nascimento, "lblData_Nascimento");
            this.lblData_Nascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblData_Nascimento.ForeColor = System.Drawing.Color.White;
            this.lblData_Nascimento.Name = "lblData_Nascimento";
            // 
            // LblMatricula
            // 
            resources.ApplyResources(this.LblMatricula, "LblMatricula");
            this.LblMatricula.BackColor = System.Drawing.Color.Transparent;
            this.LblMatricula.ForeColor = System.Drawing.Color.White;
            this.LblMatricula.Name = "LblMatricula";
            // 
            // CbxMatricula
            // 
            this.CbxMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CbxMatricula, "CbxMatricula");
            this.CbxMatricula.FormattingEnabled = true;
            this.CbxMatricula.Items.AddRange(new object[] {
            resources.GetString("CbxMatricula.Items"),
            resources.GetString("CbxMatricula.Items1"),
            resources.GetString("CbxMatricula.Items2"),
            resources.GetString("CbxMatricula.Items3"),
            resources.GetString("CbxMatricula.Items4"),
            resources.GetString("CbxMatricula.Items5"),
            resources.GetString("CbxMatricula.Items6"),
            resources.GetString("CbxMatricula.Items7"),
            resources.GetString("CbxMatricula.Items8"),
            resources.GetString("CbxMatricula.Items9")});
            this.CbxMatricula.Name = "CbxMatricula";
            // 
            // LblSexo
            // 
            resources.ApplyResources(this.LblSexo, "LblSexo");
            this.LblSexo.BackColor = System.Drawing.Color.Transparent;
            this.LblSexo.ForeColor = System.Drawing.Color.White;
            this.LblSexo.Name = "LblSexo";
            // 
            // CbxGenero
            // 
            this.CbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CbxGenero, "CbxGenero");
            this.CbxGenero.FormattingEnabled = true;
            this.CbxGenero.Items.AddRange(new object[] {
            resources.GetString("CbxGenero.Items"),
            resources.GetString("CbxGenero.Items1"),
            resources.GetString("CbxGenero.Items2"),
            resources.GetString("CbxGenero.Items3")});
            this.CbxGenero.Name = "CbxGenero";
            // 
            // LblNome_1Responsavel
            // 
            resources.ApplyResources(this.LblNome_1Responsavel, "LblNome_1Responsavel");
            this.LblNome_1Responsavel.BackColor = System.Drawing.Color.Transparent;
            this.LblNome_1Responsavel.ForeColor = System.Drawing.Color.White;
            this.LblNome_1Responsavel.Name = "LblNome_1Responsavel";
            // 
            // TxtNome_1Responsavel
            // 
            resources.ApplyResources(this.TxtNome_1Responsavel, "TxtNome_1Responsavel");
            this.TxtNome_1Responsavel.Name = "TxtNome_1Responsavel";
            // 
            // LblCPF_1Responsavel
            // 
            resources.ApplyResources(this.LblCPF_1Responsavel, "LblCPF_1Responsavel");
            this.LblCPF_1Responsavel.BackColor = System.Drawing.Color.Transparent;
            this.LblCPF_1Responsavel.ForeColor = System.Drawing.Color.White;
            this.LblCPF_1Responsavel.Name = "LblCPF_1Responsavel";
            // 
            // LblCPF_2Responsavel
            // 
            resources.ApplyResources(this.LblCPF_2Responsavel, "LblCPF_2Responsavel");
            this.LblCPF_2Responsavel.BackColor = System.Drawing.Color.Transparent;
            this.LblCPF_2Responsavel.ForeColor = System.Drawing.Color.White;
            this.LblCPF_2Responsavel.Name = "LblCPF_2Responsavel";
            // 
            // TxtNome_2Responsavel
            // 
            resources.ApplyResources(this.TxtNome_2Responsavel, "TxtNome_2Responsavel");
            this.TxtNome_2Responsavel.Name = "TxtNome_2Responsavel";
            // 
            // LblNome_2Responsavel
            // 
            resources.ApplyResources(this.LblNome_2Responsavel, "LblNome_2Responsavel");
            this.LblNome_2Responsavel.BackColor = System.Drawing.Color.Transparent;
            this.LblNome_2Responsavel.ForeColor = System.Drawing.Color.White;
            this.LblNome_2Responsavel.Name = "LblNome_2Responsavel";
            // 
            // MTB_CPF_2Responsavel
            // 
            resources.ApplyResources(this.MTB_CPF_2Responsavel, "MTB_CPF_2Responsavel");
            this.MTB_CPF_2Responsavel.Name = "MTB_CPF_2Responsavel";
            // 
            // BtnDeletar
            // 
            resources.ApplyResources(this.BtnDeletar, "BtnDeletar");
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnNovo
            // 
            resources.ApplyResources(this.BtnNovo, "BtnNovo");
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.LblCPF_2Responsavel);
            this.Controls.Add(this.TxtNome_2Responsavel);
            this.Controls.Add(this.LblNome_2Responsavel);
            this.Controls.Add(this.MTB_CPF_2Responsavel);
            this.Controls.Add(this.LblCPF_1Responsavel);
            this.Controls.Add(this.TxtNome_1Responsavel);
            this.Controls.Add(this.LblNome_1Responsavel);
            this.Controls.Add(this.CbxGenero);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.CbxMatricula);
            this.Controls.Add(this.LblMatricula);
            this.Controls.Add(this.lblData_Nascimento);
            this.Controls.Add(this.MTB_CPF_1Responsavel);
            this.Controls.Add(this.DtpData_Nascimento);
            this.Controls.Add(this.LtbMatricula_Aluno);
            this.Controls.Add(this.TxtNome_Aluno);
            this.Controls.Add(this.LblAluno);
            this.Controls.Add(this.BtnSalvar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label LblAluno;
        private System.Windows.Forms.TextBox TxtNome_Aluno;
        private System.Windows.Forms.ListBox LtbMatricula_Aluno;
        private System.Windows.Forms.DateTimePicker DtpData_Nascimento;
        private System.Windows.Forms.MaskedTextBox MTB_CPF_1Responsavel;
        private System.Windows.Forms.Label lblData_Nascimento;
        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.ComboBox CbxMatricula;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.ComboBox CbxGenero;
        private System.Windows.Forms.Label LblNome_1Responsavel;
        private System.Windows.Forms.TextBox TxtNome_1Responsavel;
        private System.Windows.Forms.Label LblCPF_1Responsavel;
        private System.Windows.Forms.Label LblCPF_2Responsavel;
        private System.Windows.Forms.TextBox TxtNome_2Responsavel;
        private System.Windows.Forms.Label LblNome_2Responsavel;
        private System.Windows.Forms.MaskedTextBox MTB_CPF_2Responsavel;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnNovo;
    }
}

