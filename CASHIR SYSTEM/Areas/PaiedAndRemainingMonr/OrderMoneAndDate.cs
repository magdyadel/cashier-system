using CASHIR_SYSTEM.Areas.Orders.OrderForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM.Areas.PaiedAndRemainingMonr
{
    class OrderMoneAndDate
    {
        public int Id { get; set; }
        [DisplayName("اجمالى المبلغ")]
        public double allMony { get; set; }
        [DisplayName("المال المدفول")]
        public Double paidOrderMony { get; set; }
        [DisplayName("المال المتبقى ")]
        public Double RemaningOrderMony { get; set; }
        [DisplayName("تاريخ  الدفع")]
        public DateTime DateAdded { get; set; }
        
        [ForeignKey("clientLaterPaymentinfo")]
        public int clientid { get; set; }
        public ClientLaterPaymentinfo clientLaterPaymentinfo { get; set; }
       
        public int orderid { get; set; }
       

    }
}
