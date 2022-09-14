namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200, unicode: false),
                        EstadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estadoes", t => t.EstadoId, cascadeDelete: true)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200, unicode: false),
                        Uf = c.String(nullable: false, maxLength: 2, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrevisaoClimas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 15, unicode: false),
                        TemperaturaMinima = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cidades", "EstadoId", "dbo.Estadoes");
            DropIndex("dbo.Cidades", new[] { "EstadoId" });
            DropTable("dbo.PrevisaoClimas");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Cidades");
        }
    }
}
