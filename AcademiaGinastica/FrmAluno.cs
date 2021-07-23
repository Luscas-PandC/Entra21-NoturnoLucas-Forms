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
    public partial class FrmAluno : Form, IVerificando
    {
        Academia _academia;

        string nome;

        int indice = -1;

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
            if(indice >= 0 && VerificandoCadastro())
            {
                _academia.AtualizarAluno(
                indice,
                TxtNome.Text,
                MskCPF.Text,
                MskTelefone.Text,
                (Modalidade)CmbModalidade.SelectedItem
                );
                nome = TxtNome.Text;
            }
            else if (indice < 0 && VerificandoCadastro())
            {
                _academia.AddAluno(
                TxtNome.Text,
                MskCPF.Text,
                MskTelefone.Text,
                (Modalidade)CmbModalidade.SelectedItem
                );
                BtnNovo_Click(sender, e);
            }
            atualizaListBox();
            TxtNome.Focus();
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
            MskCPF.Text = "";
            MskTelefone.Text = "";
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
            indice = -1;
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
            indice = LbxCadastrados.SelectedIndex;
            if (indice >= 0)
            {
                nome = _academia.ListaAlunos[indice].Nome;
                BtnDeletar.Show();
                BtnNovoAluno.Show();
                BtnConfirmarPagamentos.Show();
                BtnNovo.Hide();
                BtnCadastrarAluno.Text = "Atualizar";
                TxtNome.Text = _academia.ListaAlunos[indice].Nome;
                MskCPF.Text = _academia.ListaAlunos[indice].CPF;
                MskTelefone.Text = _academia.ListaAlunos[indice].Telefone;
                CmbModalidade.SelectedItem = _academia.ListaAlunos[indice].Modalidade;
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

        public bool VerificandoCadastro()
        {
            bool preenchido = true;
            string mensagem = "Por favor informe os seguintes itens:\n";

            if (TxtNome.Text.Length == 0)
            {
                mensagem += "- Nome.\n";
                preenchido = false;
            }
            if (MskCPF.Text.Length < 14)
            {
                mensagem += "- CPF.\n";
                preenchido = false;
            }
            if (MskTelefone.Text.Length < 15)
            {
                mensagem += "- Telefone.\n";
                preenchido = false;
            }
            if (CmbModalidade.SelectedIndex < 0)
            {
                mensagem += "- Modalidade.\n";
                preenchido = false;
            }
            foreach (var item in _academia.ListaAlunos)
            {
                if (item.Nome == TxtNome.Text && indice < 0)
                {
                    MessageBox.Show("ALUNO JÁ CADASTRADO!!!");
                    preenchido = false;
                    return preenchido;
                }
                if (indice >= 0 && nome != TxtNome.Text)
                {
                    if (item.Nome == TxtNome.Text)
                    {
                        MessageBox.Show("ALUNO JÁ CADASTRADO!!!");
                        preenchido = false;
                        return preenchido;
                    }
                }
            }
            if (!preenchido)
            {
                MessageBox.Show(mensagem);
            }
            return preenchido;
        }
    }
}
