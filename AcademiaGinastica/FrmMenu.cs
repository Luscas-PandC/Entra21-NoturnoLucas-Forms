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
    public partial class FrmMenu : Form
    {
        Academia academia;
        public FrmMenu()
        {
            academia = new Academia();
            InitializeComponent();
        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            FrmProfessor frmProfessor = new FrmProfessor(academia);
            frmProfessor.Show();
        }

        private void BtnModalidade_Click(object sender, EventArgs e)
        {
            FrmModalidade frmModalidade = new FrmModalidade(academia);
            frmModalidade.Show();
        }
    }
}
