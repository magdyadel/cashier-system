using CASHIR_SYSTEM.Areas.Meals.forms;
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

namespace CASHIR_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            minaPaginationPanel1.CurrentForm = new AddOrder();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            minaPaginationPanel1.CurrentForm = new AddCategory();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            minaPaginationPanel1.CurrentForm = new AddFoodItem();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
