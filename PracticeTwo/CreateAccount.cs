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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            var firstName = txt_firstName.Text;
            var lastName = txt_lastName.Text;
            var email = txt_email.Text;
            var password = txt_password.Text;
            var retypePassword = txt_retypePassword.Text;

            User user = new User();
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Email = email;
            user.Password = password;



            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(retypePassword))
            {
                MessageBox.Show("All fields are required. ");
                return;
            }

            if (password != retypePassword)
            {
                MessageBox.Show("Password fields must match! ");
                return;
            }

            using (var db = new WheelsAwayDBContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }

        }

        private void cb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !cb_showPassword.Checked;
            txt_retypePassword.UseSystemPasswordChar = !cb_showPassword.Checked;
        }
    }
}
