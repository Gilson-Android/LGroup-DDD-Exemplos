using LGroup.Arquitetura.DDD.Data.EF.Context;
using LGroup.Arquitetura.DDD.Domain.Entities;
using LGroup.Arquitetura.DDD.Domain.ValueObjects;

namespace LGroup.Arquitetura.DDD.Data.EF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LGroup.Arquitetura.DDD.Data.EF.Context.PessoaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PessoaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.PessoaEntities.Add(new PessoaEntity(30, "Fábio", SexoValueObject.Masculino));
            context.SaveChanges();
        }
    }
}
