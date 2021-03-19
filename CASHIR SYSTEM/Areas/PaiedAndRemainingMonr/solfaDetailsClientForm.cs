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
    public partial class solfaDetailsClientForm : Form
    {
        int clientId;
        ApplicationDbContext context;

        Form CurrentForm;
        public solfaDetailsClientForm()
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
            var cl = context.solfaClientDetails.Where(c => c.solfaclientid == clientId).ToList();
            dataGridView1.DataSource = cl;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["solfaclientid"].Visible = false;
            dataGridView1.Columns["solfaClientClass"].Visible = false;
            monydataGridView2.DataSource = null;
            var clmony = context.solfaPartsofPayments.Where(c => c.solfaclientid == clientId).ToList();
            monydataGridView2.DataSource = clmony;
            monydataGridView2.Columns["Id"].Visible = false;
            monydataGridView2.Columns["solfaclientid"].Visible = false;
            monydataGridView2.Columns["solfaClientClass"].Visible = false;


        }

        private void solfaDetailsClientForm_Load(object sender, EventArgs e)
        {
            var client = context.solfaClientClass.FirstOrDefault(c => c.Id == clientId);
            clientNametextbox.Text = client.Name;
            clientAddresstextbox.Text = client.Address;
            firstPhonetextbox.Text = client.FirstPhoneNumner;
            seceondPhoneTextbox.Text = client.SecondPhoneNumner;
            loadgrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void deletemony_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
            {
                DialogResult dialog = MessageBox.Show("هل انت واثق من انك تريد حذف هذة السلفة ", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dialog == DialogResult.Cancel)
                {
                    return;
                }
                int durationid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var clientfromdataabase = context.solfaClientDetails.FirstOrDefault(c => c.Id == durationid);
                context.solfaClientDetails.Remove(clientfromdataabase);
                context.SaveChanges();

                MessageBox.Show("تم الحذف بنجاح", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadgrid();
                return;
            }
            else
            {
                MessageBox.Show(" اختر السلفة المراد حذفها فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                var clientfromdataabase = context.solfaPartsofPayments.FirstOrDefault(c => c.Id == dofaid);
                context.solfaPartsofPayments.Remove(clientfromdataabase);
                context.SaveChanges();

                MessageBox.Show("تم الحذف بنجاح", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadgrid();
                return;
            }
            else
            {
                MessageBox.Show(" اختر الدفعة المراد حذفها فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double allClientRamaningMony = 0;
                double paiedClientRamaningMony = 0;
                double reamsiningClientRamaningMony = 0;

                var allOrderMonyList = context.solfaClientDetails.Where(c => c.solfaclientid == this.clientId)
                    .Select(c => c.allMony).ToList();
                foreach (var item in allOrderMonyList)
                {
                    allClientRamaningMony += item;
                }
                var paiedOrderMonyList = context.solfaClientDetails.Where(c => c.solfaclientid == this.clientId)
                  .Select(c => c.paidOrderMony).ToList();
                foreach (var item in paiedOrderMonyList)
                {
                    paiedClientRamaningMony += item;
                }
                var paiedOrderMonyListfromparts = context.solfaPartsofPayments.Where(c => c.solfaclientid == this.clientId)
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
                    MessageBox.Show(" هذا العميل متبقى لة مبلغ وقدرة  " + (reamsiningClientRamaningMony * -1) + "جنيها", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                remainingtextBox.Text = reamsiningClientRamaningMony.ToString();
            }
            catch { }
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
            paiedSolfaPartForm paiedSolfaPartFormm = new paiedSolfaPartForm();
            paiedSolfaPartFormm.clientID = this.clientId;
            OpenForm(paiedSolfaPartFormm);
            paiedSolfaPartFormm.FormClosed += formclose;

        }

        private void formclose(object sender, FormClosedEventArgs e)
        {
            loadgrid();
        }

        private void addNewSolfa_Click(object sender, EventArgs e)
        {
            AddNewSolfa AddNewSolfaa = new AddNewSolfa();
            AddNewSolfaa.clientID = this.clientId;
            OpenForm(AddNewSolfaa);
            AddNewSolfaa.FormClosed += formclose;
        }
    }
}