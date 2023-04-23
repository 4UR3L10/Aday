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

            DateTime d = dateTimePickerPlanDate.Value;
            DateTime t = dateTimePicker_StartDate.Value;
            string[] dateFormats = d.Date.GetDateTimeFormats();

            //MessageBox.Show(t.ToShortTimeString());

            DateTime combines = new DateTime(d.Year, d.Month, d.Day, t.Hour, t.Minute, t.Second, t.Millisecond);
            MessageBox.Show(combines.ToString());

            DateTime july28 = new DateTime(2009, 7, 28, 5, 23, 15, 16);
            //MessageBox.Show(july28.ToString());

            //MessageBox.Show(dateFormats[0] + " ");



        }
    }
}
