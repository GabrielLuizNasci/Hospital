using Microsoft.EntityFrameworkCore;

namespace Hospital.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
    }
}
