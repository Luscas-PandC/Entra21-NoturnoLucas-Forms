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
        
        FormularioPrincipal form_Principal = new FormularioPrincipal();
        public FormPai()
        { 
            InitializeComponent();
        }

        private void FormPai_Load(object sender, EventArgs e)
        {
            Size = form_Principal.Size;
            form_Principal.MdiParent = this;
            form_Principal.Show();
        }
        public void teste()
        {
            form_Principal.Close();
            Exercicio_1 exercico_1 = new Exercicio_1();
            exercico_1.MdiParent = this;
            exercico_1.Show();
            MessageBox.Show("oi");
        }

    }
}
