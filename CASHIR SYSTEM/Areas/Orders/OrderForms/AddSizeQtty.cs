using CASHIR_SYSTEM.Areas.Meals;
using CASHIR_SYSTEM.Areas.Order;
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
    public partial class AddSizeQtty : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        FoodItems item { get; set; }

        public AddSizeQtty(int itemId)
        {
            InitializeComponent();
            item = context.FoodItems.FirstOrDefault(x=>x.ItemID == itemId);
            this.ActiveControl = txtAddQtty;
        }

        public OrderItems getOrderItem()
        {
            var p = 0M;
            var Tp= 0M;
            if (txtAddQtty.Text != "" && cmbSizeShow.Text.Contains("قطعة"))
            {
                p = (decimal)item.ItemPrice;
                Tp =  p* int.Parse(txtAddQtty.Text);
            }
            else if (txtAddQtty.Text != "" && cmbSizeShow.Text.Contains("صغير"))
            {
                p = (decimal)item.smallprice;
                Tp= p * int.Parse(txtAddQtty.Text);
            }
            else if (txtAddQtty.Text != "" && cmbSizeShow.Text.Contains("كبير"))
            {
                p = (decimal)item.largeprice;
                Tp=p * int.Parse(txtAddQtty.Text); 
            }
            else if (txtAddQtty.Text != "" && cmbSizeShow.Text.Contains("وسط"))
            {
                p = (decimal)item.midprice;
                Tp = p * int.Parse(txtAddQtty.Text);
            }

            if (txtAddQtty.Text != "" && cmbSizeShow.Text != "")
            {
                return new OrderItems()
                {
                    DateID=DateTime.Now.ToString(),
                    ItemID = item.ItemID,
                    FoodItems = item,
                    Quantity = int.Parse(txtAddQtty.Text),
                    Size = cmbSizeShow.Text,
                    TPrice_for_Item = Tp,
                    Price_Item = p
                };
            }
            else
                return null;
        }

        private void txtAddQtty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnAddToOrderGrid_Click(object sender, EventArgs e)
        {
            try
            {
                AddOrder a = new AddOrder();
                string selected =cmbSizeShow.Text;
                if (txtAddQtty.Text != "" && selected != "")
                {

                   // var c = 4;
                   // a.dataOrderView.DataSource=z;
                   //a.dataOrderView.Columns["CatID"].Visible = false;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("text is empty or cat is exist");
                }
            }
            catch { }
            
        }

        

        private void AddSizeQtty_Load(object sender, EventArgs e)
        {
            try
            {
                if (item.ItemPrice != null)
                    cmbSizeShow.Items.Add("قطعة");
                else
                {
                    cmbSizeShow.Items.Add("صغير");
                    cmbSizeShow.Items.Add("وسط");
                    cmbSizeShow.Items.Add("كبير");
                }

                // Adding this ComboBox to the form 
                this.Controls.Add(cmbSizeShow);
            }
            catch { }
        }

        private void txtAddQtty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
