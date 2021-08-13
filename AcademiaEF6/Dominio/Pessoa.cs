using System.ComponentModel.DataAnnotations;

namespace AcademiaEF6.Dominio
{
    public class Pessoa
    {
        [Key, MaxLength(14)]
        public string CPF { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(15)]
        public string Telefone { get; set; }
    }
}
