using AcademiaGinastica.ClassPessoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaGinastica
{
    public partial class Form1 : Form 
    {
        Academia academia;
        public Form1()
        {
            InitializeComponent();
            academia = new Academia();
            EsconderMenu2();
            CmbTurma.Text = "Manha";
        }
        private void atualizaListBox()
        {
            LbxCadastrados.Items.Clear();
            foreach (var aluno in academia.ListaAlunos)
            {
                LbxCadastrados.Items.Add(aluno.ToString());
            }
        }
        private void BtnIncerir_Click(object sender, EventArgs e)
        {
            if(LbxCadastrados.SelectedIndex >= 0)
            {
                academia.AtualizarAluno(
                LbxCadastrados.SelectedIndex,
                TxtNome.Text,
                MtbCPF.Text,
                MtbTelefone.Text,
                CmbTurma.Text
                );
            }
            else
            {
                academia.AddAluno(
                TxtNome.Text,
                MtbCPF.Text,
                MtbTelefone.Text,
                CmbTurma.Text
                );
            }
            atualizaListBox();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            HabilitarInformacoes();
            BtnCadastrarAluno.Show();
            BtnCadastrarAluno.Text = "Atualizar";
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (LbxCadastrados.SelectedIndex >= 0)
            {
                BtnNovo_Click(sender, e);
                academia.ListaAlunos.RemoveAt(LbxCadastrados.SelectedIndex);
                atualizaListBox();
            }
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (LbxCadastrados.SelectedIndex < 0)
            {
                TxtNome.Focus();
            }
            TxtNome.Text = "";
            MtbCPF.Text = "";
            MtbTelefone.Text = "";
            CmbTurma.Text = "";
        }
        private void BtnConfirmarPagamentos_Click(object sender, EventArgs e)
        {
            if (LbxCadastrados.SelectedIndex >= 0)
            {
                academia.ListaAlunos[LbxCadastrados.SelectedIndex].Pagou = "Sim.";
            }
            atualizaListBox();
        }
        private void LbxCadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbxCadastrados.SelectedIndex >= 0)
            {
                ExibirMenu2();
                ExibirInformacoes();
                DesabilitarInformacoes();
                BtnCadastrarAluno.Hide();
                BtnNovo.Hide();
            }
        }
        private void EsconderMenu2()
        {
            BtnDeletar.Hide();
            BtnEditar.Hide();
            BtnConfirmarPagamentos.Hide();
            BtnNovoAluno.Hide();
        }
        private void ExibirMenu2()
        {
            BtnDeletar.Show();
            BtnEditar.Show();
            BtnNovoAluno.Show();
            BtnConfirmarPagamentos.Show();
        }
        private void DesabilitarInformacoes()
        {        
            TxtNome.Enabled = false;
            CmbTurma.Enabled = false;
            MtbCPF.Enabled = false;
            MtbTelefone.Enabled = false;
            LblNome.Enabled = false;
            LblTurma.Enabled = false;
            LblCPF.Enabled = false;
            LblTelefone.Enabled = false;
            LblMensalidade.Enabled = false;
        }
        private void HabilitarInformacoes()
        {
            TxtNome.Enabled = true;
            CmbTurma.Enabled = true;
            MtbCPF.Enabled = true;
            MtbTelefone.Enabled = true;
            LblNome.Enabled = true;
            LblTurma.Enabled = true;
            LblCPF.Enabled = true;
            LblTelefone.Enabled = true;
            LblMensalidade.Enabled = true;
        }
        private void ExibirInformacoes()
        {
            if (LbxCadastrados.SelectedIndex >= 0)
            {
                TxtNome.Text = academia.ListaAlunos[LbxCadastrados.SelectedIndex].Nome;
                MtbCPF.Text = academia.ListaAlunos[LbxCadastrados.SelectedIndex].CPF;
                MtbTelefone.Text = academia.ListaAlunos[LbxCadastrados.SelectedIndex].Telefone;
                CmbTurma.Text = academia.ListaAlunos[LbxCadastrados.SelectedIndex].Turno;
                LblNome.Enabled = true;
                LblTurma.Enabled = true;
                LblCPF.Enabled = true;
                LblTelefone.Enabled = true;
                LblMensalidade.Enabled = true;
            }
        }
        private void BtnNovoAluno_Click(object sender, EventArgs e)
        {
            HabilitarInformacoes();
            EsconderMenu2();
            BtnCadastrarAluno.Show();
            BtnNovo.Show();
            BtnCadastrarAluno.Text = "Cadastrar Aluno";
            BtnNovo_Click(sender, e);
            LbxCadastrados.SelectedIndex = -1;
        }

        private void CmbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
