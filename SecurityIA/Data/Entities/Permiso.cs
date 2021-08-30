using System.ComponentModel.DataAnnotations;

namespace SecurityIA.Data.Entities
{
    public class Permiso
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public Objeto Objeto { get; set; }

        [Display(Name = "Permiso de Inserción")]
        public bool PermisoInsercion { get; set; }

        [Display(Name = "Permiso de Consultar")]
        public bool PermisoConsultar { get; set; }

        [Display(Name = "Permiso de Actualización")]
        public bool PermisoActualizacion { get; set; }

        [Display(Name = "Permiso de Eliminación")]
        public bool PermisoEliminacion { get; set; }

    }
}
