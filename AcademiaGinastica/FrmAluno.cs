using AcademiaGinastica.Classes;
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
    public partial class FrmAluno : Form 
    {
        Academia _academia;

        public FrmAluno(Academia academia)
        {
            _academia = academia;
            InitializeComponent();
            EsconderMenu2();
            atualizaListBox();
            foreach (var item in _academia.ListaModalidades)
            {
                CmbModalidade.Items.Add(item);
            }
        }

        private void BtnIncerir_Click(object sender, EventArgs e)
        {
            if(LbxCadastrados.SelectedIndex >= 0)
            {
                _academia.AtualizarAluno(
                LbxCadastrados.SelectedIndex,
                TxtNome.Text,
                MtbCPF.Text,
                MtbTelefone.Text,
                (Modalidade)CmbModalidade.SelectedItem
                );
            }
            else
            {
                _academia.AddAluno(
                TxtNome.Text,
                MtbCPF.Text,
                MtbTelefone.Text,
                (Modalidade)CmbModalidade.SelectedItem
                );
                BtnNovo_Click(sender, e);
            }
            atualizaListBox();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (LbxCadastrados.SelectedIndex >= 0)
            {
                _academia.DeletarAluno(LbxCadastrados.SelectedIndex);
                atualizaListBox();
                if (LbxCadastrados.Items.Count == 0)
                {
                    BtnNovoAluno_Click(sender, e);
                }
                else
                {
                    LbxCadastrados.SelectedIndex = 0;
                }
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtNome.Focus();
            BtnCadastrarAluno.Text = "Cadastrar Aluno";
            TxtNome.Text = "";
            MtbCPF.Text = "";
            MtbTelefone.Text = "";
            CmbModalidade.SelectedIndex = -1;
            TxtProfessor.Text = "";
            TxtTurno.Text = "";
            TxtMensalidade.Text = "";
        }

        private void BtnNovoAluno_Click(object sender, EventArgs e)
        {
            EsconderMenu2();
            BtnCadastrarAluno.Show();
            BtnNovo.Show();
            BtnNovo_Click(sender, e);
            LbxCadastrados.SelectedIndex = -1;
        }

        private void BtnConfirmarPagamentos_Click(object sender, EventArgs e)
        {
            if (LbxCadastrados.SelectedIndex >= 0)
            {
                _academia.ListaAlunos[LbxCadastrados.SelectedIndex].Pagou = "Sim.";
            }
            atualizaListBox();
        }

        private void CmbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbModalidade.SelectedItem != null)
            {
                TxtProfessor.Text = _academia.ListaModalidades[CmbModalidade.SelectedIndex].Professor.Nome;
                TxtTurno.Text = _academia.ListaModalidades[CmbModalidade.SelectedIndex].Professor.Turno;
                TxtMensalidade.Text = _academia.ListaModalidades[CmbModalidade.SelectedIndex].CalculaValor().ToString();
            }
        }

        private void LbxCadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = LbxCadastrados.SelectedIndex;
            if (indice >= 0)
            {
                BtnDeletar.Show();
                BtnNovoAluno.Show();
                BtnConfirmarPagamentos.Show();
                BtnNovo.Hide();
                BtnCadastrarAluno.Text = "Atualizar";
                TxtNome.Text = _academia.ListaAlunos[LbxCadastrados.SelectedIndex].Nome;
                MtbCPF.Text = _academia.ListaAlunos[LbxCadastrados.SelectedIndex].CPF;
                MtbTelefone.Text = _academia.ListaAlunos[LbxCadastrados.SelectedIndex].Telefone;
                CmbModalidade.SelectedItem = _academia.ListaAlunos[LbxCadastrados.SelectedIndex].Modalidade;
            }
        }

        private void atualizaListBox()
        {
            LbxCadastrados.Items.Clear();
            foreach (var aluno in _academia.ListaAlunos)
            {
                LbxCadastrados.Items.Add(aluno.ToString());
            }
        }

        private void EsconderMenu2()
        {
            BtnDeletar.Hide();
            BtnConfirmarPagamentos.Hide();
            BtnNovoAluno.Hide();
        }
    }
}
