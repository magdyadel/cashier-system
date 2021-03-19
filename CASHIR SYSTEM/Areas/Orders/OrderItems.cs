using CASHIR_SYSTEM.Areas.Meals;
using CASHIR_SYSTEM.Areas.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM.Areas.Order
{
    [Table("OrderItems", Schema = "Orders")]
    public class OrderItems
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("GetOrder")]
        public int OrderID { get; set; }

       

        [ForeignKey("FoodItems")]
        public int ItemID { get; set; }


        public string Size{ get; set; }
        public int Quantity { get; set; }
        public decimal TPrice_for_Item { get; set; }
        public decimal Price_Item { get; set; }

        public DateTime DateTime { get; set; }
        public string DateID { get; set; }

        public virtual GetOrder GetOrder { get; set; }
        public virtual FoodItems FoodItems { get; set; }

    }
}
