using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM.Areas.Meals
{
    [Table("FoodCategory", Schema = "Meals")]
    public class FoodCategory
    {
        [Key]
        public int CatID { get; set; }
        [DisplayName("الاسم")]

        public string CatName { get; set; }

        public List<FoodItems> FoodItems { get; set; }
    }
}
