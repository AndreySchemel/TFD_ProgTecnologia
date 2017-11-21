namespace ApplicationCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationProjeto1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Carroes", newName: "c");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.c", newName: "Carroes");
        }
    }
}
