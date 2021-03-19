using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM.Areas.Meals
{
    class FoodItemsConfig:EntityTypeConfiguration<FoodItems>
    {
        public FoodItemsConfig()
        {
            this.Property(f => f.ItemPrice).IsOptional();
        }
    }
}
