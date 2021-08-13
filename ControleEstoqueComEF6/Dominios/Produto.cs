using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueComEF6.Dominios
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        [MaxLength(100),Required]
        public string Nome { get; set; }
        [Required]
        public int Estoque { get; set; }
        [Required]
        public decimal Preco { get; set; }
    }
}
