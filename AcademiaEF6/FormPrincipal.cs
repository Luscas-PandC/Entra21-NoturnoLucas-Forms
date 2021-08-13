using AcademiaEF6.Dominio;
using AcademiaEF6.Repository;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnNovoProfessor_Click(object sender, EventArgs e)
        {
            if(sender == btnNovoProfessor)
            {
                professorBindingSource.Add(new Professor());
                professorBindingSource.MoveLast();
            }

            var professor = professorBindingSource.Current as Professor;

            if (professor == null) return;

            using (var frmProfessor = new FormProfessor(professor))
            {
                if (frmProfessor.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new AcademiaContext())
                    {
                        if (new RepositorioProfessor().AddOrUpdate(professor, sender == btnNovoProfessor) > 0)
                        {
                            dgvProfessor.Refresh();
                            MessageBox.Show($"Professor \"{professor.Nome}\" salvo com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Professor \"{professor.Nome}\" não pôde ser salvo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    if (sender == btnNovoProfessor)
                    {
                        professorBindingSource.MoveLast();
                        professorBindingSource.RemoveCurrent();
                    }
                }
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            using (var db = new AcademiaContext())
            {
                professorBindingSource.DataSource = db.Professores.ToList();
                modalidadeBindingSource.DataSource = db.Modalidades.ToList();
                alunoBindingSource.DataSource = db.Alunos.ToList();
            }
        }

        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            var professor = professorBindingSource.Current as Professor;
            
            if (professor == null) return;

            if (MessageBox.Show($"Comfirmar a exclusão do professor {professor.Nome}?",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (new RepositorioProfessor().Delete(professor) > 0)
                {
                    professorBindingSource.Remove(professor);
                    dgvProfessor.Refresh();
                    MessageBox.Show($"Professor \"{professor.Nome}\" deletado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Professor \"{professor.Nome}\" não pôde ser deletado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnNovaModalidade_Click(object sender, EventArgs e)
        {
            if (sender == btnNovaModalidade)
            {
                modalidadeBindingSource.Add(new Modalidade());
                modalidadeBindingSource.MoveLast();
            }

            var modalidade = modalidadeBindingSource.Current as Modalidade;

            if (modalidade == null) return;

            using (var frmModalidade = new FormModalidade(modalidade))
            {
                if (frmModalidade.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new AcademiaContext())
                    {
                        if (new RepositorioModalidade().AddOrUpdate(modalidade, sender == btnNovoProfessor) > 0)
                        {
                            dgvProfessor.Refresh();
                            MessageBox.Show($"Modalidade \"{modalidade.Nome}\" salva com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Modalidade \"{modalidade.Nome}\" não pôde ser salva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    if (sender == btnNovoProfessor)
                    {
                        professorBindingSource.MoveLast();
                        professorBindingSource.RemoveCurrent();
                    }
                }
            }
        }
    }
}
