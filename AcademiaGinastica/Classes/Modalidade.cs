using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaGinastica.Classes
{
    public class Modalidade : IMensalidade
    {
        public Professor Professor { get; set; }

        public string Nome { get; set; }

        public Modalidade(string nome, Professor professor)
        {
            Nome = nome;
            Professor = professor;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }

        public double CalculaValor(int diasSemana)
        {
            double mensalidade;
            mensalidade = (Professor.SalarioHora * 4) * diasSemana * 4;
            return mensalidade;
        }
    }
}
