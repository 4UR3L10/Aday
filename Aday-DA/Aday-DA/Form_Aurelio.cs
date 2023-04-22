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
    public partial class Form_Aurelio : Form
    {
        public Form_Aurelio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker1.Value.ToShortDateString().ToString());

            //MessageBox.Show(dateTimePicker2.Value.TimeOfDay.ToString());
            MessageBox.Show(dateTimePicker2.Value.ToShortTimeString().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<String> dates = new List<String>();

            // Load all the Existing Plan.
            foreach (Plan plan in Global.arrLstPlans)
            {
                //comboBox1.Items.Add(plan.GetPlanDate().ToShortDateString());
                dates.Add(plan.GetPlanDateYearFormatString());
                //plan.GetPlanDate().Date.

                //MM/DD/YYYY
            }

            dates.Sort();

            foreach (String strdate in dates)
            {
                comboBox1.Items.Add(strdate);       
            }
        }
    }
}
