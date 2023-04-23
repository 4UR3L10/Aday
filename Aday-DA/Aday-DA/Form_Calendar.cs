using System;
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
    public partial class Form_Calendar : Form
    {
        public Form_Calendar()
        {
            InitializeComponent();

            // Create a new Timer control
            timerGlobal = new Timer();
            timerGlobal.Interval = 1000; // Change it to minutesssssssssssssssssssssssssssssssssssssssssssssss.
            timerGlobal.Tick += new EventHandler(timerGlobal_Tick);
            timerGlobal.Start();

            // Load all the Existing Plan Dates.
            foreach (String strdate in Global.GetOrderedPlanDates())
            {
                comboBoxDate.Items.Add(strdate);
            }
        }

        private void bt_close_Calendar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerGlobal_Tick(object sender, EventArgs e)
        {
            // CHeck Every Second for an event begin time notification.
            if (Global.arrLstPlans.Count > 0)
            {
                foreach (Plan plan in Global.arrLstPlans)
                {
                    if (plan.arrLstEventProp.Count > 0)
                    {
                        foreach (Event evnt in plan.arrLstEventProp)
                        {
                            if (evnt.GetStartDateTime().ToString() == DateTime.Now.ToString())
                            {
                                //MessageBox.Show("The following event:" + evnt.GetTitle() + " on plan " + plan.GetTitle() + " just started.");

                                new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText("Event Started")
                                .AddText("The following event:" + evnt.GetTitle() + " on plan " + plan.GetTitle() + " just started.")
                .               Show();
                            }
                        }
                    }
                }
            }
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDate = "";
            int plansInDay = 0;

            flowLayoutPanelPlans.Controls.Clear();

            if (comboBoxDate.SelectedIndex != -1)
            {
                selectedDate = comboBoxDate.SelectedItem.ToString();
                plansInDay = Global.GetPlanByDate(selectedDate);

                // Plans-Events
                if (plansInDay > 0)
                {
                    if (plansInDay > 3)
                    {
                        flowLayoutPanelPlans.AutoScroll = true;
                    }

                    foreach (Plan plan in Global.arrLstPlans)
                    {
                        if(plan.GetPlanDateYearFormatString().Equals(selectedDate))
                        {
                            // Create a new ListView control.
                            ListView listView1 = new ListView();

                            listView1.Bounds = new Rectangle(new Point(36, 26), new Size(737, 150));
                            // Set the view to show details.
                            listView1.View = View.Details;
                            // Allow the user to edit item text.
                            listView1.LabelEdit = true;
                            // Allow the user to rearrange columns.
                            listView1.AllowColumnReorder = true;
                            // Display check boxes.
                            listView1.CheckBoxes = true;
                            // Select the item and subitems when selection is made.
                            listView1.FullRowSelect = true;
                            // Display grid lines.
                            listView1.GridLines = true;
                            // Sort the items in the list in ascending order.
                            listView1.Sorting = SortOrder.Ascending;
                            // Create three items and three sets of subitems for each item.

                            //add columns
                            listView1.Columns.Add("Plan", -2, HorizontalAlignment.Left);
                            listView1.Columns.Add("Title", -2, HorizontalAlignment.Left);
                            listView1.Columns.Add("Start Date", -2, HorizontalAlignment.Left);
                            listView1.Columns.Add("End Date", -2, HorizontalAlignment.Left);
                            listView1.Columns.Add("Location", -2, HorizontalAlignment.Center);
                            listView1.Columns.Add("Description", -2, HorizontalAlignment.Center);
                            listView1.Columns.Add("High Importance", -2, HorizontalAlignment.Center);
                            listView1.Columns.Add("All Day", -2, HorizontalAlignment.Center);

                            if (plan.arrLstEventProp.Count > 0)
                            {
                                foreach (Event evnt in plan.arrLstEventProp)
                                {
                                    ListViewItem item1 = new ListViewItem(plan.GetTitle());
                                    listView1.Items.Add(item1);
                                    item1.SubItems.Add(evnt.GetTitle());
                                    item1.SubItems.Add(evnt.GetStartDateTime().ToString());
                                    item1.SubItems.Add(evnt.GetEndDateTime().ToString());
                                    item1.SubItems.Add(evnt.GetLlocation());
                                    item1.SubItems.Add(evnt.GetDescription());
                                    item1.SubItems.Add(evnt.isHighImportance.ToString());
                                    item1.SubItems.Add(evnt.isAllDay.ToString());
                                }
                            }
                            else
                            {
                                ListViewItem item1 = new ListViewItem(plan.GetTitle());
                                listView1.Items.Add(item1);
                            }

                            // Add the ListView to the control collection.
                            flowLayoutPanelPlans.Controls.Add(listView1);
                        }
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //ListViewItem item1 = new ListViewItem();
            //item1.Selected

        }
    }
}
