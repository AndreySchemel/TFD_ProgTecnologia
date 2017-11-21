namespace ApplicationCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateValidations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Email", c => c.String());
            AlterColumn("dbo.Clientes", "NumeroCNH", c => c.String(nullable: false));
            AlterColumn("dbo.Funcionarios", "Cargo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Funcionarios", "Cargo", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Clientes", "NumeroCNH", c => c.String());
            AlterColumn("dbo.Clientes", "Email", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
