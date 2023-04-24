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
            // Bypass Login For Testing Purposes.
            if (textBoxEmail.Text == "asdf" && textBoxEmail.Text == "asdf")
            //if (true)
            {                
                Form_Main newMain = new Form_Main();
                newMain.Show();
                this.Enabled = false;
                newMain.FormClosed += (s, args) => this.Enabled = true;
            }
            else
            {
                
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
                    this.Enabled = false;
                    newMain.FormClosed += (s, args) => this.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Email/Password is incorrect.");
                }               
            }
        }

        private void labelSignOut_Click(object sender, EventArgs e)
        {
            Global.WriteToDataFile();
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form_SignUp formSignUp = new Form_SignUp();    
            formSignUp.Show();
            this.Enabled = false;
            formSignUp.FormClosed += (s, args) => this.Enabled = true;
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
            formChangePassword.FormClosed += (s, args) => this.Enabled = true;
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Type Your Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '*';
            }
        }
    }
}
