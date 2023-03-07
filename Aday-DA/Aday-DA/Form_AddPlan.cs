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
    public partial class Form_AddPlan : Form
    {
        public Form_AddPlan()
        {
            InitializeComponent();
        }

        private void bt_save_Plan_Click(object sender, EventArgs e)
        {
            Form_Plans_LVws form2 = new Form_Plans_LVws();
            form2.Show();
            this.Close();
        }

        private void Form_AddPlan_Load(object sender, EventArgs e)
        {

        }

        private void bt_close_Plan_Event_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Main form2 = new Form_Main();
            form2.Show();
        }
    }
}
