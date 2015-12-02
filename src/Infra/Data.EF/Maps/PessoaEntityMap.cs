using System.Data.Entity.ModelConfiguration;
using System.Net;
using LGroup.Arquitetura.DDD.Domain.Entities;

namespace LGroup.Arquitetura.DDD.Data.EF.Maps
{
    public class PessoaEntityMap : EntityTypeConfiguration<PessoaEntity>
    {
        public PessoaEntityMap()
        {
            ToTable("ExemploArquiteturaDdd");

            HasKey(x => x.Codigo);

            Property(x => x.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(30);
        }
    }
}
