namespace CASHIR_SYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ndf : DbMigration
    {
        public override void Up()
        {
            AlterColumn("TABLES.ByTables", "TableID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("TABLES.ByTables", "TableID", c => c.Int());
        }
    }
}
