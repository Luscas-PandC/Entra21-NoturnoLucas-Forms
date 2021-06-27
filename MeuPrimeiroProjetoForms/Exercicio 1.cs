using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeuPrimeiroProjetoForms
{
    //FORMULARIO EXERCICIO 1
    public partial class Exercicio_1 : Form
    {
        FormularioPrincipal formPrincipal;  
        public Exercicio_1(FormularioPrincipal formularioPrincipal)
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
            Switch_Questao(ltbQuestoes.Text.ToString());
        }

        private void Switch_Questao(string question)
        {
            switch(question)
            {
                case "Questão 1":
                    break;
                case "Questão 2":
                    break;
                case "Questão 3":
                    break;
                case "Questão 4":
                    break;
                case "Questão 5":
                    break;
                case "Questão 6":
                    break;
                case "Questão 7":
                    break;
                case "Questão 8":
                    break;
                case "Questão 9":
                    break;
                case "Questão 10":
                    break;              
            }
        }
    }
}
