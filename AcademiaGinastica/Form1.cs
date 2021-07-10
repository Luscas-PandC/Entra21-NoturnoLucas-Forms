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
            foreach (var aluno in academia.AlunosAcademia)
            {
                LbxCadastrados.Items.Add(aluno.ToString());
            }
        }
        private void BtnIncerir_Click(object sender, EventArgs e)
        {
            if(LbxCadastrados.SelectedIndex >= 0)
            {
                academia.UpdateAluno(
                LbxCadastrados.SelectedIndex,
                TxtNome.Text,
                MtbCPF.Text,
                MtbRG.Text,
                CmbTurma.Text,
                RbtnBasic,
                RbtnAdvanced
                );
            }
            else
            {
                academia.AddClassA(
                TxtNome.Text,
                MtbCPF.Text,
                MtbRG.Text,
                CmbTurma.Text,
                RbtnBasic,
                RbtnAdvanced
                );
            }
            atualizaListBox();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            HabilitarInformacoes();
            BtnIncerir.Show();
            BtnIncerir.Text = "Atualizar";
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (LbxCadastrados.SelectedIndex >= 0)
            {
                BtnNovo_Click(sender, e);
                academia.AlunosAcademia.RemoveAt(LbxCadastrados.SelectedIndex);
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
            MtbRG.Text = "";
            CmbTurma.Text = "";
            RbtnBasic.Checked = false;
            RbtnAdvanced.Checked = false;
        }
        private void BtnConfirmarPagamentos_Click(object sender, EventArgs e)
        {
            if (LbxCadastrados.SelectedIndex >= 0)
            {
                academia.AlunosAcademia[LbxCadastrados.SelectedIndex].Paga = true;
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
                BtnIncerir.Hide();
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
            MtbRG.Enabled = false;
            RbtnAdvanced.Enabled = false;
            RbtnBasic.Enabled = false;
            LblNome.Enabled = false;
            LblTurma.Enabled = false;
            LblCPF.Enabled = false;
            LblRG.Enabled = false;
            LblMensalidade.Enabled = false;
        }
        private void HabilitarInformacoes()
        {
            TxtNome.Enabled = true;
            CmbTurma.Enabled = true;
            MtbCPF.Enabled = true;
            MtbRG.Enabled = true;
            RbtnAdvanced.Enabled = true;
            RbtnBasic.Enabled = true;
            LblNome.Enabled = true;
            LblTurma.Enabled = true;
            LblCPF.Enabled = true;
            LblRG.Enabled = true;
            LblMensalidade.Enabled = true;
        }
        private void ExibirInformacoes()
        {
            if (LbxCadastrados.SelectedIndex >= 0)
            {
                TxtNome.Text = academia.AlunosAcademia[LbxCadastrados.SelectedIndex].Nome;
                MtbCPF.Text = academia.AlunosAcademia[LbxCadastrados.SelectedIndex].CPF;
                MtbRG.Text = academia.AlunosAcademia[LbxCadastrados.SelectedIndex].RG;
                CmbTurma.Text = academia.AlunosAcademia[LbxCadastrados.SelectedIndex].Turma;
                RbtnBasic.Checked = academia.AlunosAcademia[LbxCadastrados.SelectedIndex].Rbtn1;
                RbtnAdvanced.Checked = academia.AlunosAcademia[LbxCadastrados.SelectedIndex].Rbtn2;
                LblNome.Enabled = true;
                LblTurma.Enabled = true;
                LblCPF.Enabled = true;
                LblRG.Enabled = true;
                LblMensalidade.Enabled = true;
            }
        }
        private void BtnNovoAluno_Click(object sender, EventArgs e)
        {
            HabilitarInformacoes();
            EsconderMenu2();
            BtnIncerir.Show();
            BtnNovo.Show();
            BtnIncerir.Text = "Cadastrar Aluno";
            BtnNovo_Click(sender, e);
            LbxCadastrados.SelectedIndex = -1;
        }
    }
}
