using CASHIR_SYSTEM.Areas.Order;
using CASHIR_SYSTEM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASHIR_SYSTEM.Areas.Meals.forms
{
    public partial class AddCategory : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        Actions act = new Actions();
        int id;
        
        public AddCategory()
        {
            InitializeComponent();
            loadgrid();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void loadgrid()
        {
            var cl = act.GetAllCat();
            dataCatView.DataSource = cl;
            dataCatView.Columns["CatID"].Visible = false;
            //this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);

        }


        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            if (txtAddCat.Text != "")
            {
                act.UpdateCat(new FoodCategory() {CatID=id,CatName=txtAddCat.Text });
                txtAddCat.Text = "";
                loadgrid();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void dataCatView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataCatView.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtAddCat.Text = dataCatView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            if (txtAddCat.Text != "")
            {
                act.DeleteCat(id);
                txtAddCat.Text="";
                loadgrid();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddCat.Text != "" && !act.GetAllCatName().Contains(txtAddCat.Text))
                {
                    FoodCategory f = new FoodCategory() { CatName = txtAddCat.Text };
                    act.AddCat(f);
                    txtAddCat.Text = "";
                    loadgrid();
                }
                else
                {
                    MessageBox.Show("text is empty or cat is exist");
                }
            }catch{ }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //AddOrder order = new AddOrder();
            //AddFoodItem item = new AddFoodItem();
            //item.Load_cmbCat();
            //order.getallitem();
            
            this.Close();
        }

        private void txtAddCat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
