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
    public partial class EditSolfaClientForm : Form
    {
        int clientId;
        ApplicationDbContext context;
        public EditSolfaClientForm()
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
        private void EditSolfaClientForm_Load(object sender, EventArgs e)
        {
            var client = context.solfaClientClass.FirstOrDefault(c => c.Id == this.clientId);
            clientNametextbox.Text = client.Name;
            clientAddresstextbox.Text = client.Address;
            firstPhonetextbox.Text = client.FirstPhoneNumner;
            seceondPhoneTextbox.Text = client.SecondPhoneNumner;      
            NotstextBox.Text = client.Nots;
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                var clientfrondatabase = context.solfaClientClass.FirstOrDefault(c => c.Id == this.clientId);
                clientfrondatabase.Name = clientNametextbox.Text;
                clientfrondatabase.Address = clientAddresstextbox.Text;
                clientfrondatabase.FirstPhoneNumner = firstPhonetextbox.Text;
                clientfrondatabase.SecondPhoneNumner = seceondPhoneTextbox.Text;
             
                clientfrondatabase.Nots = NotstextBox.Text;
                context.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                this.Close();
            }
            catch { }
        }
    }
}
