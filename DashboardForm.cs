using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE4202Lab09A
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            WelcomeLabel.Text = "Welcome" + LogInFrm.lfinstance.username;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogInFrm lf=new LogInFrm();
            lf.Show();
            this.Hide();
        }
    }
}
