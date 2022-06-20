
using EFCore.WebAPI2.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebAPI2.Data 
{ 

    public class HeroiContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadesSecretas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {                                        // String de Conexão usada para se conectar com o banco de dados 
            optionsBuilder.UseSqlServer("Data source = LAPTOP-6BE1L0TC\\SQLEXPRESS;Initial Catalog = HeroAppDataBase; Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity =>
            {          //tem chave(haskey)
                entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
            });
        }
    }
}
