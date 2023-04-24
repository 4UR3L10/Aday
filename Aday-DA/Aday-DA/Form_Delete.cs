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
            bool errorFound = false;

            if (comboBoxDate.SelectedIndex == -1)
            {
                MessageBox.Show("You need to add a plan to delete one");
                errorFound = true;
            }
            else if (comboBoxPlan.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select a plan to delete one");
                errorFound = true;
            }
            else if (comboBoxEvent.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select an event to delete one");
                errorFound = true;
            }

            if (!errorFound)
            {
                // Delete All Events and Plans on the specific Date. Plan:[ALL] Event [All].
                if (comboBoxPlan.SelectedItem.ToString().Equals("All") && comboBoxEvent.SelectedItem.ToString().Equals("All"))
                {
                    MessageBox.Show("Delete All Events and Plans on the specific Date was successfull.");
                    if (Global.arrLstPlans.Count > 0)
                    {
                        string selectedDate = "";

                        if (comboBoxDate.SelectedIndex != -1)
                        {
                            selectedDate = comboBoxDate.SelectedItem.ToString();


                            for (int index = Global.arrLstPlans.Count; index >= 0; index--)
                            {
                                if (index >= Global.arrLstPlans.Count)
                                {
                                    // Out of bound
                                }
                                else
                                {
                                    if (Global.arrLstPlans[index].GetPlanDateYearFormatString().Equals(selectedDate))
                                    {
                                        Global.arrLstPlans.RemoveAt(index);
                                    }
                                }

                            }
                        }
                    }

                    this.Close();
                }
                // Delete All Events and Plans on the specific Date. Plan:[ALL] Event [Any].
                else if (comboBoxPlan.SelectedItem.ToString().Equals("All") && !comboBoxEvent.SelectedItem.ToString().Equals("All"))
                {
                    MessageBox.Show("Delete All Events and Plans on the specific Date was successfull.");

                    if (Global.arrLstPlans.Count > 0)
                    {
                        string selectedDate = "";

                        if (comboBoxDate.SelectedIndex != -1)
                        {
                            selectedDate = comboBoxDate.SelectedItem.ToString();


                            for (int index = Global.arrLstPlans.Count; index >= 0; index--)
                            {
                                if (index >= Global.arrLstPlans.Count)
                                {
                                    // Out of bound
                                }
                                else
                                {
                                    if (Global.arrLstPlans[index].GetPlanDateYearFormatString().Equals(selectedDate))
                                    {
                                        Global.arrLstPlans.RemoveAt(index);
                                    }
                                }

                            }
                        }
                    }

                    this.Close();
                }
                // Delete All Events and the selected Plan on the specific Date. Plan:[Any] Event [All].
                else if (!comboBoxPlan.SelectedItem.ToString().Equals("All") && comboBoxEvent.SelectedItem.ToString().Equals("All"))
                {
                    MessageBox.Show("Delete All Events and the selected Plan on the specific Date was successfull.");

                    if (Global.arrLstPlans.Count > 0)
                    {
                        string selectedDate = "";
                        string selectedPlan = "";

                        if (comboBoxDate.SelectedIndex != -1)
                        {
                            selectedDate = comboBoxDate.SelectedItem.ToString();
                            selectedPlan = comboBoxPlan.SelectedItem.ToString();

                            for (int index = Global.arrLstPlans.Count; index >= 0; index--)
                            {
                                if (index >= Global.arrLstPlans.Count)
                                {
                                    // Out of bound
                                }
                                else
                                {
                                    if (Global.arrLstPlans[index].GetPlanDateYearFormatString().Equals(selectedDate))
                                    {
                                        if (Global.arrLstPlans[index].GetTitle().Equals(selectedPlan))
                                        {
                                            Global.arrLstPlans.RemoveAt(index);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    this.Close();
                }
                // Delete the selected Event for the selected Plan on the specific Date. Plan:[Any] Event [Any].
                else if (!comboBoxPlan.SelectedItem.ToString().Equals("All") && !comboBoxEvent.SelectedItem.ToString().Equals("All"))
                {
                    MessageBox.Show("Delete the selected Event for the selected Plan on the specific Date was successfull.");

                    if (Global.arrLstPlans.Count > 0)
                    {
                        string selectedDate = "";
                        string selectedPlan = "";
                        string selectedEvent = "";

                        if (comboBoxDate.SelectedIndex != -1)
                        {
                            selectedDate = comboBoxDate.SelectedItem.ToString();

                            for (int index = Global.arrLstPlans.Count; index >= 0; index--)
                            {
                                if (index >= Global.arrLstPlans.Count)
                                {
                                    // Out of bound
                                }
                                else
                                {
                                    if (Global.arrLstPlans[index].GetPlanDateYearFormatString().Equals(selectedDate))
                                    {
                                        selectedPlan = comboBoxPlan.SelectedItem.ToString();

                                        if (Global.arrLstPlans[index].GetTitle().Equals(selectedPlan))
                                        {
                                            if (Global.arrLstPlans[index].arrLstEventProp.Count > 0)
                                            {
                                                selectedEvent = comboBoxEvent.SelectedItem.ToString();

                                                for (int indexJ = Global.arrLstPlans[index].arrLstEventProp.Count; indexJ >= 0; indexJ--)
                                                {
                                                    if (indexJ >= Global.arrLstPlans[index].arrLstEventProp.Count)
                                                    {
                                                        // Out of bound
                                                    }
                                                    else
                                                    {
                                                        if (Global.arrLstPlans[index].arrLstEventProp[indexJ].GetTitle().Equals(selectedEvent))
                                                        {
                                                            Global.arrLstPlans[index].arrLstEventProp.RemoveAt(indexJ);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    this.Close();
                }
            }
        }
    }
}
