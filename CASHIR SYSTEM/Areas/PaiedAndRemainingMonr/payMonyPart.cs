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
    public partial class payMonyPart : Form
    {
        int clientordeid;
        int clientId;
        ApplicationDbContext context;
        public payMonyPart()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            context = new ApplicationDbContext();
        }
      
        public int ClietOrdeId
        {
            set
            {
                clientordeid = value;
            }
        }
        public int clientID
        {
            set
            {
                clientId = value;
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void payMonyPart_Load(object sender, EventArgs e)
        {
            var username = context.clientLaterPaymentinfos.Where(c => c.Id == clientId);//.Select(c => c.Name);
            foreach (var item in username)
            {
                clientnametextbox.Text = item.Name;
            }
            
            clientnametextbox.Enabled = false;
        }

        private void PaiedMonytextpox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaiedMonytextpox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PartsOfPayedMony pa = new PartsOfPayedMony
                {
                    PayedOrderMony = Convert.ToDouble(PaiedMonytextpox.Text),
                    DateOfPay = dateTimePicker1.Value,
                    clientid = clientId,
                    
                };
                context.partsOfPayedMonies.Add(pa);
                context.SaveChanges();
                MessageBox.Show("تم الاضافة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch { }
        }
    }
}
