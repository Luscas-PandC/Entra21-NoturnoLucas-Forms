using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeuPrimeiroProjetoForms
{
    public partial class Questão_2_Nivel_1 : Form
    {
        public Questão_2_Nivel_1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double cotacao;
            if(TxtCotacao_Dolar.Text != "" && TxtDolar.Text != "")
            {
                cotacao = double.Parse(TxtCotacao_Dolar.Text) * double.Parse(TxtDolar.Text);
                TxtReal.Text = ($"{cotacao}");            
            }
            else
            {
                TxtReal.Text = "";
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
