using CASHIR_SYSTEM.Areas.Clients;
using CASHIR_SYSTEM.Areas.Meals.forms;
using CASHIR_SYSTEM.Areas.Orders;
using CASHIR_SYSTEM.Areas.Orders.OrderForms;
using CASHIR_SYSTEM.Areas.PaiedAndRemainingMonr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASHIR_SYSTEM.Areas.Order
{
    public partial class AddOrder : Form
    {
        ApplicationDbContext c = new ApplicationDbContext();
        GetOrder order = new GetOrder();
        LaterPayedOrder LaterPaiedorder = new LaterPayedOrder();
        Button btn_Cat ;
        Button btn_Item;
        int curentuserid;
        double allmony=0.0;
        int savedclientsuccs;
        int latercurntsvedorderid;
        ICollection<LaterPaiedOrderItem> x;
        Form CurrentForm;
        public AddOrder()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            getallitem();
            OrderradioButton.Checked = true;
            disableinfo();
            
                laterPaied.Enabled = false;
            

        }
        void clearinfo()
        {
            clientNametextbox.Text = "";
            ClientAdressTextbox.Text = "";
            serviceNumeric.Value = 0;
      
            firstPhonetextbox.Text = "";
            seceondPhoneTextbox.Text = "";
          
        }
        void disableinfo() {
            clearinfo();
            clientNametextbox.Enabled = false;
            ClientAdressTextbox.Enabled = false;
            serviceNumeric.Enabled = false;
          //  AddeddateTimePicker.Enabled = false;
            firstPhonetextbox.Enabled = false;
            seceondPhoneTextbox.Enabled = false;
            SearshButon.Enabled = false;
        }
        void enableinfo()
        {
            clientNametextbox.Enabled = true;
            ClientAdressTextbox.Enabled = true;
            serviceNumeric.Enabled = true;
            AddeddateTimePicker.Enabled = true;
            firstPhonetextbox.Enabled = true;
            seceondPhoneTextbox.Enabled = true;
            SearshButon.Enabled = true;
        }
        public void getallitem()
        {
            fpnlShowCat.Controls.Clear();
            var query =
                from i in c.FoodCategories
                select i;
            foreach (var q in query)
            {
                
                btn_Cat = new Button();
                btn_Cat.Width = 160;
                btn_Cat.Height = 60;
                btn_Cat.Font = new Font("Arial", 12,FontStyle.Bold);
                btn_Cat.Text = q.CatName;
                btn_Cat.Tag = q.CatID;
                //btn_Cat.Name = q.CatName;
                //btn_Cat.BackColor = Color.FromArgb(41,128,185);
                btn_Cat.BackColor = Color.Azure;
                //btn_Cat.ForeColor = Color.Azure;
                fpnlShowCat.Controls.Add(btn_Cat);
                btn_Cat.Click += new EventHandler(btnCat_Click);
            }
        }
        //Add Items Buttons to Flow layout
        private void btnCat_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == null)
                return;
            fpnlShowItem.Controls.Clear();
            var query = //c.FoodItems.Where(f => f.CatId == (int)b.Tag).ToList();
            from i in c.FoodItems
            where i.CatId == (int)b.Tag
            select i;
            foreach (var q in query)
            {
                btn_Item = new Button();
                btn_Item.Width = 140;
                btn_Item.Height = 60;
                btn_Item.Font = new Font("Arial", 12, FontStyle.Bold);
                btn_Item.Text = q.ItemName;
                btn_Item.Tag = q.ItemID;
                btn_Item.BackColor = Color.FromArgb(41, 128, 185);
                btn_Item.ForeColor = Color.Azure;
                fpnlShowItem.Controls.Add(btn_Item);
                btn_Item.Click += new EventHandler(btnItem_Click);
            }
        }

        //add item to Order
        private void btnItem_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == null)
                return;
            AddSizeQtty addSizeQtty = new AddSizeQtty((int)b.Tag);
            addSizeQtty.FormClosing += addSizeQttyClosing;
            addSizeQtty.ShowDialog();

        }

        private void addSizeQttyClosing(object sender, FormClosingEventArgs e)
        {
            AddSizeQtty f = sender as AddSizeQtty;
            var item = f.getOrderItem();
            if (item != null)
            {
                order.OrderItems.Add(item);
                //LaterPaiedorder.LaterPaiedOrderItem.Add(item);
            }
            RefreshdataOrderView();
        }

        private void RefreshdataOrderView()
        {
            dataOrderView.DataSource = null;
            
            dataOrderView.DataSource = order.OrderItems
                .Select(x=>new orderItemsView() 
                { 
                    dateid=x.DateID,
                    orderItemsName = x.FoodItems.ItemName,
                    quantety = x.Quantity,
                    Size=x.Size,
                    TotalPrice_for_Item=x.TPrice_for_Item,
                    Price_Item=x.Price_Item
                }).ToList();
                dataOrderView.Columns["dateid"].Visible = false;
        }

        //elly 3leh el door
        private void btnCatEdit_Click(object sender, EventArgs e)
        {
            AddCategory addCat = new AddCategory();
            addCat.FormClosed += AddCatClosed;
            addCat.ShowDialog();
        }

        private void AddCatClosed(object sender, FormClosedEventArgs e)
        {
            getallitem();
            fpnlShowItem.Controls.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataOrderView.Rows.Count == 0)
            {
                DialogResult dialog = MessageBox.Show("لا يوجد بيانات للطباعة", "لا يوجد بيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (dataOrderView.Rows.Count != 0)
            {
                //Adding to Database
                var x = order.OrderItems;
                order.OrderItems = null;
                if(DelevryradioButton.Checked == true)
                {
                    order.DateTime =  DateTime.Now;
                    order.Ordertype = "DELIVRY";
                    c.Orders.Add(order);
                    c.SaveChanges();
                }
                if (OrderradioButton.Checked == true)
                {
                    order.DateTime = DateTime.Now;// AddeddateTimePicker.Value;//
                    order.Ordertype = "ORDER";
                    c.Orders.Add(order);
                    c.SaveChanges();
                }
                if (takeawayradioButton.Checked == true)
                {
                    order.DateTime = DateTime.Now;
                    order.Ordertype = "TAKEAWAY";
                    c.Orders.Add(order);
                    c.SaveChanges();
                }
               

               
              

                #region add to DB from OrderItems list
                foreach (var item in x)
                {
                    c.OrderItems.Add(new OrderItems()
                    {
                        OrderID = order.OrderID,
                        ItemID = item.ItemID,
                        Quantity = item.Quantity,
                        Size = item.Size,
                        TPrice_for_Item = item.TPrice_for_Item,
                        Price_Item = item.Price_Item,
                        DateTime =DateTime.Now  //AddeddateTimePicker.Value
                    }) ;
                }
                #endregion

                c.SaveChanges();
                order = new GetOrder();
                RefreshdataOrderView();

            }
        }

        

        private void btnDeleteSelectItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataOrderView.SelectedRows)
            {
                var del = order.OrderItems
                    .Where(x => x.DateID.Contains(row.Cells[0].Value.ToString()))
                    .FirstOrDefault();
                order.OrderItems.Remove(del);
            }
            RefreshdataOrderView();
        }

        private void btnEditSelectItem_Click(object sender, EventArgs e)
        {
            try
            {
                var dateid = dataOrderView.SelectedRows[0].Cells[0].Value.ToString();
                var edit = order.OrderItems.FirstOrDefault(x => x.DateID == dateid);
                edit.Quantity = Convert.ToInt32(txtQttyEdit.Value);
                edit.TPrice_for_Item = edit.Quantity * edit.Price_Item;
                RefreshdataOrderView();
            }
            catch { }
        }


        private void dataOrderView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtQttyEdit.Value = int.Parse(dataOrderView.SelectedRows[0].Cells[2].Value.ToString());
            }
            catch { }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void firstPhonetextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void OpenForm(Form form)
        {
            if (CurrentForm != null)
            {
                CurrentForm.Close();
            }
            form.MdiParent = this.MdiParent;
            CurrentForm = form;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();


        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            using (var form = new ClientSearchForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                   curentuserid = form.clientID;
                 
                  var client =  c.clients.FirstOrDefault(c => c.Id == curentuserid);
                    clientNametextbox.Text = client.Name;
                    ClientAdressTextbox.Text = client.Address;
                    serviceNumeric.Value = Convert.ToDecimal(client.DelevaryService);
                    AddeddateTimePicker.Value = client.DateAdded;
                    firstPhonetextbox.Text = client.FirstPhoneNumner;
                    seceondPhoneTextbox.Text = client.SecondPhoneNumner;
                    
                }
            }

        }

        private void DelevryradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DelevryradioButton.Checked == true)
            {
                enableinfo();
                
            }
        }

        private void takeawayradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (takeawayradioButton.Checked == true)
            {
                disableinfo();

                this.curentuserid = 0;
            }
        }

        private void OrderradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OrderradioButton.Checked == true)
            {
                disableinfo();
                this.curentuserid = 0;
               
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddClientForm addclientfrm = new AddClientForm();
            OpenForm(addclientfrm);
        }

        private void laterPaied_Click(object sender, EventArgs e)
        {
            if (dataOrderView.Rows.Count == 0)
            {
                DialogResult dialog = MessageBox.Show("لا يوجد بيانات للاضافة", "لا يوجد بيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

           var unnessaryitem = c.LaterPayedOrder.Where(o => o.Ordertype.Contains("NotOrderdYet")).ToList();
            foreach (var item in unnessaryitem)
            {
                c.LaterPayedOrder.Remove(item);
            }
            var dattime = DateTime.Now;
              x= LaterPaiedorder.LaterPaiedOrderItem;
                LaterPaiedorder.LaterPaiedOrderItem = null;
                LaterPaiedorder.DateTime = dattime;
                LaterPaiedorder.Ordertype = "NotOrderdYet";
                c.LaterPayedOrder.Add(LaterPaiedorder);
                c.SaveChanges();

            latercurntsvedorderid = LaterPaiedorder.OrderID;

                if (curentuserid > 0)
            {
                using (var addclientfrm = new Late_paymentOrderMony())
                {
                   
                        
                            addclientfrm.clientID = curentuserid;
                            addclientfrm.OrdeId = latercurntsvedorderid; 
                            if (dataOrderView.Rows.Count > 0)
                            {
                                foreach (DataGridViewRow dr in dataOrderView.Rows)
                                {
                                    allmony += Convert.ToDouble( dr.Cells["TotalPrice_for_Item"].Value);
                       
                                }
                   
                                addclientfrm.AllmonyPaied = allmony;
                            }
                    var result = addclientfrm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        savedclientsuccs = addclientfrm.donevalue;
                        addclclosed(savedclientsuccs);
                    }
                }
            }
            else
            {
                using (var addclientfrm = new Late_paymentOrderMony())
                {
                   
                    if (dataOrderView.Rows.Count > 0)
                    {
                        addclientfrm.OrdeId = latercurntsvedorderid;
                        foreach (DataGridViewRow dr in dataOrderView.Rows)
                        {
                            allmony += Convert.ToDouble(dr.Cells["TotalPrice_for_Item"].Value);
                        }

                        addclientfrm.AllmonyPaied = allmony;
                    }
                    var result = addclientfrm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        savedclientsuccs = addclientfrm.donevalue;
                        addclclosed(savedclientsuccs);
                    }
                }
            }
            //---------------
            order.OrderItems = null;
            order = new GetOrder();
            RefreshdataOrderView();
            OrderradioButton.Checked = true;
            DelevryradioButton.Checked = false;
            //-------
        }

        public void addclclosed(int savedclientsuccs)
        {
            try
            {

                if (savedclientsuccs == 1)
                {
                    allmony = 0;
                    var x = order.OrderItems;
                    order.OrderItems = null;
                    var laterorder = c.LaterPayedOrder.FirstOrDefault(o => o.OrderID == latercurntsvedorderid);
                    laterorder.Ordertype = "ORDERD";
                    c.SaveChanges();
                    foreach (DataGridViewRow dr in dataOrderView.Rows)
                    {
                        c.LaterPaiedOrderItem.Add(new LaterPaiedOrderItem()
                        {
                            OrderID = latercurntsvedorderid,
                            ItemName= dr.Cells["orderItemsName"].Value.ToString(),
                            Quantity = Convert.ToInt32(dr.Cells["quantety"].Value),
                            Size = dr.Cells["Size"].Value.ToString(),
                            TPrice_for_Item = Convert.ToDecimal(dr.Cells["Price_Item"].Value),
                            Price_Item = Convert.ToDecimal(dr.Cells["TotalPrice_for_Item"].Value),
                        });
                    }
                    //foreach (var item in x)
                    //{
                    //    c.LaterPaiedOrderItem.Add(new LaterPaiedOrderItem()
                    //    {
                    //        OrderID = order.OrderID,
                    //        ItemID = item.ItemID,
                    //        Quantity = item.Quantity,
                    //        Size = item.Size,
                    //        TPrice_for_Item = item.TPrice_for_Item,
                    //        Price_Item = item.Price_Item,
                    //        //DateTime = DateTime.Now  //AddeddateTimePicker.Value
                    //    });
                    //}

                    c.SaveChanges();
                 
                    LaterPaiedorder = new LaterPayedOrder();
                    
                    order = new GetOrder();
                    RefreshdataOrderView();
                    clearinfo();
                   
                    dataOrderView.DataSource = null;
                    disableinfo();

                }
            }
            catch { }
       
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AllLatrrPaimentClients allLatrrPaimentClients = new AllLatrrPaimentClients();
            OpenForm(allLatrrPaimentClients);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
            AddFoodItem AddFoodItemm = new AddFoodItem();
            AddFoodItemm.FormClosed += AddfoodClosed;
            OpenForm(AddFoodItemm);
        }
        private void AddfoodClosed(object sender, FormClosedEventArgs e)
        {
            getallitem();
            fpnlShowItem.Controls.Clear();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            solfaClientForm AddNewSolfaa = new solfaClientForm();
            OpenForm(AddNewSolfaa);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

            AllsolfaClient AllsolfaClientt = new AllsolfaClient();
            OpenForm(AllsolfaClientt);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {


            ClientSearchForm ClientSearchFormm = new ClientSearchForm();
            OpenForm(ClientSearchFormm);
        }

        private void fpnlShowItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void laterPaiedradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (laterPaiedradioButton.Checked == true)
            {
                laterPaied.Enabled = true;
                btnPrint.Enabled = false;
                clearinfo();
                disableinfo();
                SearshButon.Enabled = true;
            }
            if (laterPaiedradioButton.Checked == false)
            {
                laterPaied.Enabled = false;
                btnPrint.Enabled = true;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

            gardForm gardFormm = new gardForm();
            OpenForm(gardFormm);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tables t = new Tables();
            t.ShowDialog();
        }

        private void dataOrderView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
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
}
