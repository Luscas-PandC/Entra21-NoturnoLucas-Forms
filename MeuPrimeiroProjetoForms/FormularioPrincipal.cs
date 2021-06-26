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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }
        private void bntConfirmar_Escolha_Questoes_Click(object sender, EventArgs e)
        {
            switch_Questao();
        }
        private void switch_Questao()
        {
            var exercicio1 = new Exercicio_1(this);
            var exercicio2 = new Exercicio_2(this);
            var exercicio3 = new Exercicio_3();
            string opcao = cnxEscolhaQuestao.Text.ToString();

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
        public void voltarFormPrincipal(Form formulario)
        {
            formulario.Hide();
            this.Show();
        }
    }
}
