using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM.Areas.Orders.OrderForms
{
    [Table("LaterPayedOrder", Schema = "Orders")]
    class LaterPayedOrder
    {
        public LaterPayedOrder()
        {
            this.LaterPaiedOrderItem = new HashSet<LaterPaiedOrderItem>();
        }

        [Key]
        public int OrderID { get; set; }
        public string Ordertype { get; set; }

        public DateTime DateTime { get; set; }

        public virtual ICollection<LaterPaiedOrderItem> LaterPaiedOrderItem { get; set; }
    }
}
