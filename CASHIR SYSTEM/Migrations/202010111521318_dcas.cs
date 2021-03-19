namespace CASHIR_SYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dcas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("TABLES.OrderLst", "ByTables_ID", "TABLES.ByTables");
            DropIndex("TABLES.OrderLst", new[] { "ByTables_ID" });
            RenameColumn(table: "TABLES.OrderLst", name: "ByTables_ID", newName: "TableID");
            AlterColumn("TABLES.OrderLst", "TableID", c => c.Int(nullable: false));
            CreateIndex("TABLES.OrderLst", "TableID");
            AddForeignKey("TABLES.OrderLst", "TableID", "TABLES.ByTables", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("TABLES.OrderLst", "TableID", "TABLES.ByTables");
            DropIndex("TABLES.OrderLst", new[] { "TableID" });
            AlterColumn("TABLES.OrderLst", "TableID", c => c.Int());
            RenameColumn(table: "TABLES.OrderLst", name: "TableID", newName: "ByTables_ID");
            CreateIndex("TABLES.OrderLst", "ByTables_ID");
            AddForeignKey("TABLES.OrderLst", "ByTables_ID", "TABLES.ByTables", "ID");
        }
    }
}
