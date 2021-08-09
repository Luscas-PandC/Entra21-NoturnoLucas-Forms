
namespace ControleEstoqueComEF6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovaCategoria = new System.Windows.Forms.Button();
            this.btnAlterarCategoria = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoriaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dgvCategorias.DataSource = this.categoriaBindingSource;
            this.dgvCategorias.Location = new System.Drawing.Point(26, 30);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(292, 277);
            this.dgvCategorias.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categorias";
            // 
            // btnNovaCategoria
            // 
            this.btnNovaCategoria.Location = new System.Drawing.Point(24, 322);
            this.btnNovaCategoria.Name = "btnNovaCategoria";
            this.btnNovaCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnNovaCategoria.TabIndex = 2;
            this.btnNovaCategoria.Text = "Nova...";
            this.btnNovaCategoria.UseVisualStyleBackColor = true;
            this.btnNovaCategoria.Click += new System.EventHandler(this.btnNovaCategoria_Click);
            // 
            // btnAlterarCategoria
            // 
            this.btnAlterarCategoria.Location = new System.Drawing.Point(105, 322);
            this.btnAlterarCategoria.Name = "btnAlterarCategoria";
            this.btnAlterarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCategoria.TabIndex = 2;
            this.btnAlterarCategoria.Text = "Alterar...";
            this.btnAlterarCategoria.UseVisualStyleBackColor = true;
            this.btnAlterarCategoria.Click += new System.EventHandler(this.btnNovaCategoria_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(207, 322);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir...";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IdCategoria";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "D3";
            dataGridViewCellStyle2.NullValue = null;
            this.idCategoriaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCategoriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idCategoriaDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(ControleEstoqueComEF6.Categoria);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn1,
            this.estoqueDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.produtoBindingSource;
            this.dgvProdutos.Location = new System.Drawing.Point(360, 30);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(449, 277);
            this.dgvProdutos.TabIndex = 3;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(ControleEstoqueComEF6.Dominios.Produto);
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "D3";
            dataGridViewCellStyle3.NullValue = null;
            this.idProdutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdutoDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            this.estoqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn.Width = 80;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoDataGridViewTextBoxColumn.Width = 80;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(907, 390);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnAlterarCategoria);
            this.Controls.Add(this.btnNovaCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovaCategoria;
        private System.Windows.Forms.Button btnAlterarCategoria;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produtoBindingSource;
    }
}

