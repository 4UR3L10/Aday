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
            DateTime startDt = dateTimePicker_StartDate.Value;
            DateTime endDt = dateTimePicker_EndDate.Value;
            DateTime nowDt = DateTime.Now;


            if (startDt <= nowDt && nowDt <= endDt)
            {
                MessageBox.Show("Start Time is ***between*** than current time");
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Conflict conflict = new Form_Conflict();
            conflict.Show();
            this.Enabled = false;
            conflict.FormClosed += (s, args) => this.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //string imageFilePath = "C:\\Users\\Aurelio\\Documents\\GitHub\\Aday\\Aday-DA\\Aday-DA\\Resources\\Aday.ico";
            //Uri img = new Uri(imageFilePath);

            string dirName = AppDomain.CurrentDomain.BaseDirectory; // Starting Dir
            FileInfo fileInfo = new FileInfo(dirName);
            DirectoryInfo parentDir = fileInfo.Directory.Parent;
            string parentDirName = parentDir.FullName; // Parent of Starting Dir
            string dirName2 = parentDirName;
            FileInfo fileInfo2 = new FileInfo(dirName2);
            DirectoryInfo parentDir2 = fileInfo2.Directory.Parent;
            string parentDirName2 = parentDir2.FullName;
            string path = parentDirName2 + @"\Resources\Aday.ico";

            new ToastContentBuilder()
            .AddArgument("action", "viewConversation")
            .AddArgument("conversationId", 9813)            
            .AddText("Event Started")
            .AddText("The following event: for today " + DateTime.Now.ToString() + " on plan  just started.")

            .AddAppLogoOverride(new Uri("file:///" + path, UriKind.Absolute), ToastGenericAppLogoCrop.Circle)


            .AddInputTextBox("tbReply", placeHolderContent: "Type a response")
            .AddButton(new ToastButton()
            .SetContent("Dismiss")
            .AddArgument("action", "like")
            .SetBackgroundActivation())
            .Show();
        }
    }
}
