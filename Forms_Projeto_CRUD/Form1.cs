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
            if (novo && Verificar())
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
            }
            else if (novo == false || Verificar() == false)
            {
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].Nome = TxtNome_Aluno.Text;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].DataNascimento = DtpData_Nascimento.Value;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].Matricula = CbxMatricula.Text;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].Genero = CbxGenero.Text;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].NomeResp1 = TxtNome_1Responsavel.Text;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].CpfResp1 = MTB_CPF_1Responsavel.Text;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].NomeResp2 = TxtNome_2Responsavel.Text;
                AlunosMatriculados[LtbMatricula_Aluno.SelectedIndex].CpfResp2 = MTB_CPF_2Responsavel.Text;
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
            
            if (LtbMatricula_Aluno.Items.IndexOf(TxtNome_Aluno.Text) >= 0)
            {
                mensagem = "USUARIO JÁ CADASTRADO\n";
                mensagem += "Por favor insira as informações a seguir:\n";
                mensagem += "- Novo aluno aluno.\n";
                preenchido = false;
            }
            if(TxtNome_Aluno.Text == "")
            {
                mensagem += "- Nome do aluno.\n";
                preenchido = false;
            }
            if (DtpData_Nascimento.Value == DateTime.Today)
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
                mensagem += "- Nome do responsavel.\n";
                preenchido = false;
            }
            if (MTB_CPF_1Responsavel.ToString() == "")
            {
                mensagem += "- CPF do responsavel.\n";
                preenchido = false;
            }
            if (preenchido == false)
            {
                MessageBox.Show(mensagem);
            }
            return preenchido;
        }
    }
}
