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
    public partial class AddNewSolfa : Form
    {
        ApplicationDbContext context;
        int clientId;
        public AddNewSolfa()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            clientNametextbox.Enabled = false;
            clientAddresstextbox.Enabled = false;
            firstPhonetextbox.Enabled = false;
            seceondPhoneTextbox.Enabled = false;
        }
        public int clientID
        {
            set
            {
                clientId = value;
            }
        }
        private void AddNewSolfa_Load(object sender, EventArgs e)
        {
            var client = context.solfaClientClass.FirstOrDefault(c => c.Id == clientId);
            clientNametextbox.Text = client.Name;
            clientAddresstextbox.Text = client.Address;
            firstPhonetextbox.Text = client.FirstPhoneNumner;
            seceondPhoneTextbox.Text = client.SecondPhoneNumner;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (Convert.ToDouble(RemainingMonytextbox.Text) != (Convert.ToDouble(allMonytextpox.Text) - Convert.ToDouble(Paiedmonytextbox.Text)))
                {

                    MessageBox.Show("القيمة المتبقية من الاموال غير مستحقة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    allMonytextpox.Text = "0";
                    RemainingMonytextbox.Text = "0";
                    return;


                }
              
                SolfaClientDetailsClass newduration = new SolfaClientDetailsClass
                {
                    DateAdded = dateTimePicker1.Value,
                    allMony = Convert.ToDouble(allMonytextpox.Text),
                    paidOrderMony = Convert.ToDouble(Paiedmonytextbox.Text),
                    RemaningOrderMony = Convert.ToDouble(RemainingMonytextbox.Text),
                    solfaclientid = this.clientId
                };
                context.solfaClientDetails.Add(newduration);
                context.SaveChanges();
                MessageBox.Show("تم الاضافة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("من فضلك اكمل البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void allMonytextpox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                var r = Convert.ToDouble(allMonytextpox.Text) - Convert.ToDouble(Paiedmonytextbox.Text);
                RemainingMonytextbox.Text = r.ToString();
                if (Convert.ToDouble(RemainingMonytextbox.Text) < 0)
                {
                    Paiedmonytextbox.Text = "0";
                    RemainingMonytextbox.Text = "0";
                    MessageBox.Show("المدخل غير صحيح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            catch { }
        }

        private void Paiedmonytextbox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double n;
                double.TryParse(allMonytextpox.Text, out n);
                if (n == 0)
                {
                    Paiedmonytextbox.Text = "0";
                    MessageBox.Show("من فضلك ادخل المبلغ المطلوب اولا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (Convert.ToDouble(allMonytextpox.Text) < Convert.ToDouble(Paiedmonytextbox.Text))
                {
                    Paiedmonytextbox.Text = "0";
                    RemainingMonytextbox.Text = "0";
                    MessageBox.Show("المدخل غير صحيح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else
                {
                    Paiedmonytextbox.ReadOnly = false;
                }
                var r = Convert.ToDouble(allMonytextpox.Text) - Convert.ToDouble(Paiedmonytextbox.Text);
                RemainingMonytextbox.Text = r.ToString();
            }
            catch { }
        }

        private void allMonytextpox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Paiedmonytextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void RemainingMonytextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
