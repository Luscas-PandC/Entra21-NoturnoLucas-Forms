using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaEF6.Dominio
{
    class Modalidade
    {
        [Key, MaxLength(100)]
        public int IdModalidade { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
        public int VezesSemana { get; set; }
        public double PrecoHora { get; set; }
        public virtual Professor Professor { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
