namespace CASHIR_SYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bfsd : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ClientLaterPaymentinfoes", newName: "ClientLaterPaymentinfo");
            RenameTable(name: "dbo.Clientsses", newName: "Clientss");
            RenameTable(name: "dbo.logins", newName: "login");
            RenameTable(name: "dbo.OrderMoneAndDates", newName: "OrderMoneAndDate");
            RenameTable(name: "dbo.PartsOfPayedMonies", newName: "PartsOfPayedMony");
            RenameTable(name: "dbo.SolfaClientClasses", newName: "SolfaClientClass");
            RenameTable(name: "dbo.SolfaClientDetailsClasses", newName: "SolfaClientDetailsClass");
            RenameTable(name: "dbo.solfaPartsofPayments", newName: "solfaPartsofPayment");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.solfaPartsofPayment", newName: "solfaPartsofPayments");
            RenameTable(name: "dbo.SolfaClientDetailsClass", newName: "SolfaClientDetailsClasses");
            RenameTable(name: "dbo.SolfaClientClass", newName: "SolfaClientClasses");
            RenameTable(name: "dbo.PartsOfPayedMony", newName: "PartsOfPayedMonies");
            RenameTable(name: "dbo.OrderMoneAndDate", newName: "OrderMoneAndDates");
            RenameTable(name: "dbo.login", newName: "logins");
            RenameTable(name: "dbo.Clientss", newName: "Clientsses");
            RenameTable(name: "dbo.ClientLaterPaymentinfo", newName: "ClientLaterPaymentinfoes");
        }
    }
}
