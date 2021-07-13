using AcademiaGinastica.ClassPessoa;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaGinastica.Classes
{
    public class Professor : Pessoa
    {
        public string Turno { get; set; }
        public double SalarioHora { get; set; }

        public override string ToString()
        {
            return $"{Nome} - {Turno}";
        }
    }
}
