using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string adminPass = Properties.Settings.Default.Password;


            if (string.IsNullOrEmpty(password) ||
                password != adminPass)
            {
                MessageBox.Show("Password is wrong");
                return;
            }


            txtPassword.Text = "";
            Hide();
            new Dashboard(this).ShowDialog();

            
        }
    }
}
