using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroProjetoForms
{
    // FORMULARIO PRINCIPAL
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLista1_Click(object sender, EventArgs e)
        {
            Exercicio_1 exercicio_1 = new Exercicio_1();
            if (exercicio_1.Visible)
            {

            }
            else
            {
                exercicio_1.Show();
            }
        }

        private void BtnLista2_Click(object sender, EventArgs e)
        {
            Exercicio_2 exercicio_2 = new Exercicio_2();
            exercicio_2.Show();
        }
        private void BtnLista3_Click(object sender, EventArgs e)
        {
            Exercicio_3 exercicio_3 = new Exercicio_3();
            exercicio_3.Show();
        }
    }
}
