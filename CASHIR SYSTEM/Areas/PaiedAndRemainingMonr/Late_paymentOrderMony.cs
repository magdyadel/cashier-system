using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASHIR_SYSTEM.Areas;
using System.Windows.Forms;
using CASHIR_SYSTEM.Areas.Clients;

namespace CASHIR_SYSTEM.Areas.PaiedAndRemainingMonr
{
    public partial class Late_paymentOrderMony : Form
    {
        ApplicationDbContext context;
        Form CurrentForm;
        ClientLaterPaymentinfo clientifexistusingphone1;
        ClientLaterPaymentinfo clientifexistusingphone2;
        Clientss clientifexistusingphone1inclienttable;
        Clientss clientifexistusingphone2inclienttable;
        int clientId;
        double allmony;
        bool onematch = false;
        int ordeid;
        public Late_paymentOrderMony()
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            context = new ApplicationDbContext();


        }
        public int donevalue { get; set; }
        public int OrdeId
        {
            set
            {
                ordeid = value;
            }
        }
        public int clientID
        {
            set
            {
                clientId = value;
            }
        }
        public Double AllmonyPaied
        {
            set
            {
                allmony = value;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Late_paymentOrderMony_Load(object sender, EventArgs e)
        {
            onematch = false;
            if (this.clientId > 0)
            {
                ClientLaterPaymentinfo clientalredyexist2 = null;
                ClientLaterPaymentinfo clientalredyexist3 = null;
              var paclient =  context.clients.FirstOrDefault(c=>c.Id == this.clientId);
               var clientalredyexist = context.clientLaterPaymentinfos.FirstOrDefault(c => c.Name == paclient.Name );
                if (paclient.FirstPhoneNumner != "")
                {
                     clientalredyexist2 = context.clientLaterPaymentinfos.FirstOrDefault(c => c.FirstPhoneNumner == paclient.FirstPhoneNumner ||
                                                                                                  c.FirstPhoneNumner == paclient.SecondPhoneNumner    );

                }
                if (paclient.SecondPhoneNumner != "")
                {
                     clientalredyexist3 = context.clientLaterPaymentinfos.FirstOrDefault(c => c.SecondPhoneNumner == paclient.FirstPhoneNumner ||
                                                                                                  c.SecondPhoneNumner == paclient.SecondPhoneNumner);
                }
                if (clientalredyexist != null )
                {
                    onematch = true;
                    this.donevalue = 0;
                    DialogResult dialog =  MessageBox.Show("هذا العميل موجود بالفعل هل تريض اضافة طلب جديد له", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                        using (var payednew = new payIfUserExists())
                        {
                            payednew.AllMony = this.allmony;
                            var result = payednew.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                if(payednew.payeddonevalue == 0)
                                {
                                   this.closethisform();
                                    return;
                                }
                                OrderMoneAndDate pay = new OrderMoneAndDate()
                                {
                                    clientid = clientalredyexist.Id,
                                    DateAdded = DateTime.Now,
                                    allMony = this.allmony,
                                    paidOrderMony = payednew.Paiedmony,
                                    RemaningOrderMony = payednew.RemaningMony,
                                    orderid = this.ordeid

                                };
                                context.OrderMoneAndDates.Add(pay);
                                context.SaveChanges();
                            }
                        }

                        MessageBox.Show("تمت الاضافة بنجاح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.donevalue = 1;
                        this.DialogResult = DialogResult.OK;
                        this.Close();


                    }
                    if (dialog == DialogResult.No)
                    {
                        this.Close();
                    }
                    this.Close();

                }
                if (clientalredyexist2 != null)
                {
                    if(onematch == false)
                    {
                        onematch = true;
                        this.donevalue = 0;
                        DialogResult dialog = MessageBox.Show("هذا العميل موجود بالفعل هل تريض اضافة طلب جديد له", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialog == DialogResult.Yes)
                        {

                            using (var payednew = new payIfUserExists())
                            {
                                var result = payednew.ShowDialog();
                                if (result == DialogResult.OK)
                                {
                                    if (payednew.payeddonevalue == 0)
                                    {
                                        this.closethisform();
                                        return;
                                    }

                                    OrderMoneAndDate pay = new OrderMoneAndDate()
                                    {

                                        clientid = clientalredyexist.Id,
                                        DateAdded = DateTime.Now,
                                        allMony = this.allmony,
                                        paidOrderMony = payednew.Paiedmony,
                                        RemaningOrderMony = payednew.RemaningMony,
                                        orderid = this.ordeid

                                    };
                                    context.OrderMoneAndDates.Add(pay);
                                    context.SaveChanges();
                                }
                            }
                            MessageBox.Show("تمت الاضافة بنجاح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.donevalue = 1;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        if (dialog == DialogResult.No)
                        {
                            this.Close();

                        }
                        this.Close();
                    }
                  

                }
                if (clientalredyexist3 != null)
                {
                    if (onematch == false)
                    {
                        onematch = true;
                        this.donevalue = 0;
                        DialogResult dialog = MessageBox.Show("هذا العميل موجود بالفعل هل تريض اضافة طلب جديد له", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialog == DialogResult.Yes)
                        {

                            using (var payednew = new payIfUserExists())
                            {
                                var result = payednew.ShowDialog();
                                if (result == DialogResult.OK)
                                {
                                    if (payednew.payeddonevalue == 0)
                                    {
                                        this.closethisform();
                                        return;
                                    }
                                    OrderMoneAndDate pay = new OrderMoneAndDate()
                                    {
                                        clientid = clientalredyexist.Id,
                                        DateAdded = DateTime.Now,
                                        allMony = this.allmony,
                                        paidOrderMony = payednew.Paiedmony,
                                        RemaningOrderMony = payednew.RemaningMony,
                                        orderid = this.ordeid

                                    };
                                    context.OrderMoneAndDates.Add(pay);
                                    context.SaveChanges();
                                }
                            }
                            MessageBox.Show("تمت الاضافة بنجاح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.donevalue = 1;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        if (dialog == DialogResult.No)
                        {
                            this.Close();
                        }
                        this.Close();
                    }
                  
                }

                clientNametextbox.Text = paclient.Name;
                clientAddresstextbox.Text = paclient.Address;
                firstPhonetextbox.Text = paclient.FirstPhoneNumner;
                seceondPhoneTextbox.Text = paclient.SecondPhoneNumner;
                serviceNumeric.Value =Convert.ToInt32( paclient.DelevaryService);
                AllMonytextBox.Text = allmony.ToString();

            }
            if (allmony>0)
            {
                AllMonytextBox.Text = allmony.ToString();
            }
        }

        private void closethisform()
        {
            this.donevalue = 0;
            this.DialogResult = DialogResult.OK;
            this.Close();
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

        private void AllMonytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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

        private void Save_Click(object sender, EventArgs e)
        {
            this.donevalue = 0;
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
                var clientifexist = context.clientLaterPaymentinfos.FirstOrDefault(c => c.Name == clientNametextbox.Text);
                var clientexistinmainclienttable = context.clients.FirstOrDefault(c => c.Name == clientNametextbox.Text);
                if (firstPhonetextbox.Text != "")
                {
                    clientifexistusingphone1 = context.clientLaterPaymentinfos.FirstOrDefault(c => (c.FirstPhoneNumner == firstPhonetextbox.Text) || (c.SecondPhoneNumner == firstPhonetextbox.Text));
                    clientifexistusingphone1inclienttable = context.clients.FirstOrDefault(c => (c.FirstPhoneNumner == firstPhonetextbox.Text) || (c.SecondPhoneNumner == firstPhonetextbox.Text));


                }
                if (seceondPhoneTextbox.Text != "")
                {
                    clientifexistusingphone2 = context.clientLaterPaymentinfos.FirstOrDefault(c => (c.FirstPhoneNumner == seceondPhoneTextbox.Text) || (c.SecondPhoneNumner == seceondPhoneTextbox.Text));
                    clientifexistusingphone2inclienttable = context.clients.FirstOrDefault(c => (c.FirstPhoneNumner == seceondPhoneTextbox.Text) || (c.SecondPhoneNumner == seceondPhoneTextbox.Text));

                }
                if (clientifexist != null)
                {
                    DialogResult dialog = MessageBox.Show("هذا الاسم موجود بافعل لا يمكنك اضافتة مرة اخرى", "المريض موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        FormClearName();
                        clientifexist = null;
                        return;
                    }
                }
                if (clientexistinmainclienttable != null)
                {
                    DialogResult dialog = MessageBox.Show("هذا الاسم موجود بافعل فى قائمة العملاء يمكنك اضافة دفع اجل له من هناك", "المريض موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        FormClearName();
                        clientifexist = null;
                        return;
                    }
                }

                if (clientifexistusingphone1 != null || clientifexistusingphone2 != null)
                {


                    DialogResult dialog = MessageBox.Show("رقم الهاتف  موجود بافعل لا يمكنك اضافتة مرة اخرى ", "المريض موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {      
                        FormClearphone();
                        clientifexistusingphone1 = null;
                        clientifexistusingphone2 = null;
                        return;
                    }
                }

                if (clientifexistusingphone1inclienttable != null || clientifexistusingphone2inclienttable != null)
                {


                    DialogResult dialog = MessageBox.Show("رقم الهاتف لهذا العميل موجود بافعل فى قائمة العملاء يمكنك اضافة دفع اجل له من هناك", "المريض موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        FormClearphone();
                        clientifexistusingphone1inclienttable = null;
                        clientifexistusingphone2inclienttable = null;
                        return;
                    }
                }
                ClientLaterPaymentinfo newclient = new ClientLaterPaymentinfo()
                {
                    Name = clientNametextbox.Text,
                    Address = clientAddresstextbox.Text,
                    FirstPhoneNumner = firstPhonetextbox.Text,
                    SecondPhoneNumner = seceondPhoneTextbox.Text,
                    Nots = NotstextBox.Text,
                    DelevaryService = Convert.ToDouble(serviceNumeric.Value),
                 
                };

                context.clientLaterPaymentinfos.Add(newclient);
                context.SaveChanges();

               Clientss newclientt = new Clientss()
                {
                    Name = clientNametextbox.Text,
                    Address = clientAddresstextbox.Text,
                    FirstPhoneNumner = firstPhonetextbox.Text,
                    SecondPhoneNumner = seceondPhoneTextbox.Text,
                    Nots = NotstextBox.Text,
                    DelevaryService = Convert.ToDouble(serviceNumeric.Value),
                    DateAdded = AddeddateTimePicker.Value,
                    LaterClientID = newclient.Id
               };

                context.clients.Add(newclientt);
                context.SaveChanges();

                var curentclientid = context.clientLaterPaymentinfos.FirstOrDefault(
                    c => c.Name == clientNametextbox.Text &&
                    c.Address == clientAddresstextbox.Text &&
                    c.FirstPhoneNumner == firstPhonetextbox.Text &&
                    c.SecondPhoneNumner == seceondPhoneTextbox.Text &&
                    c.Nots == NotstextBox.Text
                    );

                OrderMoneAndDate newduration = new OrderMoneAndDate
                {
                    DateAdded = AddeddateTimePicker.Value,
                    allMony = Convert.ToDouble(AllMonytextBox.Text),
                    paidOrderMony = Convert.ToDouble(PaiedMonytextpox.Text),
                    RemaningOrderMony = Convert.ToDouble(RemainingMonytextbox.Text),
                    clientid = curentclientid.Id,
                    orderid = this.ordeid
                };
                context.OrderMoneAndDates.Add(newduration);
                context.SaveChanges();
                MessageBox.Show("تم الاضافة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormClear();

                this.donevalue = 1;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch {
                DialogResult dialog = MessageBox.Show("من فضلك اكمل بيانات الدفع", "المريض موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            serviceNumeric.Value = 0;
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
        private void AllLaterPaidClient_Click(object sender, EventArgs e)
        {
            AllLatrrPaimentClients allLatrrPaimentClients = new AllLatrrPaimentClients();
           allLatrrPaimentClients.clientID = 1;
            OpenForm(allLatrrPaimentClients);
        }
    }
}
