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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string file = "C:\\Users\\Kashshaf Labib\\Downloads\\2nd Semester\\SWE 4202 Lab\\SWE4202Lab09A\\LoginInfo\\LoginInfo.txt";
            bool flag = true;
            if(File.Exists(file))
            {
                if(userNametextBox.Text.Length>=4 && passwordtextBox.Text.Length>=6 )
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach(string line in lines)
                    {
                        if(line==userNametextBox.Text)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if(flag==true)
                    {
                        if(passwordtextBox.Text==reTypePasswordtextBox.Text)
                        {
                            File.AppendAllText(file, nametextBox.Text);
                            File.AppendAllText(file,"\n");
                            File.AppendAllText(file, userNametextBox.Text);
                            File.AppendAllText(file, "\n");
                            File.AppendAllText(file, passwordtextBox.Text);
                            File.AppendAllText(file, "\n");
                            LogInFrm lf = new LogInFrm();
                            lf.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password does not match");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This username is unavailable");
                    }
                }
                else
                {
                    MessageBox.Show("Username and password must be at least 4 and 6 characters long respectively");
                }
            }
            

        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInFrm lf = new LogInFrm();
            lf.Show();
            this.Hide();
        }
    }
}
