using System;
using System.Windows.Forms;
using Aday_DA.Classes;
namespace Aday_DA.Resources
{
    public partial class Form_SignUp : Form
    {
        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "Type Your First Name";
            textBoxLastName.Text = "Type Your Last Name";
            textBoxEmail.Text = "Type Your Email";
            textBoxEmailVerify.Text = "Verify Your Email";
            textBoxPassword.Text = "Type Your Password";
            textBoxPasswordVerify.Text = "Verify Your Password";
        }

        private void textBoxFirstName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxFirstName.Text == "Type Your First Name")
            {
                textBoxFirstName.Text = "";
            }
        }

        private void textBoxLastName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxLastName.Text == "Type Your Last Name")
            {
                textBoxLastName.Text = "";
            }
        }

        private void textBoxEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxEmail.Text == "Type Your Email")
            {
                textBoxEmail.Text = "";
            }
        }

        private void textBoxEmailVerify_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxEmailVerify.Text == "Verify Your Email")
            {
                textBoxEmailVerify.Text = "";
            }
        }

        private void textBoxPasswordVerify_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPasswordVerify.Text == "Verify Your Password")
            {
                textBoxPasswordVerify.Text = "";
                textBoxPasswordVerify.PasswordChar = '*';
            }
        }

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.Text == "Type Your Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "")
            {
                textBoxFirstName.Text = "Type Your First Name";
            }
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "")
            {
                textBoxLastName.Text = "Type Your Last Name";
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Type Your Email";
            }
        }

        private void textBoxEmailVerify_Leave(object sender, EventArgs e)
        {
            if (textBoxEmailVerify.Text == "")
            {
                textBoxEmailVerify.Text = "Verify Your Email";
            }
        }

        private void textBoxPasswordVerify_Leave(object sender, EventArgs e)
        {
            if (textBoxPasswordVerify.Text == "")
            {
                textBoxPasswordVerify.Text = "Verify Your Password";
                textBoxPasswordVerify.PasswordChar = '\0';
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Type Your Password";
                textBoxPassword.PasswordChar = '\0';
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            if (Global.flagLogin)
            {
                this.Close();
                Form_Login formLogin = new Form_Login();
                //form2.BringToFront();
                formLogin.Show();
            }
            else
            {
                this.Enabled = true;
            }
        }
    }
}

//btnSignUp
