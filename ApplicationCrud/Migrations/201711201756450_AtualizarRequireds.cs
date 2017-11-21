namespace ApplicationCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizarRequireds : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Carroes", "Placa", c => c.String(nullable: false));
            AlterColumn("dbo.Funcionarios", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Funcionarios", "Email", c => c.String());
            AlterColumn("dbo.Carroes", "Placa", c => c.String());
        }
    }
}
