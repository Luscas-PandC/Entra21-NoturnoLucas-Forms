using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaGinastica.ClassPessoa
{
    public class ClassA : ClassP
    {
        public string Turma { get; set; }
        public decimal Mensalidade { get; set; }
        public bool Paga { get; set; }  
        public ClassA()
        {
            
        }
    }
}
