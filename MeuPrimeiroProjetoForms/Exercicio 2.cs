using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeuPrimeiroProjetoForms
{
    public partial class Exercicio_2 : Form
    {
        FormularioPrincipal FormPrincipal;

        public Exercicio_2(FormularioPrincipal formularioPrincipal)
        {
            InitializeComponent();
            FormPrincipal = formularioPrincipal;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormPrincipal.voltarFormPrincipal(this);
        }
    }
}
