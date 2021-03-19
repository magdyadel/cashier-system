using CASHIR_SYSTEM.Areas.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM.Areas.Orders
{
    [Table("ByTables", Schema = "TABLES")]
    public class ByTables
    {
        public ByTables()
        {
            this.Orderlsts = new HashSet<orderlst>();
        }
        [Key]
        public int ID { get; set; }

        public int TableID { get; set; }
        public int? check { get; set; }

        public virtual ICollection<orderlst> Orderlsts { get; set; }
    }

    [Table("OrderLst", Schema = "TABLES")]
    public class orderlst
    {
        public orderlst()
        {
           // this.ByTables=new ByTables();
        }

        [Key]
        public int ID { get; set; }

        [ForeignKey("ByTables")]
        public int TableID { get; set; }


        public int? ItemID { get; set; }

        public string NameITEM { get; set; }
        public string Size { get; set; }
        public int? Quantity { get; set; }
        public decimal? TPrice_for_Item { get; set; }
        public decimal? Price_Item { get; set; }

        public DateTime? DateTime { get; set; }
        public string DateID { get; set; }

        public ByTables ByTables { get; set; }
    }
}
