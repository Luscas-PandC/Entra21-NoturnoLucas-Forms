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
            CnxEscolhaQuestao.Text = "Exercicio 1";
        }

        private void BntConfirmar_Escolha_Questoes_Click(object sender, EventArgs e)
        {
            Switch_Questao();
        }

        private void Switch_Questao()
        {
            var exercicio1 = new Exercicio_1();
            var exercicio2 = new Exercicio_2();
            var exercicio3 = new Exercicio_3();
            string opcao = CnxEscolhaQuestao.Text.ToString();

            switch(opcao)
            {
                case "Exercicio 1":
                    exercicio1.Show();
                    break;
                case "Exercicio 2":
                    exercicio2.Show();
                    break;
                case "Exercicio 3":
                    exercicio3.Show();
                    break;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
