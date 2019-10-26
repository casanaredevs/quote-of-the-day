using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using QOTD.Models;

namespace QOTD.DataAccess
{
    public class QuoteDbContext : DbContext
    {
        public DbSet<Frase> Frases { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public QuoteDbContext()
        {
            
        }
        public QuoteDbContext(DbContextOptions<QuoteDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //EFCore por defecto pluraliza las tablas. Con esto deshabilitamos esta opción
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                entityType.SetTableName(entityType.DisplayName());
            }
        }
    }
}
