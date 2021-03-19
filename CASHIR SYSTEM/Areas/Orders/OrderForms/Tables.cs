using CASHIR_SYSTEM.Areas.Orders.OrderForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASHIR_SYSTEM.Areas.Orders
{
    public partial class Tables : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        Button btnTable;

        public Tables()
        {
            InitializeComponent();
            CreateTables();
        }
        public void CreateTables()
        {
            if (context.ByTables.ToList()!=null)
            {
                var tabels = context.ByTables.ToList();
                fpnlTables.Controls.Clear();
                foreach (var item in tabels)
                {
                    btnTable = new Button();
                    btnTable.Width = 160;
                    btnTable.Height = 60;
                    btnTable.Font = new Font("Arial", 12, FontStyle.Bold);
                    btnTable.Text = "طاولة " + item.TableID;
                    btnTable.Tag = item.TableID;
                    if (item.check == 1)
                    {
                        btnTable.BackColor = Color.Red;
                        btnTable.ForeColor = Color.White;
                    }
                    else
                        btnTable.BackColor = Color.Azure;
                    fpnlTables.Controls.Add(btnTable);
                    btnTable.Click += new EventHandler(btnTable_Click);
                }
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == null)
                return;
            TableOrder to = new TableOrder(Convert.ToInt32(b.Tag));
            ///////
            using (var TableOrder = new TableOrder(Convert.ToInt32(b.Tag)))
            {


          
                var result = to.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ApplicationDbContext cntxt = new ApplicationDbContext();
                    var c = cntxt.ByTables.FirstOrDefault(z => z.TableID == (int)b.Tag);
                    if (c.check == 1)
                    {
                        b.BackColor = Color.Red;
                        b.ForeColor = Color.White;
                    }
                    else if (c.check == 0)
                    {
                        b.BackColor = Color.Azure;
                        b.ForeColor = Color.Black;
                    }
                }
            }
            //////
            

            
        }

        private void toClosing(object sender, FormClosingEventArgs e)
        {
            Button b = sender as Button;
            if (b == null)
                return;
            TableOrder f = sender as TableOrder;
            
        }


     

        int i = 1;
        int tid=0;
        ByTables newTable;
        private void button1_Click(object sender, EventArgs e)
        {
            tid = context.ByTables.Count()+1;
            newTable = new ByTables() { TableID = tid };
            context.ByTables.Add(newTable);
            context.SaveChanges();
            CreateTables();
            i++;
        }

        private void btnDeleteTBL_Click(object sender, EventArgs e)
        {
            ApplicationDbContext cntxt = new ApplicationDbContext();
            var num = cntxt.ByTables.Count();
            var del = cntxt.ByTables.FirstOrDefault(z=>z.TableID==num);
            if (del==null)
            {
                MessageBox.Show("قائمة الطاولات فارغة", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (del.check == 1)
            {
                DialogResult dialog = MessageBox.Show("هذه الطاولة يوجد بها طلبات, هل انت متأكد من حذفها؟", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dialog == DialogResult.Cancel)
                {
                    return;
                }
                cntxt.ByTables.Remove(del);
                cntxt.SaveChanges();
                CreateTables();
                MessageBox.Show("تم الحذف بنجاح", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cntxt.ByTables.Remove(del);
                cntxt.SaveChanges();
                CreateTables();
            }
        }
    }
}
