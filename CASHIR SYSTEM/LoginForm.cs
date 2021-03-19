using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASHIR_SYSTEM
{
    public partial class LoginForm : Form
    {
        ApplicationDbContext context;
        public LoginForm()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var user = context.login.FirstOrDefault(u => u.username == usernametextbox.Text &&
                                                         u.password == passwordtextBox.Text);

            if (user != null)
            {
                if (user.username == "shift1" && user.password == "123")
                {
                    LogInManager.Role = "shift1";
                    
                    Form1 form = new Form1();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    form.FormClosed += closhthisform; 
                    form.Show();
                  
                }
                if (user.username == "shift2" && user.password == "456")
                {
                    LogInManager.Role = "shift2";
                    Form1 form = new Form1();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    form.FormClosed += closhthisform;
                    form.Show();
                   
                }
                if (user.username == "admin" && user.password == "13579")
                {
                    LogInManager.Role = "admin";
                    Form1 form = new Form1();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    form.FormClosed += closhthisform;
                    form.Show();
                    
                }
            }
            if (user == null)
            {
                MessageBox.Show("خطا فى اسم المستخدم او كلمة السر", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
               }
         
        }

        private void closhthisform(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
