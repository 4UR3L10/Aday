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
            InitializeTimer();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Aurelio Aurelio = new Form_Aurelio();
            Aurelio.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Form_Delete Delete = new Form_Delete();
            Delete.Show();
        }

        private void InitializeTimer()
        {
            timerGlobal = new Timer();           
            timerGlobal.Interval = 60 * 1000; // Change it to minutesssssssssssssssssssssssssssssssssssssssssssssss.
            timerGlobal.Tick += new EventHandler(timerGlobal_Tick);
            timerGlobal.Start();
        }

        private void timerGlobal_Tick(object sender, EventArgs e)
        {
            // CHeck Every Second for an event begin time notification.
            Global.CheckEventStart();
            Global.CheckEventConflict();
        }
    }
}
