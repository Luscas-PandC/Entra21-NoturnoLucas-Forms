using Forms_Projeto_CRUD.NovaPasta1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Projeto_CRUD
{
    public partial class Form1 : Form
    {
        List<ClassOO> AlunosMatriculados;

        bool novo = true;
        
        public Form1()
        {
            AlunosMatriculados = new List<ClassOO>();
            
            InitializeComponent();
            CbxMatricula.Text = "Selecione";
            CbxGenero.Text = "Selecione";
            BtnNovo.Enabled = false;
        }

        private void TxtNome_Aluno_TextChanged(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = true;          
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            BtnDeletar.Enabled = false;
            TxtNome_Aluno.Focus();
            TxtNome_Aluno.Text = "";
            CbxMatricula.Text = "Selecione";
            CbxGenero.Text = "Selecione";
            TxtNome_1Responsavel.Text = "";
            TxtNome_2Responsavel.Text = "";
            MTB_CPF_1Responsavel.Text = "";
            MTB_CPF_2Responsavel.Text = "";
            DtpData_Nascimento.Text = "";
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = false;
        }
        private void LtbMatricula_Aluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LtbMatricula_Aluno.SelectedIndex >= 0)
            {
                TxtNome_Aluno.Text = AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].Nome;
                DtpData_Nascimento.Value = AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].DataNascimento;
                CbxMatricula.Text = AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].Matricula;
                CbxGenero.Text = AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].Genero;
                TxtNome_1Responsavel.Text = AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].NomeResp1;
                TxtNome_2Responsavel.Text = AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].NomeResp2;
                MTB_CPF_1Responsavel.Text = AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].CpfResp1;
                MTB_CPF_2Responsavel.Text = AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].CpfResp2;
                novo = false;
                BtnSalvar.Enabled = true;
                BtnDeletar.Enabled = true;
            }
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (LtbMatricula_Aluno.SelectedIndex >= 0)
            {
                AlunosMatriculados.RemoveAt(LtbMatricula_Aluno.SelectedIndex);
                LtbMatricula_Aluno.Items.RemoveAt(LtbMatricula_Aluno.SelectedIndex);

                TxtNome_Aluno.Text = "";
                CbxMatricula.Text = "Selecione";
                CbxGenero.Text = "Selecione";
                TxtNome_1Responsavel.Text = "";
                TxtNome_2Responsavel.Text = "";
                MTB_CPF_1Responsavel.Text = "";
                MTB_CPF_2Responsavel.Text = "";
                DtpData_Nascimento.Text = "";
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = false;
                novo = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = false;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            bool verificando = Verificar();
            if (novo && verificando)
            {
                ClassOO clase = new ClassOO
                {
                    Nome = TxtNome_Aluno.Text,
                    DataNascimento = DtpData_Nascimento.Value,
                    Matricula = CbxMatricula.Text,
                    Genero = CbxGenero.Text,
                    NomeResp1 = TxtNome_1Responsavel.Text,
                    NomeResp2 = TxtNome_2Responsavel.Text,
                    CpfResp1 = MTB_CPF_1Responsavel.Text,
                    CpfResp2 = MTB_CPF_2Responsavel.Text
                };
                AlunosMatriculados.Add(clase);
                LtbMatricula_Aluno.Items.Add(clase);
                BtnNovo.Enabled = true;
                BtnNovo_Click(sender, e);

            }
            else if (novo == false || verificando)
            {
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].Nome = TxtNome_Aluno.Text;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].DataNascimento = DtpData_Nascimento.Value;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].Matricula = CbxMatricula.Text;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].Genero = CbxGenero.Text;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].NomeResp1 = TxtNome_1Responsavel.Text;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].CpfResp1 = MTB_CPF_1Responsavel.Text;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].NomeResp2 = TxtNome_2Responsavel.Text;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].CpfResp2 = MTB_CPF_2Responsavel.Text;
                BtnNovo_Click(sender, e);

            }

            LtbMatricula_Aluno.Items.Clear();
            foreach (var contato in AlunosMatriculados)
            {
                LtbMatricula_Aluno.Items.Add(contato);
            }
        }
        private bool Verificar()
        {
            bool preenchido = true;
            string mensagem = "Por favor insira as informações a seguir:\n";

            foreach (var contato in AlunosMatriculados)
            {
                if (contato.Nome == TxtNome_Aluno.Text && novo == true)
                {
                    mensagem = "USUARIO JÁ CADASTRADO\n";
                    mensagem += "Por favor insira as informações a seguir:\n";
                    mensagem += "- Novo aluno aluno.\n";
                    preenchido = false;
                }
            }
            if(TxtNome_Aluno.Text == "")
            {
                mensagem += "- Nome do aluno.\n";
                preenchido = false;
            }
            if (DtpData_Nascimento.Text == "12/30/2015")
            {
                mensagem += "- Data de nascimento.\n";
                preenchido = false;
            }
            if (CbxMatricula.Text == "Selecione")
            {
                mensagem += "- Matricula.\n";
                preenchido = false;
            }
            if (CbxGenero.Text == "Selecione")
            {
                mensagem += "- Genero.\n";
                preenchido = false;
            }
            if (TxtNome_1Responsavel.Text == "")
            {
                mensagem += "- Nome do primeiro responsavel.\n";
                preenchido = false;
            }

            string cpf = MTB_CPF_1Responsavel.Text;
            int contador = 0;
            for (int i = 0; i < cpf.Length; i++)
            {
                if(cpf[i] == ' ' && contador < 1)
                {
                    mensagem += "- CPF do primeiro responsavel.\n";
                    preenchido = false;
                    contador++;
                }
            }
            if (preenchido == false)
            {
                MessageBox.Show(mensagem);
            }
            return preenchido;
        }

        private void LblNome_2Responsavel_Click(object sender, EventArgs e)
        {

        }

        private void LblCPF_1Responsavel_Click(object sender, EventArgs e)
        {

        }

        private void LblNome_1Responsavel_Click(object sender, EventArgs e)
        {

        }

        private void LblSexo_Click(object sender, EventArgs e)
        {

        }

        private void LblMatricula_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Nascimento_Click(object sender, EventArgs e)
        {

        }

        private void LblAluno_Click(object sender, EventArgs e)
        {

        }

        private void LblCPF_2Responsavel_Click(object sender, EventArgs e)
        {

        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
