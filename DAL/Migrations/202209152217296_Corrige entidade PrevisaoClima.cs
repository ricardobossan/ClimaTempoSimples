namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrigeentidadePrevisaoClima : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PrevisaoClimas", "TemperaturaMaxima", c => c.Single(nullable: false));
            AddColumn("dbo.PrevisaoClimas", "DataPrevisao", c => c.DateTime(nullable: false));
            AddColumn("dbo.PrevisaoClimas", "CidadeId", c => c.Int(nullable: false));
            CreateIndex("dbo.PrevisaoClimas", "CidadeId");
            AddForeignKey("dbo.PrevisaoClimas", "CidadeId", "dbo.Cidades", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrevisaoClimas", "CidadeId", "dbo.Cidades");
            DropIndex("dbo.PrevisaoClimas", new[] { "CidadeId" });
            DropColumn("dbo.PrevisaoClimas", "CidadeId");
            DropColumn("dbo.PrevisaoClimas", "DataPrevisao");
            DropColumn("dbo.PrevisaoClimas", "TemperaturaMaxima");
        }
    }
}
