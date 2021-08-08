using System.ComponentModel.DataAnnotations;

namespace ControleEstoqueComEF6
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [MaxLength(100), Required]
        public string Nome { get; set; }
    }
}
