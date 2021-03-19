using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM.Areas.Clients
{
    
    class Clientss
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("أسم العميل")]
        public String Name { get; set; }
       
        [DisplayName("العنوان")]
        public String Address { get; set; }
        [DisplayName("الهاتف الاول")]
        public String FirstPhoneNumner { get; set; }
        [DisplayName("الهاتف الثانى")]
        public String SecondPhoneNumner { get; set; }
        [DisplayName("خدمة التوصيل")]
        public double DelevaryService { get; set; }
        [DisplayName("تاريخ   الاضافة ")]
        public DateTime DateAdded { get; set; }
        [DisplayName("ملا حظات")]
        public String Nots { get; set; }
        public int LaterClientID { get; set; }
    }
}
