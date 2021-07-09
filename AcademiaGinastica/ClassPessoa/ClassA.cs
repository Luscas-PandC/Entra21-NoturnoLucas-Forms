using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaGinastica.ClassPessoa
{
    public class Aluno : Pessoa
    {
        public string Turma { get; set; }
        public int Mensalidade { get; set; }
        public bool Paga { get; set; }  
        public string plano { get; set; }
        public bool Rbtn1 { get; set; }
        public bool Rbtn2 { get; set; }

        public Aluno()
        {
            
        }
        public override string ToString()
        {
            string pago = "";
            if(Paga)
            {
                pago = "pago";
            }
            else
            {
                pago = "Não pago";
            }

            return $"{Nome}, plano {plano}, {pago}";
        }
    }
}
