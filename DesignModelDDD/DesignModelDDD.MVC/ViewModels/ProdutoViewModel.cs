using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DesignModelDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} de Caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} de Caracteres")]
        public string Nome { get; set; }
        
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999")]
        [Required(ErrorMessage = "Preencha o Valor")]       
        public decimal Valor { get; set; }

        [DisplayName("Disponivel")]
        public bool Disponivel { get; set; }

        public int ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
    }
}
