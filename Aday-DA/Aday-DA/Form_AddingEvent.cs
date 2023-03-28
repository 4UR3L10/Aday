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
            // Check for DropDown EMpty.
            if (comboBoxPlan.SelectedIndex == -1)
            {
                MessageBox.Show("You cannot save an event without selecting a plan to store it.");
            }
            else if (txtBox_Title.Text == "")
            {
                MessageBox.Show("You cannot create a event without providing a title.");
            }
            // Check for Date not selected.
            else if (dateTimePicker_StartDate.Value == dateTimePicker_StartDate.MinDate)
            {
                MessageBox.Show("You cannot create a event without selecting an Start Date Time.");
            }
            // Check for Date not selected.
            else if (dateTimePicker_EndDate.Value == dateTimePicker_EndDate.MinDate)
            {
                MessageBox.Show("You cannot create a event without selecting an End Date Time.");
            }
            else if (txtBox_Location.Text == "")
            {
                MessageBox.Show("You cannot create a event without providing a location.");
            }
            else if (txtBox_Description.Text == "")
            {
                MessageBox.Show("You cannot create a event without providing a description.");
            }    
            // Check if the event on the selected plan is already added.
            else if (Global.arrLstPlans.Count != 0)
            {
                foreach (Plan plan in Global.arrLstPlans)
                {
                    if (plan.GetTitle().Equals(comboBoxPlan.SelectedItem.ToString()))
                    {
                        foreach (Event evnt in plan.arrLstEvent)
                        {
                            if(evnt.GetTitle().Equals(txtBox_Title.Text))
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
                            }
                        }
                    }
                }
            }       
            // Add the event into the selected plan.
            else
            {
                foreach (Plan plan in Global.arrLstPlans)
                {
                    if (plan.GetTitle().Equals(comboBoxPlan.SelectedItem.ToString()))
                    {
                        Event userEventObj = new Event(txtBox_Title.Text, dateTimePicker_StartDate.Value, dateTimePicker_EndDate.Value, txtBox_Location.Text, txtBox_Description.Text);
                        userEventObj.isHighImportance = chkBox_isHighImportance.Checked;
                        userEventObj.isAllDay = chkBox_isAllDay.Checked;
                        plan.arrLstEvent.Add(userEventObj);

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

            /*
            String[] row = { txtBox_Title.Text, dateTimePicker_StartDate.Text, dateTimePicker_EndDate.Text, txtBox_Location.Text, txtBox_Description.Text, chkBox_isHighImportance.Checked.ToString(), chkBox_isAllDay.Checked.ToString() };
            Global.arrLstEvent.Add(row);
            */
        }

        private void bt_close_Adding_Event_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
