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
    public partial class solfaClientForm : Form
        
    {
        ApplicationDbContext context;
        Form CurrentForm;
        SolfaClientClass clientifexistusingphone1=null;
        SolfaClientClass clientifexistusingphone2=null;
        public solfaClientForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            context = new ApplicationDbContext();
        }

        private void PaiedMonytextpox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AllMonytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void AllMonytextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                var r = Convert.ToDouble(AllMonytextBox.Text) - Convert.ToDouble(PaiedMonytextpox.Text);
                RemainingMonytextbox.Text = r.ToString();
                if (Convert.ToDouble(RemainingMonytextbox.Text) < 0)
                {
                    PaiedMonytextpox.Text = "0";
                    RemainingMonytextbox.Text = "0";
                    MessageBox.Show("المدخل غير صحيح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            catch { }
        }

        private void PaiedMonytextpox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double n;
                double.TryParse(AllMonytextBox.Text, out n);
                if (n == 0)
                {
                    PaiedMonytextpox.Text = "0";
                    MessageBox.Show("من فضلك ادخل المبلغ المطلوب اولا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (Convert.ToDouble(AllMonytextBox.Text) < Convert.ToDouble(PaiedMonytextpox.Text))
                {
                    PaiedMonytextpox.Text = "0";
                    RemainingMonytextbox.Text = "0";
                    MessageBox.Show("المدخل غير صحيح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else
                {
                    PaiedMonytextpox.ReadOnly = false;
                }
                var r = Convert.ToDouble(AllMonytextBox.Text) - Convert.ToDouble(PaiedMonytextpox.Text);
                RemainingMonytextbox.Text = r.ToString();
            }
            catch { }
        }

        private void PaiedMonytextpox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void firstPhonetextbox_TextChanged(object sender, EventArgs e)
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

        private void solfaClientForm_Load(object sender, EventArgs e)
        {

        }

        private void savesolfa_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientNametextbox.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم العميل", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToDouble(RemainingMonytextbox.Text) != (Convert.ToDouble(AllMonytextBox.Text) - Convert.ToDouble(PaiedMonytextpox.Text)))
                {

                    MessageBox.Show("القيمة المتبقية من الاموال غير مستحقة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PaiedMonytextpox.Text = "0";
                    RemainingMonytextbox.Text = "0";
                    return;


                }
                var clientifexist = context.solfaClientClass.FirstOrDefault(c => c.Name == clientNametextbox.Text);
               
                if(firstPhonetextbox.Text != "")
                {
                     clientifexistusingphone1 = context.solfaClientClass.FirstOrDefault(c => (c.FirstPhoneNumner == firstPhonetextbox.Text) || (c.SecondPhoneNumner == firstPhonetextbox.Text));

                }
                if (seceondPhoneTextbox.Text != "")
                {
                     clientifexistusingphone2 = context.solfaClientClass.FirstOrDefault(c => (c.FirstPhoneNumner == seceondPhoneTextbox.Text) || (c.SecondPhoneNumner == seceondPhoneTextbox.Text));
                }
                if (clientifexist != null)
                {
                    DialogResult dialog = MessageBox.Show("هذا الاسم موجود بافعل لايمكن اضافةمره اخرى", "المريض موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    if (dialog == DialogResult.OK)
                    {
                        FormClearName();
                        clientifexist = null;
                        return;
                    }
                }
                if (clientifexistusingphone1 != null  || clientifexistusingphone2 != null)
                {
                  

                    DialogResult dialog = MessageBox.Show("رقم الهاتف موجود بافعل لا يمكن اضافةمره اخرى", "المريض موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        FormClearphone();
                        clientifexistusingphone1 = null;
                        clientifexistusingphone2 = null;
                        return;
                    }
                }
                SolfaClientClass newclient = new SolfaClientClass()
                {
                    Name = clientNametextbox.Text,
                    Address = clientAddresstextbox.Text,
                    FirstPhoneNumner = firstPhonetextbox.Text,
                    SecondPhoneNumner = seceondPhoneTextbox.Text,
                    Nots = NotstextBox.Text,

                };

                context.solfaClientClass.Add(newclient);
                context.SaveChanges();
                var curentclientid = context.solfaClientClass.FirstOrDefault(
                    c => c.Name == clientNametextbox.Text &&
                    c.Address == clientAddresstextbox.Text &&
                    c.FirstPhoneNumner == firstPhonetextbox.Text &&
                    c.SecondPhoneNumner == seceondPhoneTextbox.Text &&
                    c.Nots == NotstextBox.Text);

                SolfaClientDetailsClass newduration = new SolfaClientDetailsClass
                {
                    DateAdded = AddeddateTimePicker.Value,
                    allMony = Convert.ToDouble(AllMonytextBox.Text),
                    paidOrderMony = Convert.ToDouble(PaiedMonytextpox.Text),
                    RemaningOrderMony = Convert.ToDouble(RemainingMonytextbox.Text),
                    solfaclientid = curentclientid.Id
                };
                context.solfaClientDetails.Add(newduration);
                context.SaveChanges();
                MessageBox.Show("تم الاضافة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormClear();
            }
            catch {
                MessageBox.Show("من فضلك اكمل البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
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
            NotstextBox.Text = "";

            AllMonytextBox.Text = "";
            PaiedMonytextpox.Text = "";
            RemainingMonytextbox.Text = "";

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
        private void button1_Click(object sender, EventArgs e)
        {
            AllsolfaClient allsolfaClient = new AllsolfaClient();
            OpenForm(allsolfaClient);
                
        }
    }

    
}
