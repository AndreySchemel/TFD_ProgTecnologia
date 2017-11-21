namespace ApplicationCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dados2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Nome", c => c.String());
            AddColumn("dbo.Funcionarios", "Nome", c => c.String());
            DropColumn("dbo.Clientes", "Name");
            DropColumn("dbo.Funcionarios", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Funcionarios", "Name", c => c.String());
            AddColumn("dbo.Clientes", "Name", c => c.String());
            DropColumn("dbo.Funcionarios", "Nome");
            DropColumn("dbo.Clientes", "Nome");
        }
    }
}
