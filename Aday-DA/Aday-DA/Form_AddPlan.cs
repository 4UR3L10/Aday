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
            bool found = false;

            if (txtBox_Title.Text == "")
            {
                MessageBox.Show("You cannot create a plan without providing a title.");
                found = true;
            }
            else if (dateTimePickerPlanDate.Value == dateTimePickerPlanDate.MinDate)
            {
                MessageBox.Show("You cannot create a plan without providing a date.");
                found = true;                
            }
            else if (Global.arrLstPlans.Count != 0)
            {
                foreach (Plan plan in Global.arrLstPlans)
                {
                    if (plan.GetTitle().Equals(txtBox_Title.Text))
                    {
                        MessageBox.Show("You already have this plan in your calendar.");
                        txtBox_Title.Text = "";
                        found = true;
                    }
                }
            }        
            
            if(!found)
            {
                Plan planobj = new Plan(txtBox_Title.Text, dateTimePickerPlanDate.Value);
                Global.arrLstPlans.Add(planobj);

                MessageBox.Show("Plan " + txtBox_Title.Text + " created successfully.");
                txtBox_Title.Text = "";
            }
        }

        private void Form_AddPlan_Load(object sender, EventArgs e)
        {

        }

        private void bt_close_Plan_Event_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
