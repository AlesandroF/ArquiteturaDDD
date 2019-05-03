using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArquiteturaDDD.MVC.Models.Produto
{
    public class ProdutoViewModel
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "The cost price is Required")]
        [DisplayName("Preço de Custo")]
        public decimal PrecoCusto { get; set; }

        [Required(ErrorMessage = "The Sale price is Required")]
        [DisplayName("Preço de Venda")]
        public decimal PrecoVenda { get; set; }

        [Required(ErrorMessage = "The brand is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Marca")]
        public string Marca { get; set; }
    }
}