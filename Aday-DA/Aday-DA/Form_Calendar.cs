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
    public partial class Form_Calendar : Form
    {
        public Form_Calendar()
        {
            InitializeComponent();
            foreach (string[] row in Global.arrLstPlan)
            {                
                foreach (string element in row)
                {
                   //MessageBox.Show(element);
                }
            }

            // Create a new ListView control.
            ListView listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(39, 26), new Size(776, 121));
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
            ListViewItem item1 = new ListViewItem(Global.arrLstPlan[0]);

            listView1.Items.Add(item1);

            //add columns
            listView1.Columns.Add("Title", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Start Date", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("End Date", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Location", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Description", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("High Importance", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("All Day", -2, HorizontalAlignment.Center);


            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
            //MessageBox.Show("Test");
        }
    }
}
