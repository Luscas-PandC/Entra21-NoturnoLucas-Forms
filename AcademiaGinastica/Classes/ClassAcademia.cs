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

        public void AddAluno(string nome, string cpf, string telefone, string turno)
        {
            ListaAlunos.Add(new Aluno(nome, telefone, cpf, turno));
        }

        public void AddProfessor(string nome, string telefone, string cpf, string turno)
        {
            ListaProfessores.Add(new Professor()
            {
                Nome = nome,
                Telefone = telefone,
                CPF = cpf,
                Turno = turno
            });
        }

        public void AddModalidade(Professor professor, int vezesSemana, double precoHora, string nome)
        {
            ListaModalidades.Add(new Modalidade()
            {
                Professor = professor,
                VezesSemana = vezesSemana,
                PrecoHora = precoHora,
                Nome = nome
            });
        }

        public void AtualizarAluno(
            int indice,
            string nome,
            string telefone,
            string cpf,
            string turno
            )
        {
            ListaAlunos[indice].Nome = nome;
            ListaAlunos[indice].Telefone = telefone;
            ListaAlunos[indice].CPF = cpf;
            ListaAlunos[indice].Turno = turno;
        }

        public void AtualizarProfessor(
            int indice,
            string nome,
            string telefone,
            string cpf,
            string turno)
        {
            ListaProfessores[indice].Nome = nome;
            ListaProfessores[indice].Telefone = telefone;
            ListaProfessores[indice].CPF = cpf;
            ListaProfessores[indice].Turno = turno;
        }

        public void AtualizarModalidade(
            int indice,
            string nome,
            double precoHora,
            Professor professor,
            int vezesSemana)
        {
            ListaModalidades[indice].Nome = nome;
            ListaModalidades[indice].PrecoHora = precoHora;
            ListaModalidades[indice].Professor = professor;
            ListaModalidades[indice].VezesSemana = vezesSemana;
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
