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
        ClassAcademia academia;
        public Form1()
        {
            InitializeComponent();
            academia = new ClassAcademia();
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
            academia.AddClassA(
            TxtNome.Text,
            MtbCPF.Text,
            MtbRG.Text,
            CmbTurma.Text    
            );
            academia.PlanoSelecionado(LbxCadastrados.SelectedIndex, RbtnBasic, RbtnAdvanced);
            atualizaListBox();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            academia.UpdateAluno(
            LbxCadastrados.SelectedIndex,
            TxtNome.Text,
            MtbCPF.Text,
            MtbRG.Text,
            CmbTurma.Text
            );
            atualizaListBox();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            TxtNome.Text = academia.AlunosAcademia[LbxCadastrados.SelectedIndex].Nome;
            MtbCPF.Text = academia.AlunosAcademia[LbxCadastrados.SelectedIndex].CPF;
            MtbRG.Text = academia.AlunosAcademia[LbxCadastrados.SelectedIndex].RG;
            CmbTurma.Text = academia.AlunosAcademia[LbxCadastrados.SelectedIndex].Turma;
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            academia.AlunosAcademia.RemoveAt(LbxCadastrados.SelectedIndex);
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            MtbCPF.Text = "";
            MtbRG.Text = "";
            CmbTurma.Text = "";
        }

        private void BtnConfirmarPagamentos_Click(object sender, EventArgs e)
        {

        }
    }
}
