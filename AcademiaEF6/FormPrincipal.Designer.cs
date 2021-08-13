
namespace AcademiaEF6
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExcluirProfessor = new System.Windows.Forms.Button();
            this.btnNovoAluno = new System.Windows.Forms.Button();
            this.btnNovaModalidade = new System.Windows.Forms.Button();
            this.btnNovoProfessor = new System.Windows.Forms.Button();
            this.dgvProfessor = new System.Windows.Forms.DataGridView();
            this.dgvModalidade = new System.Windows.Forms.DataGridView();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnExcluirModalidade = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.modalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vezesSemanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirProfessor
            // 
            this.btnExcluirProfessor.Location = new System.Drawing.Point(293, 402);
            this.btnExcluirProfessor.Name = "btnExcluirProfessor";
            this.btnExcluirProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProfessor.TabIndex = 0;
            this.btnExcluirProfessor.Text = "Excluir";
            this.btnExcluirProfessor.UseVisualStyleBackColor = true;
            this.btnExcluirProfessor.Click += new System.EventHandler(this.btnExcluirProfessor_Click);
            // 
            // btnNovoAluno
            // 
            this.btnNovoAluno.Location = new System.Drawing.Point(872, 402);
            this.btnNovoAluno.Name = "btnNovoAluno";
            this.btnNovoAluno.Size = new System.Drawing.Size(75, 23);
            this.btnNovoAluno.TabIndex = 1;
            this.btnNovoAluno.Text = "Novo";
            this.btnNovoAluno.UseVisualStyleBackColor = true;
            // 
            // btnNovaModalidade
            // 
            this.btnNovaModalidade.Location = new System.Drawing.Point(413, 402);
            this.btnNovaModalidade.Name = "btnNovaModalidade";
            this.btnNovaModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnNovaModalidade.TabIndex = 2;
            this.btnNovaModalidade.Text = "Novo";
            this.btnNovaModalidade.UseVisualStyleBackColor = true;
            this.btnNovaModalidade.Click += new System.EventHandler(this.btnNovaModalidade_Click);
            // 
            // btnNovoProfessor
            // 
            this.btnNovoProfessor.Location = new System.Drawing.Point(9, 402);
            this.btnNovoProfessor.Name = "btnNovoProfessor";
            this.btnNovoProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnNovoProfessor.TabIndex = 3;
            this.btnNovoProfessor.Text = "Novo";
            this.btnNovoProfessor.UseVisualStyleBackColor = true;
            this.btnNovoProfessor.Click += new System.EventHandler(this.btnNovoProfessor_Click);
            // 
            // dgvProfessor
            // 
            this.dgvProfessor.AllowUserToAddRows = false;
            this.dgvProfessor.AllowUserToDeleteRows = false;
            this.dgvProfessor.AutoGenerateColumns = false;
            this.dgvProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.salarioHoraDataGridViewTextBoxColumn});
            this.dgvProfessor.DataSource = this.professorBindingSource;
            this.dgvProfessor.Location = new System.Drawing.Point(9, 34);
            this.dgvProfessor.Name = "dgvProfessor";
            this.dgvProfessor.ReadOnly = true;
            this.dgvProfessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfessor.Size = new System.Drawing.Size(359, 362);
            this.dgvProfessor.TabIndex = 4;
            // 
            // dgvModalidade
            // 
            this.dgvModalidade.AllowUserToAddRows = false;
            this.dgvModalidade.AllowUserToDeleteRows = false;
            this.dgvModalidade.AutoGenerateColumns = false;
            this.dgvModalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModalidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn1,
            this.vezesSemanaDataGridViewTextBoxColumn,
            this.precoHoraDataGridViewTextBoxColumn,
            this.professorDataGridViewTextBoxColumn});
            this.dgvModalidade.DataSource = this.modalidadeBindingSource;
            this.dgvModalidade.Location = new System.Drawing.Point(413, 34);
            this.dgvModalidade.Name = "dgvModalidade";
            this.dgvModalidade.ReadOnly = true;
            this.dgvModalidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModalidade.Size = new System.Drawing.Size(419, 362);
            this.dgvModalidade.TabIndex = 5;
            // 
            // dgvAluno
            // 
            this.dgvAluno.AutoGenerateColumns = false;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modalidadeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn2,
            this.telefoneDataGridViewTextBoxColumn});
            this.dgvAluno.DataSource = this.alunoBindingSource;
            this.dgvAluno.Location = new System.Drawing.Point(872, 34);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAluno.Size = new System.Drawing.Size(456, 362);
            this.dgvAluno.TabIndex = 6;
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Location = new System.Drawing.Point(1253, 402);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAluno.TabIndex = 10;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            // 
            // btnExcluirModalidade
            // 
            this.btnExcluirModalidade.Location = new System.Drawing.Point(757, 402);
            this.btnExcluirModalidade.Name = "btnExcluirModalidade";
            this.btnExcluirModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirModalidade.TabIndex = 11;
            this.btnExcluirModalidade.Text = "Excluir";
            this.btnExcluirModalidade.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Professor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(869, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Modalidade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNovoProfessor_Click);
            // 
            // modalidadeDataGridViewTextBoxColumn
            // 
            this.modalidadeDataGridViewTextBoxColumn.DataPropertyName = "Modalidade";
            this.modalidadeDataGridViewTextBoxColumn.HeaderText = "Modalidade";
            this.modalidadeDataGridViewTextBoxColumn.Name = "modalidadeDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn2
            // 
            this.nomeDataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn2.Name = "nomeDataGridViewTextBoxColumn2";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(AcademiaEF6.Dominio.Aluno);
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vezesSemanaDataGridViewTextBoxColumn
            // 
            this.vezesSemanaDataGridViewTextBoxColumn.DataPropertyName = "VezesSemana";
            this.vezesSemanaDataGridViewTextBoxColumn.HeaderText = "Dias da semana";
            this.vezesSemanaDataGridViewTextBoxColumn.Name = "vezesSemanaDataGridViewTextBoxColumn";
            this.vezesSemanaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vezesSemanaDataGridViewTextBoxColumn.Width = 60;
            // 
            // precoHoraDataGridViewTextBoxColumn
            // 
            this.precoHoraDataGridViewTextBoxColumn.DataPropertyName = "PrecoHora";
            this.precoHoraDataGridViewTextBoxColumn.HeaderText = "PrecoHora";
            this.precoHoraDataGridViewTextBoxColumn.Name = "precoHoraDataGridViewTextBoxColumn";
            this.precoHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // professorDataGridViewTextBoxColumn
            // 
            this.professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
            this.professorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
            this.professorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modalidadeBindingSource
            // 
            this.modalidadeBindingSource.DataSource = typeof(AcademiaEF6.Dominio.Modalidade);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salarioHoraDataGridViewTextBoxColumn
            // 
            this.salarioHoraDataGridViewTextBoxColumn.DataPropertyName = "SalarioHora";
            this.salarioHoraDataGridViewTextBoxColumn.HeaderText = "SalarioHora";
            this.salarioHoraDataGridViewTextBoxColumn.Name = "salarioHoraDataGridViewTextBoxColumn";
            this.salarioHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(AcademiaEF6.Dominio.Professor);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirModalidade);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.dgvModalidade);
            this.Controls.Add(this.dgvProfessor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNovoProfessor);
            this.Controls.Add(this.btnNovaModalidade);
            this.Controls.Add(this.btnNovoAluno);
            this.Controls.Add(this.btnExcluirProfessor);
            this.Name = "FormPrincipal";
            this.Text = "Academia";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirProfessor;
        private System.Windows.Forms.Button btnNovoAluno;
        private System.Windows.Forms.Button btnNovaModalidade;
        private System.Windows.Forms.Button btnNovoProfessor;
        private System.Windows.Forms.DataGridView dgvProfessor;
        private System.Windows.Forms.DataGridView dgvModalidade;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnExcluirModalidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vezesSemanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource modalidadeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.Button button1;
    }
}

