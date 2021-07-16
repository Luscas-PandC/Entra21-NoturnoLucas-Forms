using AcademiaGinastica.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaGinastica.ClassPessoa
{
    public class Aluno : Pessoa
    {
        public Modalidade Modalidade { get; set; }

        public string Pagou { get; set; }  

        public Aluno(string nome, string cpf, string telefone, Modalidade modalidade)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Pagou = "Não.";
            Modalidade = modalidade;
        }

        public override string ToString()
        {
            return $"{Nome} - {Modalidade.Nome}- {Modalidade.Professor.Turno} - Pagou: {Pagou}";
        }
    }
}
