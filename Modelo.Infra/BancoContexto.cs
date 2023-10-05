using Microsoft.EntityFrameworkCore;
using Modelo.Domain;
using Modelo.Infra.Mapeamento;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Modelo.Infra
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapeamento());
        }



        public DbSet<Aluno> Aluno { get; set; }
    }
}