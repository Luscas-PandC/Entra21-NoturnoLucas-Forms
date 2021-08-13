using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaEF6.Dominio
{
    class Professor: Pessoa
    {
        [MaxLength(20)]
        public string Turno { get; set; }
        public double SalarioHora { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
