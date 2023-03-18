using Aday_DA.Classes;
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
            Global.MainCntrllr = new MainController();
            Global.flagMain = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_add_Plan_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World!","Message", MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly,false);
            Form_AddPlan AddPlan = new Form_AddPlan();
            //this.Enabled = false;
            AddPlan.Show();
            Global.flagMain = true;
        }

        private void bt_add_Event_Click(object sender, EventArgs e)
        {
            
            //this.Close();
            Form_AddEvent AddEvent = new Form_AddEvent();
            //this.TopLevel = false;
            //this.Enabled = false;
            AddEvent.Show();

            //


            //this.Close();






        }

        private void bt_close_Plan_Event_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Form_Login form2 = new Form_Login();
            //form2.BringToFront();
            //form2.Show();

            if (Global.flagLogin)
            {
                this.Close();
                Form_Login form2 = new Form_Login();
                //form2.BringToFront();
                form2.Show();
                

            }
            else
            {
                this.Enabled = true;
            }


        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewCalendar_Click(object sender, EventArgs e)
        {
            Form_Calendar Calendar = new Form_Calendar();
            Calendar.Show();
        }
    }
}
