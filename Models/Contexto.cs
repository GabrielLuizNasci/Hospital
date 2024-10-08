using Microsoft.EntityFrameworkCore;

namespace Hospital.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Cidade> Cidades { get; set; }
    }
}
