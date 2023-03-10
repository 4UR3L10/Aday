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
        public Form_Login()
        {
            InitializeComponent();
            string fileName = "AdayDB.mdf";
            string path = Path.GetFullPath(fileName);
            path = path.Replace(@"bin\Debug\netcoreapp3.1\", "");            
            Global.connectionVar = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True");          
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            textBoxPassword.Text = "Type Your Password";
            textBoxUsername.Text = "Type Your Username";
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {

            if (textBoxUsername.Text == "Type Your Username")
            {
                textBoxUsername.Text = "";
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
            String email = "";
            String password = "";

            Global.connectionVar.Open();
            // SELECT. 
            SqlCommand commandVar = Global.connectionVar.CreateCommand();
            commandVar.CommandType = CommandType.Text;
            

            if (textBoxUsername.Text != "Type Your Username" && textBoxUsername.Text != "")
            {
                commandVar.CommandText = "SELECT EmailAddress FROM Customer WHERE EmailAddress = '" + textBoxUsername.Text + "'";
                commandVar.ExecuteNonQuery();                
                SqlDataAdapter dataAdapterVar = new SqlDataAdapter(commandVar);
                DataTable dataTableVar = new DataTable();
                dataAdapterVar.Fill(dataTableVar);
                email = dataTableVar.Rows[0]["EmailAddress"].ToString();
            }

            if (textBoxPassword.Text != "Type Your Password" && textBoxPassword.Text != "")
            {
                commandVar.CommandText = "SELECT Password FROM Customer WHERE Password = '" + textBoxPassword.Text + "'";
                commandVar.ExecuteNonQuery();
                SqlDataAdapter dataAdapterVar = new SqlDataAdapter(commandVar);
                DataTable dataTableVar = new DataTable();
                dataAdapterVar.Fill(dataTableVar);
                password = dataTableVar.Rows[0]["Password"].ToString();
            }

            Global.connectionVar.Close();



            if (email == textBoxUsername.Text && password == textBoxPassword.Text)
            {
                MessageBox.Show("Login Successfully");
                Form_Main formLogin = new Form_Main();
                formLogin.Show();
                this.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("Username/Password is incorrect.");
            }
        }

        private void labelSignOut_Click(object sender, EventArgs e)
        {

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
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Type Your Username";
            }
        }
    }
}
