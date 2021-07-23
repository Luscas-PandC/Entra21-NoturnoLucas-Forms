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
    public partial class FrmProfessor : Form, IVerificando
    {
        Academia _academia;

        FrmMenu _frmMenu;

        int indice = -1;

        string nome;

        public FrmProfessor(Academia academia, FrmMenu frmMenu)
        {
            InitializeComponent();
            _academia = academia;
            _frmMenu = frmMenu;

            BtnNovoProfessor.Hide();
            BtnDeletar.Hide();
            AtualizarLista();
        }

        private void BtnCadastrarProfessor_Click(object sender, EventArgs e)
        {
       
            if(indice <0 && VerificandoCadastro())
            {
                _academia.AddProfessor(TxtNome.Text, MskTelefone.Text, MskCPF.Text, CmbTurno.Text);
                Limpar();
            }
            else if (indice >= 0 && VerificandoCadastro())
            {
                _academia.AtualizarProfessor(indice, TxtNome.Text, MskTelefone.Text, MskCPF.Text, CmbTurno.Text);
                nome = TxtNome.Text;
            }
            AtualizarLista();
            TxtNome.Focus();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (LbxCadastrados.SelectedIndex >= 0)
            {
                bool cadastrado = false;
                foreach (var item in _academia.ListaModalidades)
                {
                    if (item.Professor.Nome == TxtNome.Text)
                    {
                        cadastrado = true;
                    }
                }
                if (cadastrado)
                {
                    MessageBox.Show("Professor não pode ser deletado pois à modalidade cadastrada nele!\nExclua a modalidade primeiro.");
                }
                else
                {
                    _academia.DeletarProfessor(LbxCadastrados.SelectedIndex);
                    AtualizarLista();
                    if (LbxCadastrados.Items.Count == 0)
                    {
                        BtnNovoProfessor_Click(sender, e);
                    }
                    else
                    {
                        LbxCadastrados.SelectedIndex = 0;
                    }
                }
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
            LbxCadastrados.SelectedIndex = -1;
            indice = -1;
            TxtNome.Focus();
        }

        private void BtnNovoProfessor_Click(object sender, EventArgs e)
        {
            Limpar();
            LbxCadastrados.SelectedIndex = -1;
            indice = -1;
            BtnCadastrarProfessor.Text = "Cadastrar Professor";
            BtnNovo.Show();
            BtnDeletar.Hide();
            BtnNovoProfessor.Hide();
        }

        private void LbxCadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = LbxCadastrados.SelectedIndex;

            if (indice >= 0)
            {
                nome = _academia.ListaProfessores[indice].Nome;
                BtnCadastrarProfessor.Text = "Atualizar";
                BtnNovo.Hide();
                BtnNovoProfessor.Show();
                BtnDeletar.Show();
                TxtNome.Text = _academia.ListaProfessores[indice].Nome;
                MskCPF.Text = _academia.ListaProfessores[indice].CPF;
                MskTelefone.Text = _academia.ListaProfessores[indice].Telefone;
                CmbTurno.SelectedItem = _academia.ListaProfessores[indice].Turno;
            }
        }

        private void AtualizarLista()
        {
            LbxCadastrados.Items.Clear();
            foreach(var itens in _academia.ListaProfessores)
            {
                LbxCadastrados.Items.Add(itens.ToString());
            }
        }

        private void Limpar()
        {
            TxtNome.Clear();
            MskCPF.Clear();
            MskTelefone.Clear();
            CmbTurno.SelectedItem = null;
        }

        private void FrmProfessor_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmMenu.VerificandoListas();
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

            if (MskTelefone.Text.Length < 15)
            {
                mensagem += "- Telefone.\n";
                preenchido = false;
            }

            if(MskCPF.Text.Length < 14)
            {
                mensagem += "- CPF.\n";
                preenchido = false;
            }

            if(CmbTurno.SelectedIndex < 0)
            {
                mensagem += "- Turno.\n";
                preenchido = false;
            }

            foreach (var item in _academia.ListaProfessores)
            {
                if (item.Nome == TxtNome.Text && indice <0)
                {
                    MessageBox.Show("USUÁRIO JÁ CADASTRADO!!!");
                    preenchido = false;
                    return preenchido;
                }

                if (indice >= 0 && nome != TxtNome.Text)
                {
                    if (item.Nome == TxtNome.Text)
                    {
                        MessageBox.Show("USUÁRIO JÁ CADASTRADO!!!");
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
