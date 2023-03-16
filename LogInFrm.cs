using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SWE4202Lab09A
{
    public partial class LogInFrm : Form
    {
        public static LogInFrm lfinstance;
        public string username;
        public LogInFrm()
        {
            InitializeComponent();
            lfinstance = this;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string file = "C:\\Users\\Kashshaf Labib\\Downloads\\2nd Semester\\SWE 4202 Lab\\SWE4202Lab09A\\LoginInfo\\LoginInfo.txt";
            bool flag1 = false;
            bool flag2 = false;
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                int i = 1;
                foreach (string line in lines)
                {
                    if (i % 3 == 2 && line == userNametextBox.Text) flag1 = true;
                    if (i % 3 == 0 && line == passwordtextBox.Text) flag2 = true;
                    i++;
                }
                if (flag1 && flag2)
                {
                    username = userNametextBox.Text;
                    DashboardForm df = new DashboardForm();
                    df.Show();
                    this.Hide();
                }
            }

        }

        private void SignupLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm sf=new SignUpForm();
            sf.Show();
            this.Hide();
        }
    }
}
