namespace ApplicationCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dados1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "CarroId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "CarroId");
        }
    }
}
