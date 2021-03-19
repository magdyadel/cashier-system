using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM.Areas.PaiedAndRemainingMonr
{
    class PartsOfPayedMony
    {
        public int Id { get; set; }
        [DisplayName("المبلغ المدفوع")]
        public Double PayedOrderMony { get; set; }
        [DisplayName("تاريخ  الدفع")]
        public DateTime DateOfPay { get; set; }

        [ForeignKey("clientLaterPaymentinfo")]
        public int clientid { get; set; }
        public ClientLaterPaymentinfo clientLaterPaymentinfo { get; set; }
    }
}
