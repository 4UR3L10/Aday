using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aday_DA.Classes;
using Microsoft.Toolkit.Uwp.Notifications;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace Aday_DA
{
    public partial class Form_WILLIAM : Form
    {
        public Form_WILLIAM()
        {
            InitializeComponent();
        }

        private void bt_save_Event_Click(object sender, EventArgs e)
        {/*
            string text = txtBox_Location.Text;
            // Set the file path where you want to save the text file
            string filePath = @"D:\example.txt";


            // This text is added only once to the file.
            if (!File.Exists(filePath))
            {
                // Create a file to write to.
                string createText = text + Environment.NewLine;
                File.WriteAllText(filePath, createText);
            }
            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = text + Environment.NewLine;
            File.AppendAllText(filePath, appendText);


            //Console.WriteLine("KKK TALKOOOOO");
            // Open the file to read from.
            string readText = File.ReadAllText(filePath);
            MessageBox.Show(readText);
            //Console.WriteLine(readText);

            // Write the contents of the textbox to the text file
            //System.IO.File.WriteAllText(filePath, text);
            // Process.Start("explorer.exe", "-p");

            //Process process = new Process();
            // Configure the process using the StartInfo properties.
            //process.StartInfo.FileName = "process.exe";
            //process.StartInfo.Arguments = "-n";
            //process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            //process.StartInfo.UseShellExecute = true;
            //process.Start();
            //process.WaitForExit();// Waits here for the process to exit.
        */
            dateTimePicker2.MinDate = DateTime.Today;
            if (chkBox_isAllDay.Checked)
            {
                dateTimePicker1.Value = new DateTime(2023,12, 01);
                dateTimePicker2.Value = new DateTime(2024,12, 01);
            }



            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("The value of end time can not be less than start time");
                
                

            }
            else
            {
                Form_William2 form2 = new Form_William2(this);
                form2.Show();
                this.Enabled = false;
                form2.FormClosed += (s, args) => this.Enabled = true;
            }
            
        }

        private void bt_close_Adding_Event_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /*
            if(dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("The value of end time can not be less than start time");
                
                dateTimePicker2.Value = dateTimePicker1.Value;

            }
            /*
            if (dateTimepicker2.Value < datetimepickersStart.Value)
            {
                datetimepickersEnd.Value = datetimepickersStart.Value;
            }
            */
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
