namespace CASHIR_SYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sss : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "Orders.ByTables", newSchema: "TABLES");
        }
        
        public override void Down()
        {
            MoveTable(name: "TABLES.ByTables", newSchema: "Orders");
        }
    }
}
