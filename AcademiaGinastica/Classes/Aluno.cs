using AcademiaGinastica.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaGinastica.ClassPessoa
{
    public class Aluno : Pessoa
    {
        public Modalidade Modalidade { get; set; }

        public string Turno { get; set; }

        public int DiasSemana { get; set; }

        public double Mensalidade { get; set; }

        public string Pagou { get; set; }

        public Aluno(string nome, string cpf, string telefone, Modalidade modalidade, string turno, int diasSemana, double mensalidade)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Modalidade = modalidade;
            Turno = turno;
            DiasSemana = diasSemana;
            Mensalidade = mensalidade;
            Pagou = "Não";
        }

        public override string ToString()
        {
            return $"{Nome} - {Modalidade.Nome} - {Turno} - Pagou: {Pagou}";
        }
    }
}
