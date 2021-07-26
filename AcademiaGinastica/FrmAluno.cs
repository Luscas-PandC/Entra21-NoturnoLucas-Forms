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
        }

        private void BtnIncerir_Click(object sender, EventArgs e)
        {
            if(indice >= 0 && VerificandoCadastro())
            {
                _academia.AtualizarAluno(indice, TxtNome.Text, MskCPF.Text, MskTelefone.Text, (Modalidade)CmbModalidade.SelectedItem, CmbTurno.Text, int.Parse(CmbDiasSemanas.Text), double.Parse(TxtMensalidade.Text));
                nome = TxtNome.Text;
            }
            else if (indice < 0 && VerificandoCadastro())
            {
                _academia.AddAluno(TxtNome.Text, MskCPF.Text, MskTelefone.Text, (Modalidade)CmbModalidade.SelectedItem, CmbTurno.Text, int.Parse(CmbDiasSemanas.Text), double.Parse(TxtMensalidade.Text));
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
            limpar();
        }

        private void BtnNovoAluno_Click(object sender, EventArgs e)
        {
            EsconderMenu2();
            BtnCadastrarAluno.Show();
            BtnNovo.Show();
            BtnCadastrarAluno.Text = "Cadastrar Aluno";
            limpar();
            TxtNome.Focus();
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
            }
            if (CmbDiasSemanas.SelectedIndex >= 0 && CmbModalidade.SelectedIndex >= 0)
            {
                TxtMensalidade.Text = _academia.ListaModalidades[CmbModalidade.SelectedIndex].CalculaValor(int.Parse(CmbDiasSemanas.Text)).ToString(); 
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
                CmbTurno.SelectedItem = _academia.ListaAlunos[indice].Turno;
                CmbDiasSemanas.SelectedItem = _academia.ListaAlunos[indice].DiasSemana.ToString();
                TxtMensalidade.Text = _academia.ListaAlunos[indice].Mensalidade.ToString();
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

        public void limpar()
        {
            TxtNome.Clear();
            MskCPF.Clear();
            MskTelefone.Clear();
            CmbModalidade.SelectedIndex = -1;
            TxtProfessor.Clear();
            CmbTurno.SelectedIndex = -1;
            CmbDiasSemanas.SelectedIndex = -1;
            TxtMensalidade.Clear();
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

            if (String.IsNullOrEmpty(TxtNome.Text))
            {
                mensagem += "- Nome.\n";
                preenchido = false;
            }
            if (!MskCPF.MaskCompleted)
            {
                mensagem += "- CPF.\n";
                preenchido = false;
            }
            if (!MskTelefone.MaskCompleted)
            {
                mensagem += "- Telefone.\n";
                preenchido = false;
            }
            if (CmbModalidade.SelectedIndex < 0)
            {
                mensagem += "- Modalidade.\n";
                preenchido = false;
            }
            if (CmbTurno.SelectedIndex < 0)
            {
                mensagem += "- Turno.\n";
                preenchido = false;
            }
            if (CmbDiasSemanas.SelectedIndex < 0)
            {
                mensagem += "- Dias da Semana.\n";
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

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            foreach (var item in _academia.ListaModalidades)
            {
                CmbModalidade.Items.Add(item);
            }
        }

        private void CmbDiasSemanas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbModalidade.SelectedIndex >= 0)
            {
                TxtMensalidade.Text = _academia.ListaModalidades[CmbModalidade.SelectedIndex].CalculaValor(int.Parse(CmbDiasSemanas.Text)).ToString();
            }
        }
    }
}
