using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Aday_DA.Classes;
using Microsoft.Toolkit.Uwp.Notifications;

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
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                {
                    listView1.Items.RemoveAt(item.Index);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open the text file and write the data to it
            using (StreamWriter writer = new StreamWriter("dddataaa.txt", false))
            {
                // If plans exists.
                if (Global.arrLstPlans.Count > 0)
                {
                    foreach (Plan plan in Global.arrLstPlans)
                    {
                        writer.WriteLine("@P@" + plan.GetTitle() + "&&&" + plan.GetPlanDate());

                        if (plan.arrLstEventProp.Count > 0)
                        {
                            foreach (Event evnt in plan.arrLstEventProp)
                            {
                                writer.WriteLine("@E@" + evnt.GetTitle() + "&&&" + evnt.GetStartDateTime() + "&&&" + evnt.GetEndDateTime() + "&&&" + evnt.GetLlocation() + "&&&" + evnt.GetDescription() + "&&&" + evnt.isHighImportance + "&&&" + evnt.isAllDay);
                            }
                        }
                    }
                }
            }
        }      

        private void button3_Click(object sender, EventArgs e)
        {
            // Open the text file using a StreamReader
            using (StreamReader reader = new StreamReader("dddataaa.txt"))
            {
                // Read the contents of the text file line by line
                string line;
                DateTime varDateTime;
                DateTime startDateTime;
                DateTime endDateTime;
                bool isHighImportance;
                bool isAllDay;

                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line into components based on the space character
                    string[] components = line.Split("&&&");

                    // Reading a plan.
                    if (components[0].Contains("@P@"))
                    {
                        components[0] = components[0].Replace("@P@", "");

                        // Parse the second component of the line as a DateTime and call the GetStartDateTime method of the evnt class.        
                        if (DateTime.TryParse(components[1], out varDateTime))
                        {
                            /*Create a new plan - CHANGE THE PARAMETERS TO THE ONES YOU ARE READING FROM THE FILE*/
                            Plan planobj = new Plan(components[0], varDateTime);

                            /*Add a plan to the list of plans. */
                            Global.arrLstPlans.Add(planobj);
                        }
                    }

                    // Reading a Event.
                    if (components[0].Contains("@E@"))
                    {
                        components[0] = components[0].Replace("@E@", ""); // Event Title.
                        if (DateTime.TryParse(components[1], out startDateTime))
                        {
                            if (DateTime.TryParse(components[2], out endDateTime))
                            {
                                isHighImportance = Convert.ToBoolean(components[5]);
                                isAllDay = Convert.ToBoolean(components[6]);

                                Event userEventObj = new Event(components[0], startDateTime, endDateTime, components[3], components[4]);
                                userEventObj.isHighImportance = isHighImportance;
                                userEventObj.isAllDay = isAllDay;                        
                                Global.arrLstPlans[Global.arrLstPlans.Count - 1].arrLstEventProp.Add(userEventObj);
                            }
                        }                            
                    }                
                }
            }
        }
    }
}
