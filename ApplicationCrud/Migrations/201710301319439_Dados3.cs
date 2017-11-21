namespace ApplicationCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dados3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Carroes", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carroes", "Name", c => c.String());
        }
    }
}
