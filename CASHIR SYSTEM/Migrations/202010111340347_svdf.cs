namespace CASHIR_SYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class svdf : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("TABLES.orderlst", "ByTables_ID", "TABLES.ByTables");
            DropIndex("TABLES.orderlst", new[] { "ByTables_ID" });
            DropTable("TABLES.orderlst");
        }
        
        public override void Down()
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
                        DateTime = c.DateTime(),
                        DateID = c.String(),
                        ByTables_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("TABLES.orderlst", "ByTables_ID");
            AddForeignKey("TABLES.orderlst", "ByTables_ID", "TABLES.ByTables", "ID");
        }
    }
}
