using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASHIR_SYSTEM.Areas.PaiedAndRemainingMonr
{
    public partial class ShowClientPrevousOrder : Form
    {
        ApplicationDbContext context;
        int orderid;
        public ShowClientPrevousOrder()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            context = new ApplicationDbContext();
        }
        public int OrderID
        {
            set
            {
                orderid = value;
            }
        }
        private void ShowClientPrevousOrder_Load(object sender, EventArgs e)
        {

            var order = context.LaterPaiedOrderItem.Where(w => w.OrderID == this.orderid).Select(x => new OrderDTO()
            {
                name = "fd",
                Size = x.Size,
                Quantity = x.Quantity,
                TPrice_for_Item = x.TPrice_for_Item,
                Price_Item = x.Price_Item
            }).ToList() ;
            dataGridView1.DataSource = order;
        }

        public class OrderDTO
        {
            [DisplayName("الوجبة")]
            public string name { get; set; }
            [DisplayName("أالحجم")]
            public string Size { get; set; }
            [DisplayName("الكمية")]
            public int Quantity { get; set; }
            [DisplayName("أالسعر للوجبة")]
            public decimal TPrice_for_Item { get; set; }
            [DisplayName("اجمالى السعر")]
            public decimal Price_Item { get; set; }
        }
    }
}
