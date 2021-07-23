using AcademiaGinastica.Classes;
using AcademiaGinastica.ClassPessoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AcademiaGinastica
{
    public partial class FrmModalidade : Form, IVerificando
    {
        Academia _academia;

        FrmMenu _frmMenu;

        int indice = -1;

        string nome;

        public FrmModalidade(Academia academia, FrmMenu frmMenu)
        {
            InitializeComponent();
            _academia = academia;
            _frmMenu = frmMenu;
            PreenchendoCmbProfessor();
            BtnNovaModalidade.Hide();
            BtnDeletar.Hide();
            AtualizarLbx();
        }

        private void BtnCadastrarModalidade_Click(object sender, EventArgs e)
        {
            if (indice >= 0 && VerificandoCadastro())
            {
                _academia.AtualizarModalidade(
                    indice,
                    TxtNomeModalidade.Text,
                    double.Parse(MskPrecoHora.Text),
                    (Classes.Professor)CmbProfessor.SelectedItem,
                    Convert.ToInt32(CmbDiasSemanas.SelectedItem)
                    );
                nome = TxtNomeModalidade.Text;
            }
            else if (indice <0 && VerificandoCadastro())
            {
                _academia.AddModalidade(
                    (Classes.Professor)CmbProfessor.SelectedItem,
                    Convert.ToInt32(CmbDiasSemanas.SelectedItem),
                    double.Parse(MskPrecoHora.Text),
                    TxtNomeModalidade.Text
                    );
                Limpar();
            }
            AtualizarLbx();
            CmbProfessor.Focus();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (LbxCadastrados.SelectedIndex >= 0)
            {
                bool cadastrado = false; 
                foreach (var item in _academia.ListaAlunos)
                {
                    if (item.Modalidade.Nome == TxtNomeModalidade.Text)
                    {
                        cadastrado = true;
                    }
                }

                if (cadastrado)
                {
                    MessageBox.Show("Modalidade não pode ser deletada pois a alunos cadastrados nela!\nExclua o aluno primeiro.");
                }
                else
                {
                    _academia.DeletarModalidade(LbxCadastrados.SelectedIndex);
                    AtualizarLbx();
                    if (LbxCadastrados.Items.Count == 0)
                    {
                        BtnNovaModalidade_Click(sender, e);
                    }
                    else
                    {
                        LbxCadastrados.SelectedIndex = 0;
                    }
                    CmbProfessor.Focus();
                }
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
            LbxCadastrados.SelectedIndex = -1;
            CmbProfessor.Focus();
        }

        private void BtnNovaModalidade_Click(object sender, EventArgs e)
        {
            Limpar();
            BtnCadastrarModalidade.Text = "Cadastrar Modalidade";
            indice = -1;
            LbxCadastrados.SelectedIndex = -1;
            BtnNovaModalidade.Hide();
            BtnDeletar.Hide();
            BtnNovo.Show();
            CmbProfessor.Focus();
        }

        private void LbxCadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = LbxCadastrados.SelectedIndex;

            if (indice >= 0 )
            {
                nome = _academia.ListaModalidades[indice].Nome;
                BtnCadastrarModalidade.Text = "Atualizar";
                BtnNovaModalidade.Show();
                BtnDeletar.Show();
                BtnNovo.Hide();
                CmbProfessor.SelectedItem = _academia.ListaModalidades[indice].Professor;
                CmbDiasSemanas.SelectedIndex = _academia.ListaModalidades[indice].VezesSemana -1;
                TxtNomeModalidade.Text = _academia.ListaModalidades[indice].Nome;
                MskPrecoHora.Text = _academia.ListaModalidades[indice].PrecoHora.ToString();
            }
        }

        public void PreenchendoCmbProfessor()
        {
            foreach (var item in _academia.ListaProfessores)
            {
                CmbProfessor.Items.Add(item);
            }
        }

        public void AtualizarLbx()
        {
            LbxCadastrados.Items.Clear();
            foreach (var item in _academia.ListaModalidades)
            {
                LbxCadastrados.Items.Add(item);
            }
        }

        public void Limpar()
        {
            CmbProfessor.SelectedItem = null;
            CmbDiasSemanas.SelectedItem = null;
            TxtNomeModalidade.Clear();
            MskPrecoHora.Clear();
        }

        private void FrmModalidade_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmMenu.VerificandoListas();
        }

        public bool VerificandoCadastro()
        {
            bool preenchido = true;
            string mensagem = "Por favor insira os seguintes itens:\n";

            if (CmbProfessor.SelectedIndex <0)
            {
                mensagem += "- Professor.\n";
                preenchido = false;
            }

            if (CmbDiasSemanas.SelectedIndex <0)
            {
                mensagem += "- Dias da semana.\n";
                preenchido = false;
            }
            if (TxtNomeModalidade.Text.Length == 0)
            {
                mensagem += "- Nome.\n";
                preenchido = false;
            }

            if (MskPrecoHora.Text == "")
            {
                mensagem += "- Preço por Hora.\n";
                preenchido = false;
            }

            foreach (var item in _academia.ListaModalidades)
            {
                if (item.Nome == TxtNomeModalidade.Text && indice <0)
                {
                    MessageBox.Show("MODALIDADE JÁ CADASTRADO!!!");
                    preenchido = false;
                    return preenchido;
                }

                if (indice >= 0 && nome != TxtNomeModalidade.Text)
                {
                    if (item.Nome == TxtNomeModalidade.Text)
                    {
                        MessageBox.Show("MODALIDADE JÁ CADASTRADO!!!");
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

        private void MskPrecoHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
