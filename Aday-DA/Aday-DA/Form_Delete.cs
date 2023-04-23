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
    public partial class Form_Delete : Form
    {
        public Form_Delete()
        {
            InitializeComponent();
            if (Global.arrLstPlans.Count > 0)
            {
                // Load all the Existing Plan Dates.
                foreach (String strdate in Global.GetOrderedPlanDates())
                {
                    comboBoxDate.Items.Add(strdate);
                }
            }
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Global.arrLstPlans.Count > 0)
            {
                string selectedDate = "";

                comboBoxPlan.SelectedIndex = -1;
                comboBoxPlan.Items.Clear();

                if (comboBoxDate.SelectedIndex != -1)
                {
                    selectedDate = comboBoxDate.SelectedItem.ToString();

                    // Load all the Existing Plan in that Date.
                    foreach (Plan plan in Global.arrLstPlans)
                    {
                        if (plan.GetPlanDateYearFormatString().Equals(selectedDate))
                        {
                            comboBoxPlan.Items.Add(plan.GetTitle());
                        }
                    }

                    comboBoxPlan.Items.Add("All");
                }
            }
        }

        private void comboBoxPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Global.arrLstPlans.Count > 0)
            {
                string selectedPlan = "";
                string selectedDate = "";
                comboBoxEvent.SelectedIndex = -1;
                comboBoxEvent.Items.Clear();

                if (comboBoxPlan.SelectedIndex != -1)
                {
                    selectedPlan = comboBoxPlan.SelectedItem.ToString();
                    selectedDate = comboBoxDate.SelectedItem.ToString();

                    foreach (Plan plan in Global.arrLstPlans)
                    {
                        if (plan.GetPlanDateYearFormatString().Equals(selectedDate))
                        {
                            if (plan.arrLstEventProp.Count > 0)
                            {
                                foreach (Event evnt in plan.arrLstEventProp)
                                {
                                    if (plan.GetTitle().Equals(selectedPlan))
                                    {
                                        comboBoxEvent.Items.Add(evnt.GetTitle());
                                    }                                    
                                }
                            }
                        }                        
                    }

                    comboBoxEvent.Items.Add("All");
                }
            }
        }

        private void bt_close_Adding_Event_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxDate.SelectedIndex == -1)
            {
                MessageBox.Show("You need to add a plan to delete one");
            }
            else if (comboBoxPlan.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select a plan to delete one");
            }
            else if (comboBoxEvent.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select an event to delete one");
            }
        }
    }
}
