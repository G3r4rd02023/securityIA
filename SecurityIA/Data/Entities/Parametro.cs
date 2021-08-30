using System;
using System.ComponentModel.DataAnnotations;

namespace SecurityIA.Data.Entities
{
    public class Parametro
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Parametro")]
        public string Descripcion { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Valor")]
        public string Valor { get; set; }

        public User User { get; set; }

        [Display(Name = "Fecha de Creación")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime FechaCreacion { get; set; }

        [Display(Name = "Fecha de Modificación")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime FechaModificado { get; set; }



    }
}
