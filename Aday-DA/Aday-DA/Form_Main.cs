using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aday_DA
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_add_Plan_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World!","Message", MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly,false);
            Form_AddPlan form2 = new Form_AddPlan();
            form2.Show();
        }

        private void bt_add_Event_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form_AddEvent form2 = new Form_AddEvent();
            form2.Show();
        }

        private void bt_close_Plan_Event_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
