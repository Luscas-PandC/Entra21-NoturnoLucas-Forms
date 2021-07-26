using AcademiaGinastica.ClassPessoa;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaGinastica.Classes
{
    public class Professor : Pessoa
    {
        public double SalarioHora { get; set; }

        public Professor(string nome, string cpf, string telefone, double salarioHora)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            SalarioHora = salarioHora;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
