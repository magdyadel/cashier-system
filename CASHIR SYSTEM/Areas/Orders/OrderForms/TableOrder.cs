using CASHIR_SYSTEM.Areas.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASHIR_SYSTEM.Areas.Orders.OrderForms
{
    public partial class TableOrder : Form
    {
        ApplicationDbContext c = new ApplicationDbContext();
        GetOrder order = new GetOrder();
        Button btn_TableCat;
        Button btn_TableItem;
        public int check = 0;
        ByTables table = new ByTables();
        bool f = true;
        List<orderlst> olst;

        public TableOrder(int tableNUMber)
        {
            InitializeComponent();
            getallTableItem();
            table = c.ByTables.FirstOrDefault(x => x.TableID == tableNUMber);
            if ((c.orderlst.Where(e => e.TableID == table.TableID).ToList() != null) && f)
            {
                olst = table.Orderlsts.ToList();
                RefreshdataOrderView();
            }
        }

        public void getallTableItem()
        {
            fpnlCatTable.Controls.Clear();
            var query =
                from i in c.FoodCategories
                select i;
            foreach (var q in query)
            {
                btn_TableCat = new Button();
                btn_TableCat.Width = 160;
                btn_TableCat.Height = 60;
                btn_TableCat.Font = new Font("Arial", 12, FontStyle.Bold);
                btn_TableCat.Text = q.CatName;
                btn_TableCat.Tag = q.CatID;
                //btn_Cat.Name = q.CatName;
                //btn_Cat.BackColor = Color.FromArgb(41,128,185);
                btn_TableCat.BackColor = Color.Azure;
                //btn_Cat.ForeColor = Color.Azure;
                fpnlCatTable.Controls.Add(btn_TableCat);
                btn_TableCat.Click += new EventHandler(btn_TableCat_Click);
            }
            
        }
        //Add Items Buttons to Flow layout
        private void btn_TableCat_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == null)
                return;
            fpnltemTable.Controls.Clear();
            var query = //c.FoodItems.Where(f => f.CatId == (int)b.Tag).ToList();
            from i in c.FoodItems
            where i.CatId == (int)b.Tag
            select i;
            foreach (var q in query)
            {
                btn_TableItem = new Button();
                btn_TableItem.Width = 140;
                btn_TableItem.Height = 60;
                btn_TableItem.Font = new Font("Arial", 12, FontStyle.Bold);
                btn_TableItem.Text = q.ItemName;
                btn_TableItem.Tag = q.ItemID;
                btn_TableItem.BackColor = Color.FromArgb(41, 128, 185);
                btn_TableItem.ForeColor = Color.Azure;
                fpnltemTable.Controls.Add(btn_TableItem);
                btn_TableItem.Click += new EventHandler(btn_TableItem_Click);
            }
        }

        //add item to Order
        private void btn_TableItem_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == null)
                return;
            TableSizeQtty tableSizeQtty = new TableSizeQtty((int)b.Tag);
            tableSizeQtty.FormClosing += tableSizeQttyClosing;
            tableSizeQtty.ShowDialog();

        }
        
        private void tableSizeQttyClosing(object sender, FormClosingEventArgs e)
        {
            TableSizeQtty f = sender as TableSizeQtty;
            var add = f.getTableOrderList();
            var item = f.getTableOrderItem();
            if (add != null&&item!=null)
            {
                olst.Add(add);
                order.OrderItems.Add(item);
            }
            RefreshdataOrderView();
        }

        private void RefreshdataOrderView()
        {
            dataTableOrderView.DataSource = null;
            //List<orderlst> get = c.orderlst.Where(e=>e.TableID==table.TableID).ToList();
            //if (get.Count()==0)
            //{
            if (fpnlCatTable.Controls.Count == 0)
            {
                f = false;
                return;
            }
            f = true;

            dataTableOrderView.DataSource = olst.Select(x => new TableorderItemsView()
                {
                    id = x.ID,
                    itemid = x.ItemID,
                    orderItemsName = x.NameITEM,
                    quantety = x.Quantity,
                    Size = x.Size,
                    TotalPrice_for_Item = x.TPrice_for_Item,
                    Price_Item = x.Price_Item,
                }).ToList();
            dataTableOrderView.Columns["id"].Visible = false;
            dataTableOrderView.Columns["itemid"].Visible = false;
            

        }

        private void TableOrder_Load(object sender, EventArgs e)
            {

            }

        private void btnPrintMTB5_Click(object sender, EventArgs e)
        {
            if (dataTableOrderView.Rows.Count == 0 )
            {
                MessageBox.Show(" لا يوجد اصناف لطباعة الاوردر", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ByTables b = c.ByTables.FirstOrDefault(x => x.TableID == table.ID);
            b.check = 1;
            b.Orderlsts = olst;
            olst = null;
            c.SaveChanges();


            this.DialogResult = DialogResult.OK;
            this.Close();
        }
         
        private void btnFinalPrint_Click(object sender, EventArgs e)
        {
            //ByTables b = c.ByTables.FirstOrDefault(x => x.TableID == table.ID);
            //b.ID = table.ID;
            //b.TableID = table.TableID;
            // b.OrderItems = null;
            //Adding to Database
            var x = table.Orderlsts;
            if (x == null || x.Count() == 0)
            {
                MessageBox.Show(" لا يوجد اصناف لطباعة الاوردر", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ByTables db = c.ByTables.FirstOrDefault(h => h.TableID == table.TableID);
            db.check = 0;
            check = 0;
       
            
            table.Orderlsts = null;
            var xx = order.OrderItems;
            var del = 
                (from o in c.orderlst
                where o.TableID==table.ID
                select o).ToList();
            foreach (var item in del)
            {
                c.orderlst.Remove(item);
            }
            c.SaveChanges();
            
            order.OrderItems = null;
            order.DateTime = DateTime.Now;
            order.Ordertype = "TABLES";
            c.Orders.Add(order);

            c.SaveChanges();

            #region add to DB from OrderItems list
            foreach (var item in x)
            {
                c.OrderItems.Add(new OrderItems()
                {
                    OrderID = order.OrderID,
                    ItemID = (int)item.ItemID,
                    Quantity = (int)item.Quantity,
                    Size = item.Size,
                    TPrice_for_Item = (decimal)item.TPrice_for_Item,
                    Price_Item = (decimal)item.Price_Item,
                    DateTime =(DateTime)item.DateTime  //AddeddateTimePicker.Value
                });
            }
            #endregion
            
            c.SaveChanges();
            order = new GetOrder();
            table = new ByTables();
            RefreshdataOrderView();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDeleteSelectItem_Click(object sender, EventArgs e)
        {
            if (fpnlCatTable.Controls.Count == 0)
            {
                f = false;
                return;
            }
            ApplicationDbContext context = new ApplicationDbContext();
            ByTables b = c.ByTables.FirstOrDefault(x => x.ID == table.ID);
            
            foreach (DataGridViewRow row in this.dataTableOrderView.SelectedRows)
            {
                int i = int.Parse(row.Cells[0].Value.ToString());
                olst.Remove(table.Orderlsts.SingleOrDefault(a => a.ID == i));
               // var del = context.orderlst.SingleOrDefault(a=>a.ID==i );
             //   context.orderlst.Remove(del);
            }
            if (dataTableOrderView.Rows.Count == 0)
                b.check = 0;
            else
                b.check = 1;
            
            b.Orderlsts.Clear();
            b.Orderlsts = olst;
            foreach (var item in b.Orderlsts.ToList())
            {
                item.ByTables = null;
            }
            c.SaveChanges();
            RefreshdataOrderView();
        }

        private void dataTableOrderView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataTableOrderView.Rows.Count==0)
            {
                btnPrintMTB5.Enabled = false;
            }
        }
    }

    class TableorderItemsView
    {
        public int id { get; set; }
        public int? itemid { get; set; }

        [DisplayName("اسم الصنف")]
        public string orderItemsName { get; set; }

        [DisplayName("الكمية")]
        public int? quantety { get; set; }

        [DisplayName("الحجم")]
        public string Size { get; set; }

        [DisplayName("سعر القطعة")]
        public decimal? Price_Item { get; set; }

        [DisplayName("السعر النهائي")]
        public decimal? TotalPrice_for_Item { get; set; }
    }
}
