namespace ApplicationCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dados4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clientes", "Carro_Id", "dbo.Carroes");
            DropIndex("dbo.Clientes", new[] { "Carro_Id" });
            DropColumn("dbo.Clientes", "CarroId");
            RenameColumn(table: "dbo.Clientes", name: "Carro_Id", newName: "CarroId");
            AddColumn("dbo.Empresas", "CapitalSocial", c => c.Double(nullable: false));
            AddColumn("dbo.Empresas", "TipoEmpresa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Funcionarios", "Matricula", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "Telefone", c => c.Long(nullable: false));
            AlterColumn("dbo.Clientes", "CarroId", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "CarroId", c => c.Int(nullable: false));
            AlterColumn("dbo.Empresas", "NumeroTelefone", c => c.Long(nullable: false));
            AlterColumn("dbo.Funcionarios", "Telefone", c => c.Long(nullable: false));
            CreateIndex("dbo.Clientes", "CarroId");
            AddForeignKey("dbo.Clientes", "CarroId", "dbo.Carroes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "CarroId", "dbo.Carroes");
            DropIndex("dbo.Clientes", new[] { "CarroId" });
            AlterColumn("dbo.Funcionarios", "Telefone", c => c.Int(nullable: false));
            AlterColumn("dbo.Empresas", "NumeroTelefone", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "CarroId", c => c.Int());
            AlterColumn("dbo.Clientes", "CarroId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Clientes", "Telefone", c => c.Int(nullable: false));
            DropColumn("dbo.Funcionarios", "Matricula");
            DropColumn("dbo.Empresas", "TipoEmpresa");
            DropColumn("dbo.Empresas", "CapitalSocial");
            RenameColumn(table: "dbo.Clientes", name: "CarroId", newName: "Carro_Id");
            AddColumn("dbo.Clientes", "CarroId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Clientes", "Carro_Id");
            AddForeignKey("dbo.Clientes", "Carro_Id", "dbo.Carroes", "Id");
        }
    }
}
