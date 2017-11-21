namespace ApplicationCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dados : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cor = c.String(),
                        Placa = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                        ValorLocacao = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CPF = c.String(),
                        Email = c.String(),
                        RG = c.String(),
                        Telefone = c.Int(nullable: false),
                        Carro_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carroes", t => t.Carro_Id)
                .Index(t => t.Carro_Id);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cnpj = c.String(),
                        NomeEmpresa = c.String(),
                        NumeroTelefone = c.Int(nullable: false),
                        Endereco = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cargo = c.String(),
                        Telefone = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "Carro_Id", "dbo.Carroes");
            DropIndex("dbo.Clientes", new[] { "Carro_Id" });
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Empresas");
            DropTable("dbo.Clientes");
            DropTable("dbo.Carroes");
        }
    }
}
