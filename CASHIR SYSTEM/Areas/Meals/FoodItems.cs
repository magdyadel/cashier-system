using CASHIR_SYSTEM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using CASHIR_SYSTEM.Areas.Order;

namespace CASHIR_SYSTEM.Areas.Meals
{
    [Table("FoodItems", Schema = "Meals")]
    public class FoodItems
    {
        public FoodItems()
        {
            this.OrderItems = new HashSet<OrderItems>();
        }

        [Key]
        public int ItemID { get; set; }

        //[DisplayName("")]
        public string ItemName { get; set; }

        public decimal? ItemPrice { get; set; }

        public int? larg { get; set; }
        public int? small { get; set; }
        public int? mid { get; set; }
        public decimal? largeprice { get; set; }
        public decimal? smallprice { get; set; }
        public decimal? midprice { get; set; }

        [ForeignKey("FoodCategory")]
        public int CatId { get; set; }
        
        public FoodCategory FoodCategory { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}

