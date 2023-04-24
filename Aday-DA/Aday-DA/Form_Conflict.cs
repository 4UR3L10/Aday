using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aday_DA.Classes;

namespace Aday_DA.Classes
{
    public partial class Form_Conflict : Form
    {
        public Form_Conflict()
        {
            InitializeComponent();
            listViewEventConflicts.Columns.Add("Event", -2, HorizontalAlignment.Left);
            listViewEventConflicts.Columns.Add("Start Date", -2, HorizontalAlignment.Left);
            listViewEventConflicts.Columns.Add("End Date", -2, HorizontalAlignment.Left);
            listViewEventConflicts.Columns.Add("Location", -2, HorizontalAlignment.Center);
            listViewEventConflicts.Columns.Add("Description", -2, HorizontalAlignment.Center);
            listViewEventConflicts.Columns.Add("High Importance", -2, HorizontalAlignment.Center);
            listViewEventConflicts.Columns.Add("All Day", -2, HorizontalAlignment.Center);



            if (Global.arrLstEventConflict.Count > 0)
            {
                foreach (Event evnt in Global.arrLstEventConflict)
                {
                    ListViewItem item1 = new ListViewItem(evnt.GetTitle());
                    listViewEventConflicts.Items.Add(item1);
                    item1.SubItems.Add(evnt.GetStartDateTime().ToString());
                    item1.SubItems.Add(evnt.GetEndDateTime().ToString());
                    item1.SubItems.Add(evnt.GetLlocation());
                    item1.SubItems.Add(evnt.GetDescription());
                    item1.SubItems.Add(evnt.isHighImportance.ToString());
                    item1.SubItems.Add(evnt.isAllDay.ToString());
                }
            }

            bt_close_Main.Enabled = false;
        }

        private void bt_close_Main_Click(object sender, EventArgs e)
        {
            Global.arrLstEventConflict.Clear();
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewEventConflicts.Items)
            {
                if (item.Selected)
                {
                    listViewEventConflicts.Items.RemoveAt(item.Index);


         

                        for (int index = Global.arrLstPlans.Count; index >= 0; index--)
                        {
                            if (index >= Global.arrLstPlans.Count)
                            {
                                // Out of bound
                            }
                            else
                            {
                                if (Global.arrLstPlans[index].GetPlanDate().Date.ToString().Equals(DateTime.Now.Date.ToString()))
                                {
                                    if (Global.arrLstPlans[index].arrLstEventProp.Count > 0)
                                    {

                                        for (int indexJ = Global.arrLstPlans[index].arrLstEventProp.Count; indexJ >= 0; indexJ--)
                                        {
                                            if (indexJ >= Global.arrLstPlans[index].arrLstEventProp.Count)
                                            {
                                                // Out of bound
                                            }
                                            else
                                            {
                                                Console.WriteLine("item.Text = {0}", item.Text);

                                                if (Global.arrLstPlans[index].arrLstEventProp[indexJ].GetTitle().Equals(item.Text))
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

            if(listViewEventConflicts.Items.Count <= 1)
            {
                bt_close_Main.Enabled = true;
                Global.arrLstEventConflict.Clear();
            }
        }
    }
}
