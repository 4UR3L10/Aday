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
            String[] row = { txtBox_Title.Text, dateTimePicker_StartDate.Text, dateTimePicker_EndDate.Text, txtBox_Location.Text, txtBox_Description.Text, chkBox_isHighImportance.Checked.ToString(), chkBox_isAllDay.Checked.ToString() };
            Global.arrLstPlan.Add(row);
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
