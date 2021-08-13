using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaEF6.Dominio
{
    public class Aluno: Pessoa
    {
        public virtual Modalidade Modalidade { get; set; }
    }
}
