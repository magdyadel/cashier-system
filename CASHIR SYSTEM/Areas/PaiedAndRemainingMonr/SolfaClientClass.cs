using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM.Areas.PaiedAndRemainingMonr
{
    class SolfaClientClass
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("أسم صاحب السلفة")]
        public String Name { get; set; }

        [DisplayName("العنوان")]
        public String Address { get; set; }
        [DisplayName("الهاتف الاول")]
        public String FirstPhoneNumner { get; set; }
        [DisplayName("الهاتف الثانى")]
        public String SecondPhoneNumner { get; set; }
        [DisplayName("ملا حظات")]
        public String Nots { get; set; }
      
    }
}
