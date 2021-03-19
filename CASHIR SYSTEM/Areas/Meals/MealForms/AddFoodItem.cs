using CASHIR_SYSTEM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASHIR_SYSTEM.Areas.Meals.forms
{
    public partial class AddFoodItem : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        Actions act = new Actions();

        public AddFoodItem()
        {
            InitializeComponent();
            Load_cmbCat();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void Load_cmbCat()
        {
            cmbCAtShow.DataSource = act.GetAllCat();
            cmbCAtShow.DisplayMember = "CatName";
            cmbCAtShow.ValueMember = "CatID";
        }

        private void MakeTxtEmpty()
        {
            txtAddFoodItem.Text = "";
            txtAddPrice.Value = 0;

            txtSmallPrice.Value = 0;
            txtMidPrice.Value = 0;
            txtLargePrice.Value = 0;
        }

        private void EmptyWhenChecked()
        {
            txtAddPrice.Value = 0;
            txtSmallPrice.Value = 0;
            txtMidPrice.Value = 0;
            txtLargePrice.Value = 0;
        }

        private void checAddSize_CheckedChanged(object sender, EventArgs e)
        {
            if (checAddSize.Checked == true)
            {
                txtLargePrice.Enabled = true;
                txtMidPrice.Enabled = true;
                txtSmallPrice.Enabled = true;
                txtAddPrice.Enabled = false;
                txtAddPrice.Value = 0;
            }
            else
            {
                txtLargePrice.Enabled = false;
                txtMidPrice.Enabled = false;
                txtSmallPrice.Enabled = false;
                txtAddPrice.Enabled = true;
                txtSmallPrice.Value = 0;
                txtMidPrice.Value = 0;
                txtLargePrice.Value = 0;
            }
        }

        private void cmbCAtShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id;
                bool result = int.TryParse(cmbCAtShow.SelectedValue.ToString(), out id);
                lstFoodItems.DataSource = act.GetAllFoodItems(id);
                lstFoodItems.DisplayMember = "ItemName";
                lstFoodItems.ValueMember = "ItemID";
            }
            catch { }
        }

        private void lstFoodItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeTxtEmpty();
            FoodItems i = act.GetItem(int.Parse(lstFoodItems.SelectedValue.ToString()));
            txtAddFoodItem.Text = i.ItemName;
            if (i.small == 1|| i.mid == 2|| i.larg == 3)
            {
                checAddSize.Checked = true;
                txtAddPrice.Enabled = false;
                txtSmallPrice.Value = (decimal)i.smallprice;
                txtMidPrice.Value = (decimal)i.midprice;
                txtLargePrice.Value = (decimal)i.largeprice;
            }
            else
            {
                txtAddPrice.Value = (decimal)i.ItemPrice;
                checAddSize.Checked = false;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            if (txtAddFoodItem.Text != "" && !act.GetAllitemName().Contains(txtAddFoodItem.Text))
            {
                FoodItems i = new FoodItems();

                i.ItemName = txtAddFoodItem.Text;
                int id;
                bool result = int.TryParse(cmbCAtShow.SelectedValue.ToString(), out id);
                i.CatId = id;
                if (txtSmallPrice.Value > 0|| txtLargePrice.Value > 0|| txtMidPrice.Value > 0)
                {
                    i.small = 1;
                    i.smallprice = txtSmallPrice.Value;
                    i.mid = 2;
                    i.midprice = txtMidPrice.Value;
                    i.larg = 3;
                    i.largeprice = txtLargePrice.Value;
                }
                else
                {
                    i.ItemPrice = txtAddPrice.Value;
                }
                act.AddItem(i);
                MakeTxtEmpty();

                lstFoodItems.DataSource = act.GetAllFoodItems(int.Parse(cmbCAtShow.SelectedValue.ToString()));
                lstFoodItems.DisplayMember = "ItemName";
                lstFoodItems.ValueMember = "ItemID";
            }
            else
            {
                MessageBox.Show("text is empty or cat is exist");
            }

        }

        private void btnAddNewCAT_Click(object sender, EventArgs e)
        {
            AddCategory a = new AddCategory();
            a.FormClosed += AddfoodClsd;
            a.Show();
        }
        private void AddfoodClsd(object sender, FormClosedEventArgs e)
        {
            Load_cmbCat();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            MakeTxtEmpty();
        }

        private void BtnUpdateItem_Click(object sender, EventArgs e)
        {
            if (txtAddFoodItem.Text != "")
            {
                int n;
                bool res = int.TryParse(lstFoodItems.SelectedValue.ToString(), out n);
                FoodItems i = new FoodItems();
                i.ItemID = n;
                i.ItemName = txtAddFoodItem.Text;
                int catid;
                bool re = int.TryParse(cmbCAtShow.SelectedValue.ToString(), out catid);
                i.CatId = catid;
                if (txtSmallPrice.Value > 0 || txtLargePrice.Value > 0 || txtMidPrice.Value > 0)
                {
                    i.small = 1;
                    i.smallprice = txtSmallPrice.Value;
                    i.mid = 2;
                    i.midprice = txtMidPrice.Value;
                    i.larg = 3;
                    i.largeprice = txtLargePrice.Value;
                }
                else
                {
                    i.ItemPrice = txtAddPrice.Value;
                }

                act.UpdateItem(i);
                MakeTxtEmpty();
                int id;
                bool result = int.TryParse(cmbCAtShow.SelectedValue.ToString(), out id);
                lstFoodItems.DataSource = act.GetAllFoodItems(id);
                lstFoodItems.DisplayMember = "ItemName";
                lstFoodItems.ValueMember = "ItemID";
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (txtAddFoodItem.Text != "")
            {
                int n;
                bool res = int.TryParse(lstFoodItems.SelectedValue.ToString(), out n);
                act.DeleteItem(n);
                MakeTxtEmpty();
                int id;
                bool result = int.TryParse(cmbCAtShow.SelectedValue.ToString(), out id);
                lstFoodItems.DataSource = act.GetAllFoodItems(id);
                lstFoodItems.DisplayMember = "ItemName";
                lstFoodItems.ValueMember = "ItemID";
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_cmbCat();
        }
    }
}
