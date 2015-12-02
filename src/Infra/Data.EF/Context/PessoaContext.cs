using System.Data.Entity;
using LGroup.Arquitetura.DDD.Data.EF.Maps;
using LGroup.Arquitetura.DDD.Domain.Entities;

namespace LGroup.Arquitetura.DDD.Data.EF.Context
{
    public class PessoaContext : DbContext
    {
        public PessoaContext() : base(@"Data Source=(localdb)\ProjectsV12;Initial Catalog=PessoaDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")
        { }

        public DbSet<PessoaEntity> PessoaEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PessoaEntityMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
