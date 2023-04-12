using Aday_DA.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
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
            if (textBoxFirstName.Text == "Type Your First Name" || textBoxFirstName.Text == "")
            {
                MessageBox.Show("First Name cannot be blank.");
            }
            else if (textBoxLastName.Text == "Type Your Last Name" || textBoxLastName.Text == "")
            {
                MessageBox.Show("Last Name cannot be blank.");
            }
            else if (!textBoxEmail.Text.Contains("@") || !textBoxEmail.Text.Contains("."))
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
                Global.connectionVar.Open();
                SqlCommand commandVar = Global.connectionVar.CreateCommand();
                commandVar.CommandType = CommandType.Text;
                commandVar.CommandText = "SELECT EmailAddress FROM Customer WHERE EmailAddress = '" + textBoxEmail.Text + "'";
                commandVar.ExecuteNonQuery();
                SqlDataAdapter dataAdapterVar = new SqlDataAdapter(commandVar);
                DataTable dataTableVar = new DataTable();
                dataAdapterVar.Fill(dataTableVar);
                if(dataTableVar.Rows.Count == 0)
                {
                    commandVar = Global.connectionVar.CreateCommand();
                    commandVar.CommandType = CommandType.Text;
                    commandVar.CommandText = "SELECT MAX(CustomerID) FROM Customer";
                    commandVar.ExecuteNonQuery();
                    dataAdapterVar = new SqlDataAdapter(commandVar);
                    dataTableVar = new DataTable();
                    dataAdapterVar.Fill(dataTableVar);
                    string CustomerID = dataTableVar.Rows[0][0].ToString();
                    int CustID = Int16.Parse(CustomerID) + 1;
                    CustomerID = CustID.ToString();

                    byte[] data = System.Text.Encoding.ASCII.GetBytes(textBoxPassword.Text);
                    data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                    String hash = System.Text.Encoding.ASCII.GetString(data);

                    commandVar.CommandText = "INSERT into Customer values('"+CustomerID+ "','"+textBoxFirstName.Text+"','"+textBoxLastName.Text+ "','"+ textBoxEmail.Text+"','"+hash+ "')";
                    commandVar.ExecuteNonQuery();
                    MessageBox.Show("User Created Successfully.");
                    Global.connectionVar.Close();
                    this.Close();
                }
                else
                {
                    string email = dataTableVar.Rows[0]["EmailAddress"].ToString();
                    MessageBox.Show("you already have an account associated with this email address.");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

//btnSignUp
