using Aday_DA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.Mail;
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
            textBoxPassword.Text = "Type Your Password";
            textBoxPasswordVerify.Text = "Verify Your Password";
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
            else if (textBoxPassword.Text == "Type Your Password" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Password cannot be blank.");
            }
            else if (textBoxPassword.Text != textBoxPasswordVerify.Text)
            {
                MessageBox.Show("Passwords need to be the same.");
            }
            else if (textBoxPassword.Text.Length < 10)
            {
                MessageBox.Show("Password Length need to be greater or equal to 10 characters.");
            }
            else
            {
                // Reset Password.
                Global.connectionVar.Open();
                SqlCommand commandVar = Global.connectionVar.CreateCommand();
                commandVar.CommandType = CommandType.Text;
                commandVar.CommandText = "SELECT EmailAddress FROM Customer WHERE EmailAddress = '" + textBoxEmail.Text + "'";
                commandVar.ExecuteNonQuery();
                SqlDataAdapter dataAdapterVar = new SqlDataAdapter(commandVar);
                DataTable dataTableVar = new DataTable();
                dataAdapterVar.Fill(dataTableVar);
                if (dataTableVar.Rows.Count == 0)
                {
                    MessageBox.Show("Email address does not exist in the system.");
                }
                else
                {
                    string email = dataTableVar.Rows[0]["EmailAddress"].ToString();
                    byte[] data = System.Text.Encoding.ASCII.GetBytes(textBoxPassword.Text);
                    data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                    String hash = System.Text.Encoding.ASCII.GetString(data);
                    commandVar.CommandType = CommandType.Text;
                    commandVar.CommandText = "UPDATE Customer SET Password = '" + hash + "' WHERE EmailAddress = '" + email + "'";
                    commandVar.ExecuteNonQuery();
                    MessageBox.Show("Password Changed Successfully.");
                    Global.connectionVar.Close();
                    this.Close();
                }                
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

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.Text == "Type Your Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '*';
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

        private void textBoxPassword_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Type Your Password";
                textBoxPassword.PasswordChar = '\0';
            }
        }

        private void textBoxPasswordVerify_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxPasswordVerify.Text == "")
            {
                textBoxPasswordVerify.Text = "Verify Your Password";
                textBoxPasswordVerify.PasswordChar = '\0';
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Type Your Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void textBoxPasswordVerify_Enter(object sender, EventArgs e)
        {
            if (textBoxPasswordVerify.Text == "Verify Your Password")
            {
                textBoxPasswordVerify.Text = "";
                textBoxPasswordVerify.PasswordChar = '*';
            }
        }
    }
}
