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

        FrmProfessor frmProfessor;
        FrmModalidade frmModalidade;
        FrmAluno frmAluno;

        public FrmMenu()
        {
            academia = new Academia();
            InitializeComponent();
            BtnModalidade.Enabled = false;
            BtnAlunos.Enabled = false;
        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            PnlPrincipal.Show();
            frmProfessor.TopLevel = false;
            PnlPrincipal.Controls.Clear();
            PnlPrincipal.Controls.Add(frmProfessor);
            frmProfessor.Show();
        }

        private void BtnModalidade_Click(object sender, EventArgs e)
        {
            btnProfessores.Hide();
            BtnModalidade.Hide();
            BtnAlunos.Hide();
            frmModalidade.TopLevel = false;
            frmModalidade.MdiParent = this;
            int sizeW = frmModalidade.Size.Width;
            int sizeH = frmModalidade.Size.Height;
            Size = new Size(533, 235);
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

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            frmProfessor = new FrmProfessor(academia, this);
            frmModalidade = new FrmModalidade(academia, this);
            frmAluno = new FrmAluno(academia);
            PnlPrincipal.Hide();
        }
        public void HabilitarBtns()
        {
            btnProfessores.Show();
            BtnModalidade.Show();
            BtnAlunos.Show();
        }
    }
}
