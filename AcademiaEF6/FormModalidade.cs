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
    public partial class FormModalidade : Form
    {
        Modalidade modalidade;
        public FormModalidade(Modalidade _modalidade)
        {
            InitializeComponent();
            modalidade = _modalidade;
        }

        private void FormModalidade_Load(object sender, EventArgs e)
        {
            txtNomeModalidade.DataBindings.Add("Text", modalidade, "Nome");
            txtPrecoHora.DataBindings.Add("Text", modalidade, "PrecoHora");
            txtVezesSemana.DataBindings.Add("Text", modalidade, "VezesSemana");
            professorBindingSource.DataSource = new AcademiaContext().Professores.ToList();

            cbxProfessor.DataBindings.Add("SelectedItem", modalidade, "Professor");

            if (modalidade.Professor == null)
            {
                cbxProfessor.SelectedItem = null;
            }
            else
            {
                foreach (var item in cbxProfessor.Items)
                {
                    var professor = item as Professor;
                    if (professor == null) return;
                    if (professor.CPF == modalidade.Professor.CPF)
                    {
                        cbxProfessor.SelectedItem = item;
                    }
                }
            }
        }
    }
}
