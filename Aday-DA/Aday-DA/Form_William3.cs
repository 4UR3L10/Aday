using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aday_DA
{
    public partial class Form_William3 : Form
    {
        private Form _parentForm;
        
        public Form_William3(Form parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void Form_William3_Load(object sender, EventArgs e)
        {

        }

        private void bt_close_Adding_Event_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_save_Event_Click(object sender, EventArgs e)
        {
            Form_William4 form4 = new Form_William4(this);
            form4.Show();
            this.Enabled = false;
            form4.FormClosed += (s, args) => this.Enabled = true;
        }
    }
}
