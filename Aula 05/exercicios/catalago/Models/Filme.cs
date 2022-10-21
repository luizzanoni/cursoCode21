
using System.ComponentModel.DataAnnotations;

namespace Catalogo.MeuNamespace
{
    public class Filme
    {
        [Range(1,50)]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório")]
        [StringLength(20)]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Sinopse é obrigatório")]
        [StringLength(2000)]
        public string Sinopse { get; set; }
        [Required(ErrorMessage = "O campo Lançamento é obrigatório")]
        public DateTime Lancamento { get; set; }
        [StringLength(50)]
        [EmailAddress]
        public string Categoria { get; set; }
        public bool EmCartaz { get; set; }
    }

}