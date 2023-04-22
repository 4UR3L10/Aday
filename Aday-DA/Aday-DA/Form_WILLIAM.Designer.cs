
namespace Aday_DA
{
    partial class Form_WILLIAM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox_Location = new System.Windows.Forms.TextBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.bt_close_Adding_Event = new System.Windows.Forms.Button();
            this.bt_save_Event = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.chkBox_isAllDay = new System.Windows.Forms.CheckBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtBox_Location
            // 
            this.txtBox_Location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtBox_Location.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Location.Location = new System.Drawing.Point(170, 53);
            this.txtBox_Location.Name = "txtBox_Location";
            this.txtBox_Location.Size = new System.Drawing.Size(262, 29);
            this.txtBox_Location.TabIndex = 9;
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(77, 62);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(66, 20);
            this.lbl_Location.TabIndex = 8;
            this.lbl_Location.Text = "Location";
            // 
            // bt_close_Adding_Event
            // 
            this.bt_close_Adding_Event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.bt_close_Adding_Event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_close_Adding_Event.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_close_Adding_Event.Location = new System.Drawing.Point(335, 321);
            this.bt_close_Adding_Event.Name = "bt_close_Adding_Event";
            this.bt_close_Adding_Event.Size = new System.Drawing.Size(239, 48);
            this.bt_close_Adding_Event.TabIndex = 14;
            this.bt_close_Adding_Event.Text = "Close";
            this.bt_close_Adding_Event.UseVisualStyleBackColor = false;
            this.bt_close_Adding_Event.Click += new System.EventHandler(this.bt_close_Adding_Event_Click);
            // 
            // bt_save_Event
            // 
            this.bt_save_Event.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_save_Event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_save_Event.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_save_Event.Location = new System.Drawing.Point(21, 321);
            this.bt_save_Event.Name = "bt_save_Event";
            this.bt_save_Event.Size = new System.Drawing.Size(239, 48);
            this.bt_save_Event.TabIndex = 15;
            this.bt_save_Event.Text = "Save Event";
            this.bt_save_Event.UseVisualStyleBackColor = false;
            this.bt_save_Event.Click += new System.EventHandler(this.bt_save_Event_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Location";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(170, 177);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 17;
            this.dateTimePicker2.Value = new System.DateTime(2023, 4, 22, 15, 56, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // chkBox_isAllDay
            // 
            this.chkBox_isAllDay.AutoSize = true;
            this.chkBox_isAllDay.Location = new System.Drawing.Point(170, 257);
            this.chkBox_isAllDay.Name = "chkBox_isAllDay";
            this.chkBox_isAllDay.Size = new System.Drawing.Size(79, 24);
            this.chkBox_isAllDay.TabIndex = 18;
            this.chkBox_isAllDay.Text = "All Day";
            this.chkBox_isAllDay.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(1071, 47);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker3.TabIndex = 19;
            this.dateTimePicker3.Value = new System.DateTime(2023, 4, 22, 17, 20, 24, 0);
            // 
            // Form_WILLIAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 896);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.chkBox_isAllDay);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bt_save_Event);
            this.Controls.Add(this.bt_close_Adding_Event);
            this.Controls.Add(this.txtBox_Location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Location);
            this.Name = "Form_WILLIAM";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Location;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Button bt_close_Adding_Event;
        private System.Windows.Forms.Button bt_save_Event;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox chkBox_isAllDay;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}