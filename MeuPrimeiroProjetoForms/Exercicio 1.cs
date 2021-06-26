using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeuPrimeiroProjetoForms
{
    public partial class Exercicio_1 : Form
    {
        FormularioPrincipal formPrincipal;  

        public Exercicio_1( FormularioPrincipal formularioPrincipal)
        {
            InitializeComponent();
            formPrincipal = formularioPrincipal;
        }

        private void bntVoltar_Click(object sender, EventArgs e)
        {
            formPrincipal.voltarFormPrincipal(this);
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {

        }
    }
}
