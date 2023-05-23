using ControleTarefas.API.Data.Map;
using ControleTarefas.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleTarefas.API.Data
{
    public class ControleTarefasDBContext : DbContext
    {
        public ControleTarefasDBContext(DbContextOptions<ControleTarefasDBContext> options) : base(options) { 
        
        }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
