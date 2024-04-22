using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btn_Login_Click(object sender, EventArgs e)
        {
            var name = txt_name.Text;   
            var password = txt_password.Text;

            bool isUserMatched = false;

            using (var db = new WheelsAwayDBContext())
            {
                isUserMatched = db.Users.Any(user => user.FirstName + user.LastName == name && user.Password == password && user.IsEmployee);

                if (isUserMatched)
                {
                    ControlPage controlPage = new ControlPage();
                    controlPage.ShowDialog();
                }else
                {
                    MessageBox.Show("Incvalid credentials. ");
                    txt_name.Clear();
                    txt_password.Clear();
                }
            }
        }

        private void cb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !cb_showPassword.Checked;
        }

        private void txt_createAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();  
            createAccount.ShowDialog();
        }
    }
}
