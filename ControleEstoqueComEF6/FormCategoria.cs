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
    public partial class FormCategoria : Form
    {
        Categoria categoria;
        public FormCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            txtCodigo.DataBindings.Add(new Binding("Text", this.categoria, "IdCategoria"));
            txtNome.DataBindings.Add(new Binding("Text", this.categoria, "Nome"));
        }
    }
}
