using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASHIR_SYSTEM.Areas.Orders.OrderForms
{
    public partial class gardForm : Form
    {
        ApplicationDbContext context;
        List<Order.OrderItems> allOrdersMony = new List<Order.OrderItems>() ;
        List<Order.OrderItems> OrdersonlyMony = new List<Order.OrderItems>();
        public gardForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            context = new ApplicationDbContext();
        }

        private void gardForm_Load(object sender, EventArgs e)
        {
            NunberOrdertextBox.Enabled = false;
            AllMonyOrdertextBox.Enabled = false;
            NumberTakawayordertextBox.Enabled = false;
            AllTakeAwayMonytextBox.Enabled = false;
            NumberDelivrytextBox.Enabled = false;
            AllmomyDelivrytextBox.Enabled = false;
            MainAllMonttextBox.Enabled = false;
            MainAllOrdetextBox.Enabled = false;

          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var allOrders = context.Orders.Where(o => o.DateTime.Day == dateTimePicker1.Value.Day &&
                                                  o.DateTime.Month == dateTimePicker1.Value.Month &&
                                                    o.DateTime.Year == dateTimePicker1.Value.Year).ToList();
            MainAllOrdetextBox.Text = allOrders.Count().ToString();
            double mony = 0.0;
            
            foreach (var item in allOrders)
            {
               var monyinoneorder = context.OrderItems.Where(o=>o.OrderID == item.OrderID &&
                                                   o.DateTime.Day == dateTimePicker1.Value.Day &&
                                                  o.DateTime.Month == dateTimePicker1.Value.Month &&
                                                    o.DateTime.Year == dateTimePicker1.Value.Year).ToList();

                allOrdersMony.AddRange(monyinoneorder);
            }
          
            foreach (var item in allOrdersMony)
            {
                mony += (double)item.TPrice_for_Item;
            }
            MainAllMonttextBox.Text = mony.ToString();
            mony = 0.0;
            allOrdersMony.Clear();
        }

        private void OrderradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OrderradioButton.Checked == true)
            {
                dataGridView2.DataSource = null;
                TakeawayradioButton.Checked = false;
                DelivryradioButton.Checked = false;

                NumberTakawayordertextBox.Text = "";
                AllTakeAwayMonytextBox.Text = "";
                NumberDelivrytextBox.Text = "";
                AllmomyDelivrytextBox.Text = "";
             


                var Ordersonly = context.Orders.Where(o => o.DateTime.Day == dateTimePicker1.Value.Day &&
                                                  o.DateTime.Month == dateTimePicker1.Value.Month &&
                                                    o.DateTime.Year == dateTimePicker1.Value.Year &&
                                                    o.Ordertype.Contains("ORDER")).ToList();
                NunberOrdertextBox.Text = Ordersonly.Count().ToString();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Ordersonly;
                dataGridView1.Columns["DateTime"].Visible = false;
                dataGridView1.Columns["Ordertype"].Visible = false; 
                dataGridView1.Columns["OrderItems"].Visible = false;



                double mony = 0.0;

                foreach (var item in Ordersonly)
                {
                    var monyinoneorder = context.OrderItems.Where(o => o.OrderID == item.OrderID &&
                                                        o.DateTime.Day == dateTimePicker1.Value.Day &&
                                                       o.DateTime.Month == dateTimePicker1.Value.Month &&
                                                         o.DateTime.Year == dateTimePicker1.Value.Year).ToList();

                    OrdersonlyMony.AddRange(monyinoneorder);
                }

                foreach (var item in OrdersonlyMony)
                {
                    mony += (double)item.TPrice_for_Item;
                }
                AllMonyOrdertextBox.Text = mony.ToString();
                mony = 0.0;
                OrdersonlyMony.Clear();
            }
        }

        private void OrderradioButton_Click(object sender, EventArgs e)
        {
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int orderid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var orderitem = context.OrderItems.Where(o => o.OrderID == orderid).ToList();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = orderitem
                .Select(x=>new orderItemsView() 
                { 
                    dateid=x.DateID,
                    orderItemsName = x.FoodItems.ItemName,
                    quantety = x.Quantity,
                    Size=x.Size,
                    TotalPrice_for_Item=x.TPrice_for_Item,
                    Price_Item=x.Price_Item
                }).ToList();
            dataGridView2.Columns["dateid"].Visible = false;
        }
        class orderItemsView
        {
            public string dateid { get; set; }

            [DisplayName("اسم الصنف")]
            public string orderItemsName { get; set; }

            [DisplayName("الكمية")]
            public int quantety { get; set; }

            [DisplayName("الحجم")]
            public string Size { get; set; }

            [DisplayName("سعر القطعة")]
            public decimal Price_Item { get; set; }

            [DisplayName("السعر النهائي")]
            public decimal TotalPrice_for_Item { get; set; }
        }

        private void TakeawayradioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (TakeawayradioButton.Checked == true)
            {
                dataGridView2.DataSource = null;
                OrderradioButton.Checked = false;
                DelivryradioButton.Checked = false;

                NunberOrdertextBox.Text = "";
                AllMonyOrdertextBox.Text = "";
                NumberDelivrytextBox.Text = "";
                AllmomyDelivrytextBox.Text = "";



                var TakeAwayonly = context.Orders.Where(o => o.DateTime.Day == dateTimePicker1.Value.Day &&
                                                  o.DateTime.Month == dateTimePicker1.Value.Month &&
                                                    o.DateTime.Year == dateTimePicker1.Value.Year &&
                                                    o.Ordertype.Contains("TAKEAWAY")).ToList();
                NumberTakawayordertextBox.Text = TakeAwayonly.Count().ToString();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = TakeAwayonly;
                dataGridView1.Columns["DateTime"].Visible = false;
                dataGridView1.Columns["Ordertype"].Visible = false;
                dataGridView1.Columns["OrderItems"].Visible = false;



                double mony = 0.0;

                foreach (var item in TakeAwayonly)
                {
                    var monyinoneorder = context.OrderItems.Where(o => o.OrderID == item.OrderID &&
                                                        o.DateTime.Day == dateTimePicker1.Value.Day &&
                                                       o.DateTime.Month == dateTimePicker1.Value.Month &&
                                                         o.DateTime.Year == dateTimePicker1.Value.Year).ToList();

                    OrdersonlyMony.AddRange(monyinoneorder);
                }

                foreach (var item in OrdersonlyMony)
                {
                    mony += (double)item.TPrice_for_Item;
                }
                AllTakeAwayMonytextBox.Text = mony.ToString();
                mony = 0.0;
                OrdersonlyMony.Clear();
            }
        }

        private void DelivryradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DelivryradioButton.Checked == true)
            {
                dataGridView2.DataSource = null;
                OrderradioButton.Checked = false;
                TakeawayradioButton.Checked = false;

                NunberOrdertextBox.Text = "";
                AllMonyOrdertextBox.Text = "";
                NumberTakawayordertextBox.Text = "";
                AllTakeAwayMonytextBox.Text = "";



                var Delivryonly = context.Orders.Where(o => o.DateTime.Day == dateTimePicker1.Value.Day &&
                                                  o.DateTime.Month == dateTimePicker1.Value.Month &&
                                                    o.DateTime.Year == dateTimePicker1.Value.Year &&
                                                    o.Ordertype.Contains("DELIVRY")).ToList();
                NumberDelivrytextBox.Text = Delivryonly.Count().ToString();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Delivryonly;
                dataGridView1.Columns["DateTime"].Visible = false;
                dataGridView1.Columns["Ordertype"].Visible = false;
                dataGridView1.Columns["OrderItems"].Visible = false;



                double mony = 0.0;

                foreach (var item in Delivryonly)
                {
                    var monyinoneorder = context.OrderItems.Where(o => o.OrderID == item.OrderID &&
                                                        o.DateTime.Day == dateTimePicker1.Value.Day &&
                                                       o.DateTime.Month == dateTimePicker1.Value.Month &&
                                                         o.DateTime.Year == dateTimePicker1.Value.Year).ToList();

                    OrdersonlyMony.AddRange(monyinoneorder);
                }

                foreach (var item in OrdersonlyMony)
                {
                    mony += (double)item.TPrice_for_Item;
                }
                AllmomyDelivrytextBox.Text = mony.ToString();
                mony = 0.0;
                OrdersonlyMony.Clear();
            }
        }
    }
}
