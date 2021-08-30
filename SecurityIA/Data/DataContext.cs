using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SecurityIA.Data.Entities;

namespace SecurityIA.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<PreguntaUsuario> PreguntaUsuarios { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<HistoryPassword> HistoryPasswords { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Objeto> Objetos { get; set; }

    }
}
