using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM.Areas.PaiedAndRemainingMonr
{
    class SolfaClientDetailsClass
    {
        public int Id { get; set; }
        [DisplayName("اجمالى مبلغ السلفة")]
        public double allMony { get; set; }
        [DisplayName("المبلغ المدفول")]
        public Double paidOrderMony { get; set; }
        [DisplayName("المبلغ المتبقى ")]
        public Double RemaningOrderMony { get; set; }
        [DisplayName("تاريخ  الدفع")]
        public DateTime DateAdded { get; set; }

        [ForeignKey("solfaClientClass")]
        public int solfaclientid { get; set; }
        public SolfaClientClass solfaClientClass { get; set; }
    }
}
