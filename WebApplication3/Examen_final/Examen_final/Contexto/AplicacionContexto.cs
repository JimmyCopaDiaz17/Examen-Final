using Microsoft.EntityFrameworkCore;
using WebApplication3.Modelo;

namespace WebApplication3.Contexto
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto(DbContextOptions<AplicacionContexto> options):base(options) { }
        public DbSet<Aviones> aviones { get; set; }
        public DbSet<Hangares> hangares { get; set; }
        public DbSet<Pilotos> pilotos { get; set; }
        public DbSet<Pilotos_avion> pilotos_avion { get; set; }
    }
}
