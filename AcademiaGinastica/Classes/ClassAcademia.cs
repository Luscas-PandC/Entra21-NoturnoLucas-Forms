using AcademiaGinastica.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaGinastica.ClassPessoa
{
    public class Academia
    {
        public List<Aluno> ListaAlunos { get; set; }

        public List<Professor> ListaProfessores { get; set; }

        public List<Modalidade> ListaModalidades { get; set; }
        
        public Academia()
        {
            ListaAlunos = new List<Aluno>();
            ListaProfessores = new List<Professor>();
            ListaModalidades = new List<Modalidade>();
        }

        public void AddAluno(string nome, string cpf, string telefone, Modalidade modalidade, string turno, int diasSemana, double mensalidade)
        {
            ListaAlunos.Add(new Aluno(nome, cpf, telefone, modalidade, turno, diasSemana, mensalidade));
        }

        public void AddProfessor(string nome, string telefone, string cpf, double precoHora)
        {
            ListaProfessores.Add(new Professor(nome, telefone, cpf, precoHora));
        }

        public void AddModalidade(string nome, Professor professor)
        {
            ListaModalidades.Add(new Modalidade(nome, professor));
        }


        public void AtualizarAluno(int indice, string nome, string cpf, string telefone, Modalidade modalidade, string turno, int diasSemana, double mensalidade)
        {
            ListaAlunos[indice].Nome = nome;
            ListaAlunos[indice].CPF = cpf;
            ListaAlunos[indice].Telefone = telefone;
            ListaAlunos[indice].Modalidade = modalidade;
            ListaAlunos[indice].Turno = turno;
            ListaAlunos[indice].DiasSemana = diasSemana;
            ListaAlunos[indice].Mensalidade = mensalidade;
        }

        public void AtualizarProfessor(int indice, string nome, string cpf, string telefone, double salarioHora)
        {
            ListaProfessores[indice].Nome = nome;
            ListaProfessores[indice].CPF = cpf;
            ListaProfessores[indice].Telefone = telefone;
            ListaProfessores[indice].SalarioHora = salarioHora;
        }

        public void AtualizarModalidade(int indice, string nome, Professor professor)
        {
            ListaModalidades[indice].Nome = nome;
            ListaModalidades[indice].Professor = professor;
        }


        public void DeletarAluno(int indice)
        {
            ListaAlunos.RemoveAt(indice);
        }

        public void DeletarProfessor(int indice)
        {
            ListaProfessores.RemoveAt(indice);
        }

        public void DeletarModalidade(int indice)
        {
            ListaModalidades.RemoveAt(indice);
        }
    }
}
