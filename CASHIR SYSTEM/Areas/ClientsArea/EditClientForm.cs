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
    public partial class EditClientForm : Form
    {
        public event EventHandler editpageclosed;

        public int clientId;
        Clientss currentclient;
        ApplicationDbContext context;
        public EditClientForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            context = new ApplicationDbContext();
        }
        public int clientID
        {
            set
            {
                clientId = value;

            }
        }

        private void EditClientForm_Load(object sender, EventArgs e)
        {
            currentclient = context.clients.FirstOrDefault(c => c.Id == clientId);
            clientNametextbox.Text = currentclient.Name;
            clientAddresstextbox.Text = currentclient.Address;
            firstPhonetextbox.Text = currentclient.FirstPhoneNumner;
            seceondPhoneTextbox.Text = currentclient.SecondPhoneNumner;
            AddeddateTimePicker.Value = currentclient.DateAdded;
            serviceNumeric.Value =Convert.ToInt32(currentclient.DelevaryService);
            notstextbox.Text = currentclient.Nots;
        }

        private void notstextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            if (clientNametextbox.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم العميل", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            currentclient.Name = clientNametextbox.Text;
            currentclient.Address = clientAddresstextbox.Text;
            currentclient.FirstPhoneNumner = firstPhonetextbox.Text;
            currentclient.SecondPhoneNumner = seceondPhoneTextbox.Text;
            currentclient.Nots = notstextbox.Text;
            currentclient.DelevaryService = Convert.ToDouble(serviceNumeric.Value);
            currentclient.DateAdded = AddeddateTimePicker.Value;
            context.SaveChanges();

            var clientfrondatabaselaterbaied = context.clientLaterPaymentinfos.FirstOrDefault(c => c.Id == currentclient.LaterClientID);
            clientfrondatabaselaterbaied.Name = clientNametextbox.Text;
            clientfrondatabaselaterbaied.Address = clientAddresstextbox.Text;
            clientfrondatabaselaterbaied.FirstPhoneNumner = firstPhonetextbox.Text;
            clientfrondatabaselaterbaied.SecondPhoneNumner = seceondPhoneTextbox.Text;
            clientfrondatabaselaterbaied.DelevaryService = (double)serviceNumeric.Value;
            clientfrondatabaselaterbaied.Nots = notstextbox.Text;
            context.SaveChanges();
            MessageBox.Show("تم التعديل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (editpageclosed != null)
            {
                editpageclosed(this,e);
            }
            this.Close();
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
