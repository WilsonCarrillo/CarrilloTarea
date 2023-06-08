using CarrilloNeira.Models;
using Microsoft.EntityFrameworkCore;

namespace CarrilloNeira.Models
{
    public class AplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // El connectionString debe venir de un archivo de configuraciones
            optionsBuilder.UseSqlServer("Server=LAPTOP-NJ4RV5KH\\SQLEXPRESS;Database=CarrilloNeira;Trusted_Connection=True")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(LoggerFactory.Create(builder =>
                {
                    builder.AddConsole().SetMinimumLevel(LogLevel.Information);
                }));
        }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Genero> generos { get; set; }
    }
}
