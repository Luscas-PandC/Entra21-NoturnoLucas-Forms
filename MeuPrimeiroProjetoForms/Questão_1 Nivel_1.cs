using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeuPrimeiroProjetoForms
{
    public partial class Questão_1_Nivel_1 : Form
    {
        public Questão_1_Nivel_1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            if (TxtQuantidade_Minima.Text.ToString() != "" && TxtQuantidade_Maxima.Text.ToString() != "")
            {
                resultado = (double.Parse(TxtQuantidade_Minima.Text.ToString()) + double.Parse(TxtQuantidade_Maxima.Text.ToString())) / 2;
                TxtResultado.Text = ($"{resultado}");
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
