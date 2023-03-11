using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aday_DA
{
    public partial class Form_Change_Password : Form
    {
        public Form_Change_Password()
        {
            InitializeComponent();
        }

        private void Form_Change_Password_Load(object sender, EventArgs e)
        {
            textBoxEmail.Text = "Type Your Email";
            textBoxEmailVerify.Text = "Verify Your Email";
        }

        private void buttonSendPassword_Click(object sender, EventArgs e)
        {
            if (!textBoxEmail.Text.Contains("@") || !textBoxEmail.Text.Contains("."))
            {
                MessageBox.Show("Enter a valid email address.");
            }
            else if (textBoxEmail.Text != textBoxEmailVerify.Text)
            {
                MessageBox.Show("Emails need to be the same.");
            }
            else if (textBoxEmail.Text == "Type Your Email" || textBoxEmail.Text == "")
            {
                MessageBox.Show("Email cannot be blank.");
            }
            else
            {
                // Reset Password.
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxEmail.Text == "Type Your Email")
            {
                textBoxEmail.Text = "";
            }
        }

        private void textBoxEmail_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Type Your Email";
            }
        }

        private void textBoxEmailVerify_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxEmailVerify.Text == "Verify Your Email")
            {
                textBoxEmailVerify.Text = "";
            }
        }

        private void textBoxEmailVerify_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxEmailVerify.Text == "")
            {
                textBoxEmailVerify.Text = "Verify Your Email";
            }
        }
    }
}
