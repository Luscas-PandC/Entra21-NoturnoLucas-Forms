using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeuPrimeiroProjetoForms
{
    public partial class Questão_3_Nivel_1 : Form
    {
        public Questão_3_Nivel_1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtCodigo_Peca.Text != "" && TxtCodigo_Vendedor.Text != "" && TxtQuantidade_Vendidas.Text != "" && TxtValor_Unitario_Peca.Text != "")
            {
                double comissao = (double.Parse(TxtValor_Unitario_Peca.Text) * double.Parse(TxtQuantidade_Vendidas.Text)) * 0.05;
                TxtResultado_Comissao.Text = ($"{comissao}");
            }
            else
            {
                for(int i = 0; i < 5; i++)
                {
                    LblAlerta.Text = "Valores vazios";
                }
            }
        }
    }
}
