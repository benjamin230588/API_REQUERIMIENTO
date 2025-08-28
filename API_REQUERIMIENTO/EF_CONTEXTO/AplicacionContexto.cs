using APP_REQUERIMIENTOS2025.Entidades;
using Microsoft.EntityFrameworkCore;

namespace APP_REQUERIMIENTOS2025.EF_CONTEXTO
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
