using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            textBoxPassword.Text = "Type Your Password";
            textBoxUsername.Text = "Type Your Username";
        }
    }
}
