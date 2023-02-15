using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
    }
}
