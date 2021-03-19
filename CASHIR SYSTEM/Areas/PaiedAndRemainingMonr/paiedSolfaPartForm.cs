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
    public partial class paiedSolfaPartForm : Form
    {
        ApplicationDbContext context;
        int clientId;
    
        public paiedSolfaPartForm()
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
      
        private void paiedSolfaPartForm_Load(object sender, EventArgs e)
        {
            var username = context.solfaClientClass.Where(c => c.Id == clientId);//.Select(c => c.Name);
            foreach (var item in username)
            {
                clientnametextbox.Text = item.Name;
            }

            clientnametextbox.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                solfaPartsofPayment pa = new solfaPartsofPayment
                {
                    PayedOrderMony = Convert.ToDouble(PaiedMonytextpox.Text),
                    DateOfPay = dateTimePicker1.Value,
                    solfaclientid = clientId
                };
                context.solfaPartsofPayments.Add(pa);
                context.SaveChanges();
                MessageBox.Show("تم الاضافة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch { }
        }
    }
}
