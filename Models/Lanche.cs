using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LancheMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O nome do lanche deve ser informado")]
        [Required(ErrorMessage = "Informe o nome do lache")]
        [Display(Name = "Nome do Lanche")]
        public string Nome { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
        [Display(Name = "Descrição do Lanche")]
        [MaxLength(200, ErrorMessage = "Tamanho máximo da descrição é 200 caracteres")]
        public string DescricaoCurta { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
        [Display(Name = "Descrição do Lanche")]
        [MaxLength(200, ErrorMessage = "Tamanho máximo da descrição é 200 caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "O Preço deve ser informado")]
        [Display(Name = "preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve está entre 1 a 999.99")]
        public decimal Preco { get; set; }

        [Display(Name = "Imagem em Minhatura")]
        [StringLength(200, ErrorMessage = "Tamanho máximo da descrição é 200 caracteres")]
        public string ImageUrl { get; set; }

        [Display(Name = "Imagem em Minhatura")]
        [StringLength(200, ErrorMessage = "Tamanho máximo da descrição é 200 caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }


        public int CategoriaID { get; set; }

        public virtual Categoria Categoria { get; set; }


    }
}
