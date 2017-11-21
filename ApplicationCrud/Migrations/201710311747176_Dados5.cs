namespace ApplicationCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dados5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "NumeroCNH", c => c.String());
            AlterColumn("dbo.Carroes", "Marca", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Carroes", "Modelo", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Clientes", "Nome", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Clientes", "CPF", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Clientes", "Email", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Empresas", "Cnpj", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Empresas", "NomeEmpresa", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Funcionarios", "Nome", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Funcionarios", "Cargo", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Funcionarios", "Cargo", c => c.String());
            AlterColumn("dbo.Funcionarios", "Nome", c => c.String());
            AlterColumn("dbo.Empresas", "NomeEmpresa", c => c.String());
            AlterColumn("dbo.Empresas", "Cnpj", c => c.String());
            AlterColumn("dbo.Clientes", "Email", c => c.String());
            AlterColumn("dbo.Clientes", "CPF", c => c.String());
            AlterColumn("dbo.Clientes", "Nome", c => c.String());
            AlterColumn("dbo.Carroes", "Modelo", c => c.String());
            AlterColumn("dbo.Carroes", "Marca", c => c.String());
            DropColumn("dbo.Clientes", "NumeroCNH");
        }
    }
}
