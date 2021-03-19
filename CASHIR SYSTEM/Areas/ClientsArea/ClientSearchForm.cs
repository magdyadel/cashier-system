using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASHIR_SYSTEM.Areas.Clients
{
    public partial class ClientSearchForm : Form
    {
        ApplicationDbContext context;
        
        public ClientSearchForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            context = new ApplicationDbContext();
            loadgrid();
        }
        public int clientID { get; set; }
       
        public void loadgrid()
        {
            var cl = context.clients.Select(x => new clientDTO
                   {
                       Id = x.Id,
                       Name = x.Name,
                       Address = x.Address,
                       FirstPhoneNumner = x.FirstPhoneNumner,
                       SecondPhoneNumner = x.SecondPhoneNumner,
                       DelevaryService = x.DelevaryService,
                       DateAdded = x.DateAdded,
                       Nots = x.Nots

                   }).ToList();


            dataGridView1.DataSource = cl;
            dataGridView1.Columns["id"].Visible = false;
        }
        private void ClientSearchForm_Load(object sender, EventArgs e)
        {
           
        }
        public class clientDTO
        {
            public int Id { get; set; }
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
            [DisplayName("تاريخ   الاضافة ")]
            public DateTime DateAdded { get; set; }
            [DisplayName("ملا حظات")]
            public String Nots { get; set; }


        }
        private void cearshtextbox_KeyUp(object sender, KeyEventArgs e)
        {
            var cl = context.clients.Where(p => p.Name.Contains(cearshtextbox.Text)).Select(x => new clientDTO
                                           {
                                               Id = x.Id,
                                               Name = x.Name,
                                               Address = x.Address,
                                               FirstPhoneNumner = x.FirstPhoneNumner,
                                               SecondPhoneNumner = x.SecondPhoneNumner,
                                               DelevaryService = x.DelevaryService,
                                               DateAdded = x.DateAdded,
                                               Nots = x.Nots

                                           }).OrderBy(x => x.Name).ToList();


            dataGridView1.DataSource = cl;
            dataGridView1.Columns["id"].Visible = false;
            if (cearshtextbox.Text == "")
            {
                loadgrid(); 
            }

        }

        private void searchphonenumbertextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void searchphonenumbertextbox_KeyUp(object sender, KeyEventArgs e)
        {
            var cl = context.clients.Where(p => p.FirstPhoneNumner.Contains(searchphonenumbertextbox.Text) ||
                  p.SecondPhoneNumner.Contains(searchphonenumbertextbox.Text)).Select(x => new clientDTO
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                FirstPhoneNumner = x.FirstPhoneNumner,
                SecondPhoneNumner = x.SecondPhoneNumner,
                DelevaryService = x.DelevaryService,
                DateAdded = x.DateAdded,
                Nots = x.Nots

            }).OrderBy(x => x.Name).ToList();


            dataGridView1.DataSource = cl;
            dataGridView1.Columns["id"].Visible = false;
            if (searchphonenumbertextbox.Text == "")
            {
                loadgrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
                {
                    EditClientForm editClientForm = new EditClientForm();
                    editClientForm.clientId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    editClientForm.Show();
             
                    editClientForm.FormClosed += formclossed;
                }
                else
                {
                    MessageBox.Show(" اختر صف واحدد فقط للتعديل");
                    return;
                }
        }
        
        private void formclossed(object sender, FormClosedEventArgs e)
        {
            this.loadgrid();
        }

        private void deletepatientbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
            {
                DialogResult dialog = MessageBox.Show("هل انت واثق من انك تريد حذف هذا العميل ", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dialog == DialogResult.Cancel)
                {
                    return;
                }
                int userid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var clientfromdataabase = context.clients.FirstOrDefault(p => p.Id == userid);
                ///////////////////
                var Laterclientfromdataabase = context.clientLaterPaymentinfos.FirstOrDefault(p => p.Id == clientfromdataabase.LaterClientID);
                if (Laterclientfromdataabase != null)
                {
                    DialogResult dialogg = MessageBox.Show("هذا العميل موجود بقائمة عملاء الدفع الاجل يجب مراجعة الاموال وحذفة من هناك اولا ", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dialogg == DialogResult.OK)
                    {
                        return;
                    };
                }
                /////////////
                context.clients.Remove(clientfromdataabase);
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
            {
                this.clientID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(" اختر العميل المراد  فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddClientForm AddClientFormm = new AddClientForm();
            AddClientFormm.Show();

            AddClientFormm.FormClosed += formclossed;
        }
    }
}
