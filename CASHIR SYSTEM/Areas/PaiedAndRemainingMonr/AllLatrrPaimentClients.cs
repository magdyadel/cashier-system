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
    public partial class AllLatrrPaimentClients : Form
    {
        int clientId;
        ApplicationDbContext context;
        Form CurrentForm;
       
        public AllLatrrPaimentClients()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
          


        }
        public int clientID
        {
            set
            {
                clientId = value;
            }
        }

        public class clientDTO
        {
            public int ID { get; set; }

            [DisplayName("أسم العميل")]
            public String Name { get; set; }

            [DisplayName("العنوان")]
            public String Address { get; set; }
            [DisplayName("الهاتف الاول")]
            public String FirstPhoneNumner { get; set; }
            [DisplayName("الهاتف الثانى")]
            public String SecondPhoneNumner { get; set; }
            [DisplayName("خدمة التوصيل")]
            public double DelevaryService { get; set; }

            [DisplayName("ملا حظات")]
            public String Nots { get; set; }


        }
        public void loadgrid()
        {
          
            dataGridView1.DataSource = null;
            var cl = context.clientLaterPaymentinfos.Select(x => new clientDTO
            {
                ID = x.Id,
                Name = x.Name,
                Address = x.Address,
                FirstPhoneNumner = x.FirstPhoneNumner,
                SecondPhoneNumner = x.SecondPhoneNumner,
                DelevaryService = x.DelevaryService,
                Nots = x.Nots

            }).ToList();


            dataGridView1.DataSource = cl;
            dataGridView1.Columns["ID"].Visible = false;
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
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
            {
                DialogResult dialog = MessageBox.Show("هل انت واثق من انك تريد حذف هذا العميل ", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dialog == DialogResult.Cancel)
                {
                    return;
                }
                int userid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var clientfromdataabase = context.clientLaterPaymentinfos.FirstOrDefault(c => c.Id == userid);
                context.clientLaterPaymentinfos.Remove(clientfromdataabase);
                context.SaveChanges();
                var clientfromdurationlist = context.OrderMoneAndDates.Where(c => c.clientid == userid);
                foreach (var duratioclient in clientfromdurationlist)
                {
                    context.OrderMoneAndDates.Remove(duratioclient);
                    context.SaveChanges();
                }
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

        private void details_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
                {
                    int userid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    LaterPaymentOrderDetails detailLatrrPaimentClients = new LaterPaymentOrderDetails();
                    detailLatrrPaimentClients.clientID = userid;
                    OpenForm(detailLatrrPaimentClients);
                }
                else
                {
                    MessageBox.Show(" اختر العميل المراد رؤية تفاصيلة فقط ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch { }
         
        }

        private void AllLatrrPaimentClients_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void NameSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cl = context.clientLaterPaymentinfos.Where(p => p.Name.Contains(NameSearchTextBox.Text)).Select(x => new clientDTO
            {
                Name = x.Name,
                Address = x.Address,
                FirstPhoneNumner = x.FirstPhoneNumner,
                SecondPhoneNumner = x.SecondPhoneNumner,
                DelevaryService = x.DelevaryService,
                Nots = x.Nots

            }).OrderBy(x => x.Name).ToList();


            dataGridView1.DataSource = cl;
            if (NameSearchTextBox.Text == "")
            {
                loadgrid();
            }
        }

        private void phoneSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void phoneSearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {

        var cl = context.clientLaterPaymentinfos.Where(p => p.FirstPhoneNumner.Contains(phoneSearchTextBox.Text) ||
              p.SecondPhoneNumner.Contains(phoneSearchTextBox.Text)).Select(x => new clientDTO
              {
              
                  Name = x.Name,
                  Address = x.Address,
                  FirstPhoneNumner = x.FirstPhoneNumner,
                  SecondPhoneNumner = x.SecondPhoneNumner,
                  DelevaryService = x.DelevaryService,
                
                  Nots = x.Nots

              }).OrderBy(x => x.Name).ToList();
        dataGridView1.DataSource = cl;
        if (phoneSearchTextBox.Text == "")
        {
            loadgrid();
        }
    }

        private void NameSearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var cl = context.clientLaterPaymentinfos.Where(p => p.Name.Contains(NameSearchTextBox.Text)).Select(x => new clientDTO
            {
                Name = x.Name,
                Address = x.Address,
                FirstPhoneNumner = x.FirstPhoneNumner,
                SecondPhoneNumner = x.SecondPhoneNumner,
                DelevaryService = x.DelevaryService,
                Nots = x.Nots

            }).OrderBy(x => x.Name).ToList();


            dataGridView1.DataSource = cl;
            if (NameSearchTextBox.Text == "")
            {
                loadgrid();
            }

        }

  

        private void formclosed(object sender, FormClosedEventArgs e)
        {
            loadgrid();
        }

        private void NameSearchTextBox_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
