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
    public partial class AddClientForm : Form
    {
        ApplicationDbContext context;
        Form CurrentForm;
       Clientss clientifexistusingphone1 = null;
        Clientss clientifexistusingphone2 = null;
        public AddClientForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            context = new ApplicationDbContext();
            //if (LogInManager.Role == "admin")
            //{
            //    AddButton.Enabled = true;
            //}
            //else {
            //    AddButton.Enabled = false;
            //}
           
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

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
         

            if (clientNametextbox.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم العميل", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             var clientifexist = context.clients.FirstOrDefault(c => c.Name == clientNametextbox.Text);
           
            if (clientifexist != null)
            {
                DialogResult dialog = MessageBox.Show("هذا الاسم موجود بافعل لا يمكنك اضافتة مرة اخرى ", "المريض موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dialog == DialogResult.OK)
                {
                    FormClearName();
                    clientifexist = null;

                    return;
                }
            }
            if (firstPhonetextbox.Text != "")
            {
                clientifexistusingphone1 = context.clients.FirstOrDefault(c => (c.FirstPhoneNumner == firstPhonetextbox.Text) || (c.SecondPhoneNumner == firstPhonetextbox.Text));

            }
            if (seceondPhoneTextbox.Text != "")
            {
                clientifexistusingphone2 = context.clients.FirstOrDefault(c => (c.FirstPhoneNumner == seceondPhoneTextbox.Text) || (c.SecondPhoneNumner == seceondPhoneTextbox.Text));
            }
         
            if (clientifexistusingphone1 != null || clientifexistusingphone2 != null)
            {


                DialogResult dialog = MessageBox.Show("رقم الهاتف موجود بافعل لا يمكنك اضافتة مرة اخرى ", "المريض موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    FormClearphone();
                    clientifexistusingphone1 = null;
                    clientifexistusingphone2 = null;
                    return;
                }
            }
       
            Clientss newclient = new Clientss()
            {
                Name = clientNametextbox.Text,
                Address = clientAddresstextbox.Text,
                FirstPhoneNumner = firstPhonetextbox.Text,
                SecondPhoneNumner = seceondPhoneTextbox.Text,
                Nots = notstextbox.Text,
                DelevaryService =Convert.ToDouble(serviceNumeric.Value),
                DateAdded = AddeddateTimePicker.Value,
                LaterClientID = 0
            };

            context.clients.Add(newclient);
            context.SaveChanges();
            MessageBox.Show("تم الاضافة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormClear();
            this.Close();
        }

        private void FormClearName()
        {
            clientNametextbox.Text = "";
        }
        private void FormClearphone()
        {
            firstPhonetextbox.Text = "";
            seceondPhoneTextbox.Text = "";

        }
        private void FormClear()
        {
            clientNametextbox.Text = "";
            clientAddresstextbox.Text = "";
            firstPhonetextbox.Text = "";
            seceondPhoneTextbox.Text = "";
            notstextbox.Text = "";
            serviceNumeric.Value = 0;

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

        private void searchButton_Click(object sender, EventArgs e)
        {

            ClientSearchForm searchClientForm = new ClientSearchForm();
            OpenForm(searchClientForm);
        }

        private void firstPhonetextbox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void seceondPhoneTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void serviceNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void firstPhonetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientAddresstextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientNametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddeddateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void notstextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
