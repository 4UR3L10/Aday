using Aday_DA.Classes;
using Aday_DA.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Aday_DA
{
    public partial class Form_Login : Form
    {
        String hash;
        public Form_Login()
        {
            InitializeComponent();
            string fileName = "AdayDB.mdf";
            string path = Path.GetFullPath(fileName);
            path = path.Replace(@"bin\Debug\netcoreapp3.1\", "");            
            Global.connectionVar = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True");
            Global.flagLogin = true;
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            textBoxPassword.Text = "Type Your Password";
            textBoxEmail.Text = "Type Your Email";
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {

            if (textBoxEmail.Text == "Type Your Email")
            {
                textBoxEmail.Text = "";
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
            String email = "";
            String password = "";

            Global.connectionVar.Open();
            // SELECT. 
            SqlCommand commandVar = Global.connectionVar.CreateCommand();
            commandVar.CommandType = CommandType.Text;

            if (textBoxEmail.Text == "Type Your Email" && textBoxEmail.Text == "")
            {
                MessageBox.Show("Email cannot be blank.");
            }


            if (textBoxPassword.Text == "Type Your Password" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Password cannot be blank.");
            }

            if (textBoxEmail.Text != "Type Your Email" && textBoxEmail.Text != "")
            {
                commandVar.CommandText = "SELECT EmailAddress FROM Customer WHERE EmailAddress = '" + textBoxEmail.Text + "'";
                commandVar.ExecuteNonQuery();                
                SqlDataAdapter dataAdapterVar = new SqlDataAdapter(commandVar);
                DataTable dataTableVar = new DataTable();
                dataAdapterVar.Fill(dataTableVar);
                email = dataTableVar.Rows[0]["EmailAddress"].ToString();
            }

            if (textBoxPassword.Text != "Type Your Password" && textBoxPassword.Text != "")
            {
                //MessageBox.Show(textBoxPassword.Text);
                byte[] data = System.Text.Encoding.ASCII.GetBytes(textBoxPassword.Text);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                hash = System.Text.Encoding.ASCII.GetString(data);
                //MessageBox.Show(hash);
                commandVar.CommandText = "SELECT Password FROM Customer WHERE Password = '" + hash + "' AND EmailAddress = '" + textBoxEmail.Text + "'";


                //commandVar.CommandText = "SELECT Password FROM Customer WHERE Password = '" + textBoxPassword.Text + "'";
                commandVar.ExecuteNonQuery();
                SqlDataAdapter dataAdapterVar = new SqlDataAdapter(commandVar);
                DataTable dataTableVar = new DataTable();
                dataAdapterVar.Fill(dataTableVar);
                if (dataTableVar.Rows.Count == 0)
                {
                    MessageBox.Show("Password is incorrect.");
                }
                else
                {
                    password = dataTableVar.Rows[0]["Password"].ToString();
                }                    
            }

            Global.connectionVar.Close();

            if (email == textBoxEmail.Text && password == hash)
            {
                MessageBox.Show("Login Successfully");
                Form_Main newMain = new Form_Main();
                newMain.Show();
                Global.flagLogin = true;
                this.Enabled = false;
            }
            else
            {
                MessageBox.Show("Email/Password is incorrect.");
            }
            */
            Form_Main newMain = new Form_Main();
            newMain.Show();
        }

        private void labelSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form_SignUp formSignUp = new Form_SignUp();    
            formSignUp.Show();
            this.Enabled = false;
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Type Your Password";
                textBoxPassword.PasswordChar = '\0';
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Type Your Email";
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            Form_Change_Password formChangePassword = new Form_Change_Password();
            formChangePassword.Show();
            this.Enabled = false;
        }
    }
}
