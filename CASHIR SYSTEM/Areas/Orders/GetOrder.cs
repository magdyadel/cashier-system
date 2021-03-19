using CASHIR_SYSTEM.Areas.Meals;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM.Areas.Order
{
    [Table("GetOrder", Schema = "Orders")]
    public class GetOrder
    {
        public GetOrder()
        {
            this.OrderItems = new HashSet<OrderItems>();
        }

        [Key]
        public int OrderID { get; set; }
        public string Ordertype { get; set; }

        public DateTime DateTime { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
