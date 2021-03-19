namespace CASHIR_SYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "TABLES.orderlst",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItemID = c.Int(nullable: false),
                        NameITEM = c.String(),
                        Size = c.String(),
                        Quantity = c.Int(nullable: false),
                        TPrice_for_Item = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price_Item = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateTime = c.DateTime(nullable: false),
                        DateID = c.String(),
                        ByTables_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("TABLES.ByTables", t => t.ByTables_ID)
                .Index(t => t.ByTables_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("TABLES.orderlst", "ByTables_ID", "TABLES.ByTables");
            DropIndex("TABLES.orderlst", new[] { "ByTables_ID" });
            DropTable("TABLES.orderlst");
        }
    }
}
