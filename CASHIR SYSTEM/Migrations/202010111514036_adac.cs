namespace CASHIR_SYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adac : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "TABLES.OrderLst",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItemID = c.Int(),
                        NameITEM = c.String(),
                        Size = c.String(),
                        Quantity = c.Int(),
                        TPrice_for_Item = c.Decimal(precision: 18, scale: 2),
                        Price_Item = c.Decimal(precision: 18, scale: 2),
                        DateTime = c.DateTime(),
                        DateID = c.String(),
                        ByTables_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("TABLES.ByTables", t => t.ByTables_ID)
                .Index(t => t.ByTables_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("TABLES.OrderLst", "ByTables_ID", "TABLES.ByTables");
            DropIndex("TABLES.OrderLst", new[] { "ByTables_ID" });
            DropTable("TABLES.OrderLst");
        }
    }
}
