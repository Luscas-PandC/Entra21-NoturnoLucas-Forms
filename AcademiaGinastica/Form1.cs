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
            BtnDeletar.Hide();
            BtnEditar.Hide();
            BtnConfirmarPagamentos.Hide();
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
                BtnNovo_Click(sender, e);
                BtnIncerir.Text = "Cadastrar Aluno";
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
            EsconderMenu2();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (LbxCadastrados.SelectedIndex >= 0)
            {
                academia.AlunosAcademia.RemoveAt(LbxCadastrados.SelectedIndex);
                atualizaListBox();
                BtnNovo_Click(sender, e);
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LbxCadastrados.SelectedIndex = -1;
            BtnIncerir.Text = "Cadastrar Alunos";
            EsconderMenu2();
            TxtNome.Focus();
            TxtNome.Text = "";
            MtbCPF.Text = "";
            MtbRG.Text = "";
            CmbTurma.Text = "";
            RbtnBasic.Checked = false;
            RbtnAdvanced.Checked = false;
        }

        private void BtnConfirmarPagamentos_Click(object sender, EventArgs e)
        {
            academia.AlunosAcademia[LbxCadastrados.SelectedIndex].Paga = true;
            atualizaListBox();
        }
        private void LbxCadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnDeletar.Show();
            BtnEditar.Show();
            BtnConfirmarPagamentos.Show();
            BtnIncerir.Hide();
            BtnNovo.Hide();
            DesabilitarInformacoes();
            ExibirInformacoes();
        }
        private void EsconderMenu2()
        {
            BtnDeletar.Hide();
            BtnEditar.Hide();
            BtnConfirmarPagamentos.Hide();       
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
            }
        }
    }
}
