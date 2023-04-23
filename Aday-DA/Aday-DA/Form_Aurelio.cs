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
    }
}
