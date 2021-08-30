using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SecurityIA.Data.Entities
{
    public class User:IdentityUser
    {
        [Display(Name = "DNI")]
        [MaxLength(20, ErrorMessage = "* Solo se permiten números.")]
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(100)]
        public string Address { get; set; }
      
        public int PreguntasContestadas { get; set; }

        public int PrimerIngreso { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public DateTime FechaUltimaConexion { get; set; }

        public ICollection<PreguntaUsuario> PreguntasUsuario { get; set; }

        public ICollection<Parametro> Parametros { get; set; }

        public ICollection<HistoryPassword> HistoryPasswords { get; set; }

        [Display(Name = "Nombre Completo")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        // TODO: Change the path when publish
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://myleasing.azurewebsites.net{ImageUrl[1..]}";

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
