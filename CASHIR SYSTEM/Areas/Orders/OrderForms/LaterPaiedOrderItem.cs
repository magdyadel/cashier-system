using CASHIR_SYSTEM.Areas.Meals;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM.Areas.Orders.OrderForms
{
    [Table("LaterPaiedOrderItem", Schema = "Orders")]
    class LaterPaiedOrderItem
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("LaterPayedOrder")]
        public int OrderID { get; set; }

    
        public string ItemName{ get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public decimal TPrice_for_Item { get; set; }
        public decimal Price_Item { get; set; }

        //[Key]
        //public int id { get; set; }

        //[ForeignKey("LaterPayedOrder")]
        //public int OrderID { get; set; }



        //[ForeignKey("FoodItems")]
        //public int ItemID { get; set; }
        //public string Size { get; set; }
        //public int Quantity { get; set; }
        //public decimal TPrice_for_Item { get; set; }
        //public decimal Price_Item { get; set; }

        //public DateTime DateTime { get; set; }
        //public string DateID { get; set; }

        public virtual LaterPayedOrder LaterPayedOrder { get; set; }
        public virtual FoodItems FoodItems { get; set; }
    }
}
