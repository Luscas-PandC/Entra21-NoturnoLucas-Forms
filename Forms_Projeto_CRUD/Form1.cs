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
        List<string> lista_Nome_Aluno, lista_Genero, lista_Matricula,
                     lista_Nome_1Responsavel, lista_Nome_2Responsavel,
                     lista_CPF_1Responsavel, lista_CPF_2Responsavel;


        List<DateTime> lista_Data_Nascimento;
        bool novo;

        public Form1()

        {
            InitializeComponent();
            CbxMatricula.Text = "Selecione";
            CbxGenero.Text = "Selecione";

            lista_Nome_Aluno = new List<string>();
            lista_Genero = new List<string>();
            lista_Matricula = new List<string>();
            lista_Nome_1Responsavel = new List<string>();
            lista_Nome_2Responsavel = new List<string>();
            lista_CPF_1Responsavel = new List<string>();
            lista_CPF_2Responsavel = new List<string>();
            lista_Data_Nascimento = new List<DateTime>();
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            BtnSalvar.Enabled = novo;
            TxtNome_Aluno.Focus();
            TxtNome_Aluno.Text = "";
            CbxMatricula.Text = "Selecione";
            CbxGenero.Text = "Selecione";
            TxtNome_1Responsavel.Text = "";
            TxtNome_2Responsavel.Text = "";
            MTB_CPF_1Responsavel.Text = "";
            MTB_CPF_2Responsavel.Text = "";
            DtpData_Nascimento.Text = "";
        }
        private void LtbMatricula_Aluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LtbMatricula_Aluno.SelectedIndex >= 0)
            {
                TxtNome_Aluno.Text = lista_Nome_Aluno[LtbMatricula_Aluno.SelectedIndex];
                CbxMatricula.Text = lista_Matricula[LtbMatricula_Aluno.SelectedIndex];
                CbxGenero.Text = lista_Genero[LtbMatricula_Aluno.SelectedIndex];
                TxtNome_1Responsavel.Text = lista_Nome_1Responsavel[LtbMatricula_Aluno.SelectedIndex];
                TxtNome_2Responsavel.Text = lista_Nome_2Responsavel[LtbMatricula_Aluno.SelectedIndex];
                MTB_CPF_1Responsavel.Text = lista_CPF_1Responsavel[LtbMatricula_Aluno.SelectedIndex];
                MTB_CPF_2Responsavel.Text = lista_CPF_2Responsavel[LtbMatricula_Aluno.SelectedIndex];
                DtpData_Nascimento.Value = lista_Data_Nascimento[LtbMatricula_Aluno.SelectedIndex];
                novo = false;
                BtnSalvar.Enabled = true;
                BtnDeletar.Enabled = true;
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            lista_Nome_Aluno.RemoveAt(LtbMatricula_Aluno.SelectedIndex);
            lista_Matricula.RemoveAt(LtbMatricula_Aluno.SelectedIndex);
            lista_Genero.RemoveAt(LtbMatricula_Aluno.SelectedIndex);
            lista_Nome_1Responsavel.RemoveAt(LtbMatricula_Aluno.SelectedIndex);
            lista_Nome_2Responsavel.RemoveAt(LtbMatricula_Aluno.SelectedIndex);
            lista_CPF_1Responsavel.RemoveAt(LtbMatricula_Aluno.SelectedIndex);
            lista_CPF_2Responsavel.RemoveAt(LtbMatricula_Aluno.SelectedIndex);
            lista_Data_Nascimento.RemoveAt(LtbMatricula_Aluno.SelectedIndex);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnNovo_Click(sender, e);
        }
    }
}
