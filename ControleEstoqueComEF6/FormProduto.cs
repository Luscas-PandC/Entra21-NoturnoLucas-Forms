using ControleEstoqueComEF6.Dominios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueComEF6
{
    public partial class FormProduto : Form
    {
        Produto produto;
        public FormProduto(Produto _produto)
        {
            InitializeComponent();
            produto = _produto;
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            txtNome.DataBindings.Add("Text", produto, "Name");
            txtEstoque.DataBindings.Add("Text", produto, "Estoque");
            txtPreco.DataBindings.Add("Text", produto, "Preco");
        }
    }
}
