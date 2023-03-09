using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aday_DA.Classes;
namespace Aday_DA
{
    public partial class Form_AddEvent : Form
    {
        public Form_AddEvent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Description_Click(object sender, EventArgs e)
        {

        }

        private void bt_save_Event_Click(object sender, EventArgs e)
        {
            this.Close();
             
        }

        private void bt_close_Adding_Event_Click(object sender, EventArgs e)
        {
            if (Global.flagMain)
            {
                this.Close();
                Form_Main formMain = new Form_Main();
                //form2.BringToFront();
                formMain.Show();
            }
            else
            {
                this.Enabled = true;
            }
        }
    }
}
