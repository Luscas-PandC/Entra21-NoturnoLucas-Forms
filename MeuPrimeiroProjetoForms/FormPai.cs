using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeuPrimeiroProjetoForms
{
    public partial class FormPai : Form
    {
        public FormPai()
        { 
            InitializeComponent();
        }

        private void FormPai_Load(object sender, EventArgs e)
        {
            FormularioPrincipal form_Principal = new FormularioPrincipal();
            Size = form_Principal.Size;
            form_Principal.MdiParent = this;
            form_Principal.Show();
        }
    }
}
