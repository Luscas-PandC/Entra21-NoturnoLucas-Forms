using AcademiaEF6.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaEF6
{
    public partial class FormProfessor : Form
    {
        Professor professor;
        public FormProfessor(Professor _professor)
        {
            InitializeComponent();
            professor = _professor;
        }

        private void FormProfessor_Load(object sender, EventArgs e)
        {
            txtNome.DataBindings.Add("Text", professor, "Nome");
            txtSalarioHora.DataBindings.Add("Text", professor, "SalarioHora");
            txtTurno.DataBindings.Add("Text", professor, "Turno");
            txtTelefone.DataBindings.Add("Text", professor, "Telefone");
            txtCPF.DataBindings.Add("Text", professor, "CPF");

            txtCPF.Enabled = String.IsNullOrEmpty(professor.CPF);
        }
    }
}
