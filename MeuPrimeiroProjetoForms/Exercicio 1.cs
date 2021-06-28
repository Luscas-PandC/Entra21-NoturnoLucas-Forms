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
        public Exercicio_1()
        {
            InitializeComponent();
        }

        private void BtnComecar_Click(object sender, EventArgs e)
        {
            Switch_Questao(ltbQuestoes.Text.ToString());
        }

        private void Switch_Questao(string question)
        {
            Questão_1_Nivel_1 questao1 = new Questão_1_Nivel_1();
            Questão_2_Nivel_1 questao2 = new Questão_2_Nivel_1();
            Questão_3_Nivel_1 questao3 = new Questão_3_Nivel_1();

            switch (question)
            {
                case "Questão 1":
                    questao1.Show();
                    break;
                case "Questão 2":
                    questao2.Show();
                    break;
                case "Questão 3":
                    questao3.Show();
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
                    MessageBox.Show("Questão 9");
                    break;
                case "Questão 10":
                    break;              
            }
        }

        private void BntVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
