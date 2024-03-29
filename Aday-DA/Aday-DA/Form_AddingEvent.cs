﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aday_DA.Classes;
using Microsoft.Toolkit.Uwp.Notifications;

namespace Aday_DA
{
    public partial class Form_AddEvent : Form
    {
        public Form_AddEvent()
        {
            InitializeComponent();

            //dateTimePicker_StartDate.MinDate = DateTime.Today;
            dateTimePicker_StartDate.Value = DateTime.Now;
            //dateTimePicker_EndDate.MinDate = DateTime.Today;
            dateTimePicker_EndDate.Value = DateTime.Now.AddSeconds(1);

            // Load all the Existing Plan Dates.
            foreach (String strdate in Global.GetOrderedPlanDates())
            {
                comboBoxDate.Items.Add(strdate);
            }
        }


        private void bt_save_Event_Click(object sender, EventArgs e)
        {
            bool found = false;
            bool errorFound = false;
            string selectedPlan = "";


            // Check for DropDown Empty.
            if (comboBoxDate.SelectedIndex == -1)
            {
                MessageBox.Show("You cannot save an event without selecting a date to select a plan.");
                errorFound = true;
            }
            else if(comboBoxPlan.SelectedIndex == -1)
            {
                MessageBox.Show("You cannot save an event without selecting a plan to store it.");
                errorFound = true;
            }
            else if (txtBox_Title.Text == "")
            {
                MessageBox.Show("You cannot create a event without providing a title.");
                errorFound = true;
            }
            // Start timee is less than End Time.
            else if (dateTimePicker_EndDate.Value < dateTimePicker_StartDate.Value)
            {
                MessageBox.Show("End time cannot be less than Start Time.");
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
                    selectedPlan = comboBoxPlan.SelectedItem.ToString();

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
                                        MessageBox.Show("You already have this event in this plan.");
                                        comboBoxPlan.SelectedIndex = -1;
                                        txtBox_Title.Text = "";
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
                    foreach (Plan plan in Global.arrLstPlans)
                    {
                        if (plan.GetTitle().Equals(selectedPlan))
                        {
                            DateTime startTime = new DateTime(plan.GetPlanDate().Year, plan.GetPlanDate().Month, plan.GetPlanDate().Day, dateTimePicker_StartDate.Value.Hour, dateTimePicker_StartDate.Value.Minute, dateTimePicker_StartDate.Value.Second, dateTimePicker_StartDate.Value.Millisecond);
                            DateTime endTime = new DateTime(plan.GetPlanDate().Year, plan.GetPlanDate().Month, plan.GetPlanDate().Day, dateTimePicker_EndDate.Value.Hour, dateTimePicker_EndDate.Value.Minute, dateTimePicker_EndDate.Value.Second, dateTimePicker_EndDate.Value.Millisecond);

                            Event userEventObj = new Event(txtBox_Title.Text, startTime, endTime, txtBox_Location.Text, txtBox_Description.Text);
                            userEventObj.isHighImportance = chkBox_isHighImportance.Checked;
                            userEventObj.isAllDay = chkBox_isAllDay.Checked;

                            plan.arrLstEventProp.Add(userEventObj);

                            MessageBox.Show("Event " + txtBox_Title.Text + " created successfully.");

                            // Reset.
                            comboBoxPlan.SelectedIndex = -1;
                            txtBox_Title.Text = "";
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


        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
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
                    if(plan.GetPlanDateYearFormatString().Equals(selectedDate))
                    {
                        comboBoxPlan.Items.Add(plan.GetTitle());                        
                    }                    
                }
            }            
        }

        private void chkBox_isAllDay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_isAllDay.Checked)
            {
                dateTimePicker_StartDate.Value = new DateTime(2023, 12, 01);
                dateTimePicker_StartDate.Enabled = false;
                dateTimePicker_EndDate.Value = new DateTime(2024, 12, 01);
                dateTimePicker_EndDate.Enabled = false;
            }
            else
            {
                dateTimePicker_StartDate.Enabled = true;
                dateTimePicker_EndDate.Enabled = true;
            }
        }
    }
}
