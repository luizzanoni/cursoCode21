
using System.ComponentModel.DataAnnotations;

namespace Catalogo.MeuNamespace
{
    public class Filme
    {
        [Range(1,50)]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O campo T�tulo � obrigat�rio")]
        [StringLength(20)]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "O campo Sinopse � obrigat�rio")]
        [StringLength(2000)]
        public string? Sinopse { get; set; }
        [Required(ErrorMessage = "O campo Lan�amento � obrigat�rio")]
        public DateTime Lancamento { get; set; }
        [StringLength(50)]
        public string? Categoria { get; set; }
        public bool EmCartaz { get; set; }
    }

}