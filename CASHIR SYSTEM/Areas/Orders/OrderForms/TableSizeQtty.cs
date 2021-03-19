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
    public partial class TableSizeQtty : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        FoodItems item { get; set; }

        public TableSizeQtty(int itemId)
        {
            InitializeComponent();
            item = context.FoodItems.FirstOrDefault(x => x.ItemID == itemId);
            this.ActiveControl = txtTableAddQtty;
        }

        public orderlst getTableOrderList()
        {
            var p = 0M;
            var Tp = 0M;
            if (txtTableAddQtty.Text != "" && cmbTableSizeShow.Text.Contains("قطعة"))
            {
                p = (decimal)item.ItemPrice;
                Tp = p * int.Parse(txtTableAddQtty.Text);
            }
            else if (txtTableAddQtty.Text != "" && cmbTableSizeShow.Text.Contains("صغير"))
            {
                p = (decimal)item.smallprice;
                Tp = p * int.Parse(txtTableAddQtty.Text);
            }
            else if (txtTableAddQtty.Text != "" && cmbTableSizeShow.Text.Contains("كبير"))
            {
                p = (decimal)item.largeprice;
                Tp = p * int.Parse(txtTableAddQtty.Text);
            }
            else if (txtTableAddQtty.Text != "" && cmbTableSizeShow.Text.Contains("وسط"))
            {
                p = (decimal)item.midprice;
                Tp = p * int.Parse(txtTableAddQtty.Text);
            }

            if (txtTableAddQtty.Text != "" && cmbTableSizeShow.Text != "")
            {
                return new orderlst()
                {
                    DateID = DateTime.Now.ToString(),
                    ItemID = item.ItemID,
                    NameITEM = item.ItemName,
                    Quantity = int.Parse(txtTableAddQtty.Text),
                    Size = cmbTableSizeShow.Text,
                    TPrice_for_Item = Tp,
                    Price_Item = p,
                    DateTime = DateTime.Now,
                };
            }
            else
                return null;
        }

        public OrderItems getTableOrderItem()
        {
            var p = 0M;
            var Tp = 0M;
            if (txtTableAddQtty.Text != "" && cmbTableSizeShow.Text.Contains("قطعة"))
            {
                p = (decimal)item.ItemPrice;
                Tp = p * int.Parse(txtTableAddQtty.Text);
            }
            else if (txtTableAddQtty.Text != "" && cmbTableSizeShow.Text.Contains("صغير"))
            {
                p = (decimal)item.smallprice;
                Tp = p * int.Parse(txtTableAddQtty.Text);
            }
            else if (txtTableAddQtty.Text != "" && cmbTableSizeShow.Text.Contains("كبير"))
            {
                p = (decimal)item.largeprice;
                Tp = p * int.Parse(txtTableAddQtty.Text);
            }
            else if (txtTableAddQtty.Text != "" && cmbTableSizeShow.Text.Contains("وسط"))
            {
                p = (decimal)item.midprice;
                Tp = p * int.Parse(txtTableAddQtty.Text);
            }

            if (txtTableAddQtty.Text != "" && cmbTableSizeShow.Text != "")
            {
                return new OrderItems()
                {
                    DateID = DateTime.Now.ToString(),
                    ItemID = item.ItemID,
                    FoodItems = item,
                    Quantity = int.Parse(txtTableAddQtty.Text),
                    Size = cmbTableSizeShow.Text,
                    TPrice_for_Item = Tp,
                    Price_Item = p
                };
            }
            else
                return null;
        }

        private void txtTableAddQtty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //tmm
        private void OrderSizeQtty_Load(object sender, EventArgs e)
        {
            if (item.ItemPrice != null)
                cmbTableSizeShow.Items.Add("قطعة");
            else
            {
                cmbTableSizeShow.Items.Add("صغير");
                cmbTableSizeShow.Items.Add("وسط");
                cmbTableSizeShow.Items.Add("كبير");
            }

            // Adding this ComboBox to the form 
            this.Controls.Add(cmbTableSizeShow);
        }

        //tmm
        private void btnTableAddToOrderGrid_Click(object sender, EventArgs e)
        {
            try
            {
                AddOrder a = new AddOrder();
                string selected = cmbTableSizeShow.Text;
                if (txtTableAddQtty.Text != "" && selected != "")
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("text is empty or cat is exist");
                }
            }
            catch { }
        }
        
    }
}
