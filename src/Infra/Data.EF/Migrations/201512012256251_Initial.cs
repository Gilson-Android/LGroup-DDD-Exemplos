namespace LGroup.Arquitetura.DDD.Data.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExemploArquiteturaDdd",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Sexo = c.Int(nullable: false),
                        Idade = c.Int(nullable: false),
                        Nome = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExemploArquiteturaDdd");
        }
    }
}
