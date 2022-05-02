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
    public partial class Dashboard : Form
    {
        private readonly Login _loginForm;
        public Dashboard(Login login)
        {
            InitializeComponent();
            _loginForm = login;
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddMedicine().ShowDialog();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SellMedicine().ShowDialog();
        }
    }
}
