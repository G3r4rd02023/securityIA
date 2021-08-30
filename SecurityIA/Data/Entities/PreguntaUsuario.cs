using System;
using System.ComponentModel.DataAnnotations;

namespace SecurityIA.Data.Entities
{
    public class PreguntaUsuario
    {
        public int Id { get; set; }

        public User User { get; set; }

        public Pregunta Pregunta { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Respuesta { get; set; }

        [Display(Name = "Creado Por")]
        public string CreadoPor { get; set; }

        [Display(Name = "Fecha de Creación")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime FechaCreacion { get; set; }

        [Display(Name = "Modificado Por")]
        public string ModificadoPor { get; set; }

        [Display(Name = "Fecha de Modificación")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime FechaModificado { get; set; }
    }
}
