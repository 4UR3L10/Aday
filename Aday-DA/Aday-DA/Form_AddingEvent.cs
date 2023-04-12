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

            // Load all the Existing Plan.
            foreach (Plan plan in Global.arrLstPlans)
            {
                comboBoxPlan.Items.Add(plan.GetTitle());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Description_Click(object sender, EventArgs e)
        {

        }

        private void bt_save_Event_Click(object sender, EventArgs e)
        {
            bool found = false;
            bool errorFound = false;
            string selectedPlan = comboBoxPlan.SelectedItem.ToString();

            // Check for DropDown EMpty.
            if (comboBoxPlan.SelectedIndex == -1)
            {
                MessageBox.Show("You cannot save an event without selecting a plan to store it.");
                errorFound = true;
            }
            else if (txtBox_Title.Text == "")
            {
                MessageBox.Show("You cannot create a event without providing a title.");
                errorFound = true;
            }
            // Check for Date not selected.
            else if (dateTimePicker_StartDate.Value == dateTimePicker_StartDate.MinDate)
            {
                MessageBox.Show("You cannot create a event without selecting an Start Date Time.");
                errorFound = true;
            }
            // Check for Date not selected.
            else if (dateTimePicker_EndDate.Value == dateTimePicker_EndDate.MinDate)
            {
                MessageBox.Show("You cannot create a event without selecting an End Date Time.");
                errorFound = true;
            }
            else if (txtBox_Location.Text == "")
            {
                MessageBox.Show("You cannot create a event without providing a location.");
                errorFound = true;
            }
            else if (txtBox_Description.Text == "")
            {
                MessageBox.Show("You cannot create a event without providing a description.");
                errorFound = true;
            }

            if (!errorFound)
            {
                // Check if the event on the selected plan is already added.
                if (Global.arrLstPlans.Count != 0)
                {
                    foreach (Plan plan in Global.arrLstPlans)
                    {
                        if (plan.GetTitle().Equals(selectedPlan))
                        {
                            if (plan.arrLstEventProp != null)
                            {
                                foreach (Event evnt in plan.arrLstEventProp)
                                {
                                    if (evnt.GetTitle().Equals(txtBox_Title.Text))
                                    {
                                        MessageBox.Show("You already have this event in this calendar.");
                                        comboBoxPlan.SelectedIndex = -1;
                                        txtBox_Title.Text = "";
                                        dateTimePicker_StartDate.Value = dateTimePicker_StartDate.MinDate;
                                        dateTimePicker_EndDate.Value = dateTimePicker_EndDate.MinDate;
                                        txtBox_Location.Text = "";
                                        txtBox_Description.Text = "";
                                        chkBox_isHighImportance.Checked = false;
                                        chkBox_isAllDay.Checked = false;
                                        found = true;
                                    }
                                }
                            }
                        }
                    }
                }

                // Add the event into the selected plan.
                if (!found)
                {
                    /*foreach (Plan plan in Global.arrLstPlans)*/
                    foreach (Plan plan in Global.arrLstPlans)
                    {
                        if (plan.GetTitle().Equals(selectedPlan))
                        {
                            Event userEventObj = new Event(txtBox_Title.Text, dateTimePicker_StartDate.Value, dateTimePicker_EndDate.Value, txtBox_Location.Text, txtBox_Description.Text);
                            userEventObj.isHighImportance = chkBox_isHighImportance.Checked;
                            userEventObj.isAllDay = chkBox_isAllDay.Checked;

                            plan.arrLstEventProp.Add(userEventObj);

                            MessageBox.Show("Event " + txtBox_Title.Text + " created successfully.");
                            comboBoxPlan.SelectedIndex = -1;
                            txtBox_Title.Text = "";
                            dateTimePicker_StartDate.Value = dateTimePicker_StartDate.MinDate;
                            dateTimePicker_EndDate.Value = dateTimePicker_EndDate.MinDate;
                            txtBox_Location.Text = "";
                            txtBox_Description.Text = "";
                            chkBox_isHighImportance.Checked = false;
                            chkBox_isAllDay.Checked = false;
                        }
                    }
                }

                errorFound = false;
            }
        }

        private void bt_close_Adding_Event_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
