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
    public partial class EditClientinfo : Form
    {
        int clientId;
        ApplicationDbContext context;
        public EditClientinfo()
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

        private void EditClientinfo_Load(object sender, EventArgs e)
        {
            var client = context.clientLaterPaymentinfos.FirstOrDefault(c => c.Id == this.clientId);
            clientNametextbox.Text = client.Name;
            clientAddresstextbox.Text = client.Address;
            firstPhonetextbox.Text = client.FirstPhoneNumner;
            seceondPhoneTextbox.Text = client.SecondPhoneNumner;
            serviceNumeric.Value = (decimal)client.DelevaryService;
            NotstextBox.Text = client.Nots;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                var clientfrondatabase = context.clientLaterPaymentinfos.FirstOrDefault(c => c.Id == this.clientId);
                clientfrondatabase.Name = clientNametextbox.Text;
                clientfrondatabase.Address = clientAddresstextbox.Text;
                clientfrondatabase.FirstPhoneNumner = firstPhonetextbox.Text;
                clientfrondatabase.SecondPhoneNumner = seceondPhoneTextbox.Text;
                clientfrondatabase.DelevaryService = (double)serviceNumeric.Value;
                clientfrondatabase.Nots = NotstextBox.Text;
                context.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormClear();
                this.Close();
            }
            catch { }
        }
        private void FormClear()
        {
            clientNametextbox.Text = "";
            clientAddresstextbox.Text = "";
            firstPhonetextbox.Text = "";
            seceondPhoneTextbox.Text = "";
            NotstextBox.Text = "";
            serviceNumeric.Value = 0;
           

        }
    }
}
