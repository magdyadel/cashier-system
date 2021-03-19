using CASHIR_SYSTEM.Areas.Clients;

using CASHIR_SYSTEM.Areas.Meals;
using CASHIR_SYSTEM.Areas.Order;
using CASHIR_SYSTEM.Areas.Orders;
using CASHIR_SYSTEM.Areas.Orders.OrderForms;
using CASHIR_SYSTEM.Areas.PaiedAndRemainingMonr;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM
{
    class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("Data Source=.;Initial Catalog=CASHIR_SYSTEM;Integrated Security=True")
        {

        }
       
        public DbSet<Clientss> clients { get; set; }

        public DbSet<ClientLaterPaymentinfo> clientLaterPaymentinfos { get; set; }
        public DbSet<OrderMoneAndDate> OrderMoneAndDates { get; set; }
        public DbSet<SolfaClientClass> solfaClientClass { get; set; }
        public DbSet<SolfaClientDetailsClass> solfaClientDetails { get; set; }
        public DbSet<solfaPartsofPayment> solfaPartsofPayments { get; set; }
        public DbSet<PartsOfPayedMony> partsOfPayedMonies { get; set; }
        public DbSet<login> login { get; set; }


        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<FoodItems> FoodItems { get; set; }

        public DbSet<GetOrder> Orders { get; set; }
       
        public DbSet<OrderItems> OrderItems { get; set; }

        public DbSet<LaterPayedOrder> LaterPayedOrder { get; set; }

        public DbSet<LaterPaiedOrderItem> LaterPaiedOrderItem { get; set; }

        public DbSet<ByTables> ByTables { get; set; }
        public DbSet<orderlst> orderlst { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new FoodItemsConfig());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
