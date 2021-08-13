using ControleEstoqueComEF6.Dominios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueComEF6
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            if (sender == btnNovaCategoria)
            {
                categoriaBindingSource.Add(new Categoria());
                categoriaBindingSource.MoveLast();
            }

            if (categoriaBindingSource.Current == null) return;

            using (var form = new FormCategoria(categoriaBindingSource.Current as Categoria))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var categoria = categoriaBindingSource.Current as Categoria;

                    if (categoria == null) return;

                    using (var db = new ApplicationDbContext())
                    {
                        if (db.Entry<Categoria>(categoria).State == EntityState.Detached)
                            db.Set<Categoria>().Attach(categoria);

                        if (categoria.IdCategoria == 0)
                            db.Entry<Categoria>(categoria).State = EntityState.Added;
                        else
                            db.Entry<Categoria>(categoria).State = EntityState.Modified;

                        if (db.SaveChanges() > 0)
                        {
                            dgvCategorias.Refresh();
                            MessageBox.Show($"Categoria \"{categoria.Nome}\" salva com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Categoria \"{categoria.Nome}\" não pôde ser salva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else if (sender == btnNovaCategoria)
                {
                    categoriaBindingSource.Remove(categoriaBindingSource.Current);
                }
            }
            CarregandoCategoria();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            dgvCategorias.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            CarregandoCategoria();
            CarregandoProdutos();
        }

        public void CarregandoCategoria()
        {
            using (var db = new ApplicationDbContext())
            {
                categoriaBindingSource.DataSource = db.Categorias.ToList();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (categoriaBindingSource.Current == null) return;

            var categoria = categoriaBindingSource.Current as Categoria;

            if (MessageBox.Show($"Deseja realmente excluir essa categoria \"{categoria.Nome}\"?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            using (var db = new ApplicationDbContext())
            {
                if (db.Entry<Categoria>(categoria).State == EntityState.Detached)
                    db.Set<Categoria>().Attach(categoria);
                db.Entry<Categoria>(categoria).State = EntityState.Deleted;

                if (db.SaveChanges() > 0)
                {
                    categoriaBindingSource.Remove(categoria);
                    dgvCategorias.Refresh();
                    MessageBox.Show($"Categoria \"{categoria.Nome}\" excluída com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Categoria \"{categoria.Nome}\" não pôde ser excluída.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }



        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            if (sender == btnNovoProduto)
            {
                produtoBindingSource.Add(new Produto());
                produtoBindingSource.MoveLast();
            }

            if (produtoBindingSource.Current == null) return;

            using (var form = new FormProduto(produtoBindingSource.Current as Produto))
            {
                if (form.DialogResult == DialogResult.OK)
                {
                    var produto = produtoBindingSource.Current as Produto;

                    if (produto == null) return;

                    using (var db = new ApplicationDbContext())
                    {
                        if (db.Entry<Produto>(produto).State == EntityState.Detached)
                            db.Set<Produto>().Attach(produto);

                        if (produto.IdProduto == 0)
                            db.Entry<Produto>(produto).State = EntityState.Added;
                        else
                            db.Entry<Produto>(produto).State = EntityState.Modified;

                        if (db.SaveChanges() > 0)
                        {
                            dgvProdutos.Refresh();
                            MessageBox.Show($"O produto {produto.Nome} foi salvo com sucesso", "informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"O produto{produto.Nome} não pode ser salvo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        public void CarregandoProdutos()
        {
            using (var db = new ApplicationDbContext())
            {
                produtoBindingSource.DataSource = db.Produtos.ToList();
            }
        
        }
    }
}
