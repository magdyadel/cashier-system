namespace CASHIR_SYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sfv : DbMigration
    {
        public override void Up()
        {
            AlterColumn("TABLES.orderlst", "DateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("TABLES.orderlst", "DateTime", c => c.DateTime(nullable: false));
        }
    }
}
