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
        }

        private void bt_add_Plan_Click(object sender, EventArgs e)
        {
            Form_AddPlan AddPlan = new Form_AddPlan();
            AddPlan.Show();
        }

        private void bt_add_Event_Click(object sender, EventArgs e)
        {
            Form_AddEvent AddEvent = new Form_AddEvent();
            AddEvent.Show();
        }

        private void bt_close_Plan_Event_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewCalendar_Click(object sender, EventArgs e)
        {
            Form_Calendar Calendar = new Form_Calendar();
            Calendar.Show();
        }

        private void bt_delete_Plan_Event_Click(object sender, EventArgs e)
        {

        }
    }
}
