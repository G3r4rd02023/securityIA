using System.ComponentModel.DataAnnotations;

namespace SecurityIA.Data.Entities
{
    public class Objeto
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Objeto")]
        public string Name { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [MaxLength(15, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Tipo de Objeto")]
        public string TipoObjeto { get; set; }

    }
}
