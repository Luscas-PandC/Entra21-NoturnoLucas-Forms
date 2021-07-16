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

        FrmMenu _frmMenu;

        int indice = -1;

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
                _frmMenu.VerificandoListas();
            }
            AtualizarLbx();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (LbxCadastrados.SelectedIndex >= 0)
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
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
            LbxCadastrados.SelectedIndex = -1;
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
    }
}
