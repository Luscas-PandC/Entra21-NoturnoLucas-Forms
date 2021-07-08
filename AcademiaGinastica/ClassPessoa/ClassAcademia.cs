using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaGinastica.ClassPessoa
{
    public class ClassAcademia 
    {
        public List<Aluno> AlunosAcademia { get; private set; }

        public ClassAcademia()
        {
            AlunosAcademia = new List<Aluno>();
        }

        public void AddClassA(string nome, string cpf, string rg, string turma)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = nome;
            aluno.CPF = cpf;
            aluno.RG = rg;
            aluno.Turma = turma;
            AlunosAcademia.Add(aluno);
        }
        public void UpdateAluno(int indec, string nome, string cpf, string rg, string turma)
        {
            AlunosAcademia[indec].Nome = nome;
            AlunosAcademia[indec].CPF = cpf;
            AlunosAcademia[indec].RG = rg;
            AlunosAcademia[indec].Turma = turma;
        }
        public void PlanoSelecionado(int indec, System.Windows.Forms.RadioButton radioBtn1, System.Windows.Forms.RadioButton radioBtn2)
        {
            if(radioBtn1.Checked)
            {
                AlunosAcademia[indec].plano = "Basic";
            }
            if(radioBtn2.Checked)
            {
                AlunosAcademia[indec].plano = "Advanced";
            }
        }
    }
}
