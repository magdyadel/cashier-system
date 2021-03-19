namespace CASHIR_SYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addf : DbMigration
    {
        public override void Up()
        {
            AddColumn("TABLES.ByTables", "check", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("TABLES.ByTables", "check");
        }
    }
}
