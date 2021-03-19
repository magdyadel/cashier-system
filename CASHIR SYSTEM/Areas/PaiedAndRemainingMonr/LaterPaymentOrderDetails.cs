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
    public partial class LaterPaymentOrderDetails : Form
    {
        ApplicationDbContext context;
        int clientId;
        Form CurrentForm;
        public LaterPaymentOrderDetails()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            clientNametextbox.Enabled = false;
            clientAddresstextbox.Enabled = false;
            firstPhonetextbox.Enabled = false;
            seceondPhoneTextbox.Enabled = false;
            allMonyTextbox.Enabled = false;
            paiedMonytextBox.Enabled = false;
            remainingtextBox.Enabled = false;
        }
        public int clientID
        {
            set
            {
                clientId = value;
            }
        }
        public void loadgrid()
        {
            dataGridView1.DataSource = null;
            var cl = context.OrderMoneAndDates.Where(c=>c.clientid == clientId).ToList();
            dataGridView1.DataSource = cl;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["clientid"].Visible = false;
            dataGridView1.Columns["clientLaterPaymentinfo"].Visible = false;
            monydataGridView2.DataSource = null;
            var clmony = context.partsOfPayedMonies.Where(c => c.clientid == clientId).ToList();
            monydataGridView2.DataSource = clmony;
            monydataGridView2.Columns["Id"].Visible = false;
            monydataGridView2.Columns["clientid"].Visible = false;
            monydataGridView2.Columns["clientLaterPaymentinfo"].Visible = false;
    

    }
        private void LaterPaymentOrderDetails_Load(object sender, EventArgs e)
        {
            var client = context.clientLaterPaymentinfos.FirstOrDefault(c => c.Id == clientId);
            clientNametextbox.Text = client.Name;
            clientAddresstextbox.Text = client.Address;
            firstPhonetextbox.Text = client.FirstPhoneNumner;
            seceondPhoneTextbox.Text = client.SecondPhoneNumner;
            loadgrid();

        }

        private void deletemony_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
            {
                DialogResult dialog = MessageBox.Show("هل انت واثق من انك تريد حذف هذالطلب ", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dialog == DialogResult.Cancel)
                {
                    return;
                }
                int durationid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var clientfromdataabase = context.OrderMoneAndDates.FirstOrDefault(c => c.Id == durationid);
                context.OrderMoneAndDates.Remove(clientfromdataabase);
                context.SaveChanges();
            
                MessageBox.Show("تم الحذف بنجاح", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadgrid();
                return;
            }
            else
            {
                MessageBox.Show(" اختر الطلب المراد حذفه فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void clientNametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void monydataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void payMony_Click(object sender, EventArgs e)
        {
            payMonyPart allLatrrPaimentClients = new payMonyPart();
            allLatrrPaimentClients.clientID = this.clientId;
            OpenForm(allLatrrPaimentClients);
            allLatrrPaimentClients.FormClosed += formclose; 

        }

        private void formclose(object sender, FormClosedEventArgs e)
        {
            loadgrid();
        }

        private void firstPhonetextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void seceondPhoneTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double allClientRamaningMony = 0;
                double paiedClientRamaningMony = 0;
                double reamsiningClientRamaningMony = 0;

                var allOrderMonyList = context.OrderMoneAndDates.Where(c => c.clientid == this.clientId)
                    .Select(c => c.allMony).ToList();
                foreach (var item in allOrderMonyList)
                {
                    allClientRamaningMony += item;
                }
                var paiedOrderMonyList = context.OrderMoneAndDates.Where(c => c.clientid == this.clientId)
                  .Select(c => c.paidOrderMony).ToList();
                foreach (var item in paiedOrderMonyList)
                {
                    paiedClientRamaningMony += item;
                }
                var paiedOrderMonyListfromparts = context.partsOfPayedMonies.Where(c => c.clientid == this.clientId)
                 .Select(c => c.PayedOrderMony).ToList();
                foreach (var item in paiedOrderMonyListfromparts)
                {
                    paiedClientRamaningMony += item;
                }
                reamsiningClientRamaningMony = allClientRamaningMony - paiedClientRamaningMony;
                allMonyTextbox.Text = allClientRamaningMony.ToString();
                paiedMonytextBox.Text = paiedClientRamaningMony.ToString();
                if (reamsiningClientRamaningMony < 0)
                {
                    MessageBox.Show(" هذا العميل متبقى لة مبلغ وقدرة  "+ (reamsiningClientRamaningMony*-1 )+ "جنيها", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                remainingtextBox.Text = reamsiningClientRamaningMony.ToString();
            }
            catch { }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (monydataGridView2.SelectedRows.Count > 0 && monydataGridView2.SelectedRows.Count < 2)
            {
                DialogResult dialog = MessageBox.Show("هل انت واثق من انك تريد حذف هذالدفعة من المال ", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dialog == DialogResult.Cancel)
                {
                    return;
                }
                int dofaid = int.Parse(monydataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                var clientfromdataabase = context.partsOfPayedMonies.FirstOrDefault(c => c.Id == dofaid);
                context.partsOfPayedMonies.Remove(clientfromdataabase);
                context.SaveChanges();

                MessageBox.Show("تم الحذف بنجاح", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadgrid();
                return;
            }
            else
            {
                MessageBox.Show(" اختر العميل المراد حذفه فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void showorder_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
            {
                ShowClientPrevousOrder spo = new ShowClientPrevousOrder();
                var d = int.Parse(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                spo.OrderID = d;
                spo.ShowDialog();
            }
            else
            {
                MessageBox.Show(" اختر الطلب المراد عرضة فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
    
}
