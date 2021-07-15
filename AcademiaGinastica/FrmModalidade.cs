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
    public partial class FrmModalidade : Form
    {
        Academia _academia;
        int indice = -1;
        public FrmModalidade(Academia academia)
        {
            InitializeComponent();
            _academia = academia;
            PreenchendoCmbProfessor();
            BtnNovaModalidade.Hide();
            BtnDeletar.Hide();
        }

        public void PreenchendoCmbProfessor()
        {
            foreach (var item in _academia.ListaProfessores)
            {
                CmbProfessor.Items.Add(item);
            }
        }

        public void Limpar()
        {
            CmbProfessor.SelectedItem = null;
            CmbDiasSemanas.SelectedItem = null;
            TxtNomeModalidade.Clear();
            MskPrecoHora.Clear();
        }

        public void AtualizarLbx()
        {
            LbxCadastrados.Items.Clear();
            foreach (var item in _academia.ListaModalidades)
            {
                LbxCadastrados.Items.Add(item);
            }
        }

        public void BtnCadastrarModalidade_Click(object sender, EventArgs e)
        {
            if (indice >= 0)
            {
                _academia.AtualizarModalidade(
                    indice,
                    TxtNomeModalidade.Text,
                    double.Parse(MskPrecoHora.Text),
                    (Classes.Professor)CmbProfessor.SelectedItem,
                    Convert.ToInt32(CmbDiasSemanas.SelectedItem)
                    );
            }
            else
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
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
            LbxCadastrados.SelectedIndex = -1;
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (LbxCadastrados.SelectedIndex >= 0)
            {
                _academia.DeletarModalidade(LbxCadastrados.SelectedIndex);
                AtualizarLbx();
                Limpar();
            }
        }

        private void BtnNovaModalidade_Click(object sender, EventArgs e)
        {
            Limpar();
            BtnCadastrarModalidade.Text = "Cadastrar Modalidade";
            indice = -1;
            BtnNovaModalidade.Hide();
            BtnDeletar.Hide();
            BtnNovo.Show();
        }

        private void LbxCadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LbxCadastrados.SelectedIndex >= 0 )
            {
                indice = LbxCadastrados.SelectedIndex;
                BtnCadastrarModalidade.Text = "Atualizar";
                BtnNovaModalidade.Show();
                BtnDeletar.Show();
                BtnNovo.Hide();
                CmbProfessor.SelectedItem = _academia.ListaModalidades[indice].Professor;
                CmbDiasSemanas.SelectedItem = _academia.ListaModalidades[indice].VezesSemana;
                TxtNomeModalidade.Text = _academia.ListaModalidades[indice].Nome;
                MskPrecoHora.Text = _academia.ListaModalidades[indice].PrecoHora.ToString();
            }
        }
    }
}
