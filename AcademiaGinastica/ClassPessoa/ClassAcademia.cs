using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaGinastica.ClassPessoa
{
    public class ClassAcademia : ClassA
    {
        public List<ClassAcademia> alunosAcademia;
        public ClassAcademia(string nome, string cpf, string rg, string turma, decimal mensalidade, bool paga)
        {
            nome = Nome;
            cpf = CPF;
            rg = RG;
            turma = Turma;
            mensalidade = Mensalidade;
            paga = Paga;
            alunosAcademia = new List<ClassAcademia>();
        }
    }
}
