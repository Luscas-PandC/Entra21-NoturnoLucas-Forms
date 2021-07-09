using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaGinastica.ClassPessoa
{
    public class Academia 
    {
        public List<Aluno> AlunosAcademia { get; private set; }

        public Academia()
        {
            AlunosAcademia = new List<Aluno>();
        }

        public void AddClassA(string nome, string cpf, string rg, string turma, System.Windows.Forms.RadioButton radioBtn1, System.Windows.Forms.RadioButton radioBtn2)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = nome;
            aluno.CPF = cpf;
            aluno.RG = rg;
            aluno.Rbtn1 = radioBtn1.Checked;
            aluno.Rbtn2 = radioBtn2.Checked;
            aluno.Turma = turma;
            aluno.Paga = false;
            aluno.plano = PlanoSelecionado(radioBtn1, radioBtn2);
            AlunosAcademia.Add(aluno);
        }
        public void UpdateAluno(int ind, string nome, string cpf, string rg, string turma, System.Windows.Forms.RadioButton radioBtn1, System.Windows.Forms.RadioButton radioBtn2)
        {
            AlunosAcademia[ind].Nome = nome;
            AlunosAcademia[ind].CPF = cpf;
            AlunosAcademia[ind].RG = rg;
            AlunosAcademia[ind].Turma = turma;
            AlunosAcademia[ind].Rbtn1 = radioBtn1.Checked;
            AlunosAcademia[ind].Rbtn2 = radioBtn2.Checked;
            AlunosAcademia[ind].plano = PlanoSelecionado(radioBtn1, radioBtn2);
        }
        public string PlanoSelecionado(System.Windows.Forms.RadioButton radioBtn1, System.Windows.Forms.RadioButton radioBtn2)
        {
            if(radioBtn1.Checked)
            {
               return "Basic";
            }
            if(radioBtn2.Checked)
            {
                return "Advanced";
            }
            return "";
        }
    }
}
