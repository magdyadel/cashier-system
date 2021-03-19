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
   
    public partial class payIfUserExists : Form
    {
        public double Paiedmony { get; set; }
        public double RemaningMony { get; set; }
        public double AllMony { get; set; }
        public int payeddonevalue { get; set; }
        bool match = false;
        public payIfUserExists()
        {
            InitializeComponent();
            payeddonevalue = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void payIfUserExists_Load(object sender, EventArgs e)
        {
            payeddonevalue = 0;
            ReaminngMonyTextBox.Enabled = false;
            Allmonytextbox.Text = this.AllMony.ToString();
            Allmonytextbox.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Paiedmony = Convert.ToDouble(PaiedMonyTextBox.Text);
            this.RemaningMony =  Convert.ToDouble(ReaminngMonyTextBox.Text);
            this.DialogResult = DialogResult.OK;
            
            this.payeddonevalue = 1;
            match = true;
            this.Close();
        }

        private void PaiedMonyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double n;
                double.TryParse(Allmonytextbox.Text, out n);
                if (n == 0)
                {
                    PaiedMonyTextBox.Text = "0";
                    MessageBox.Show("من فضلك ادخل المبلغ المطلوب اولا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (Convert.ToDouble(Allmonytextbox.Text) < Convert.ToDouble(PaiedMonyTextBox.Text))
                {
                    PaiedMonyTextBox.Text = "0";
                    ReaminngMonyTextBox.Text = "0";
                    MessageBox.Show("المدخل غير صحيح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else
                {
                    PaiedMonyTextBox.ReadOnly = false;
                }
                var r = Convert.ToDouble(Allmonytextbox.Text) - Convert.ToDouble(PaiedMonyTextBox.Text);
                ReaminngMonyTextBox.Text = r.ToString();
            }
            catch { }
        }

        private void payIfUserExists_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (match)
            {
                this.payeddonevalue = 1;
            }
            else {
                this.payeddonevalue = 0;
            } 
            this.Close();
        }
    }
}
