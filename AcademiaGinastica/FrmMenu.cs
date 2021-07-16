using AcademiaGinastica.ClassPessoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcademiaGinastica
{
    public partial class FrmMenu : Form
    {
        Academia academia;
        public FrmMenu()
        {
            academia = new Academia();
            InitializeComponent();
            BtnModalidade.Enabled = false;
            BtnAlunos.Enabled = false;
        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            FrmProfessor frmProfessor = new FrmProfessor(academia, this);
            frmProfessor.Show();
        }

        private void BtnModalidade_Click(object sender, EventArgs e)
        {
            FrmModalidade frmModalidade = new FrmModalidade(academia,this);
            frmModalidade.Show();
        }

        private void BtnAlunos_Click(object sender, EventArgs e)
        {
            FrmAluno frmAluno = new FrmAluno(academia);
            frmAluno.Show();
        }

        public void VerificandoListas()
        {
            if (academia.ListaProfessores.Any())
            {
                BtnModalidade.Enabled = true;
            }
            else
            {
                BtnModalidade.Enabled = false;
                BtnAlunos.Enabled = false;
            }
            if(academia.ListaModalidades.Any())
            {
                BtnAlunos.Enabled = true;
            }
            else
            {
                BtnAlunos.Enabled = false;
            }
        }
    }
}
