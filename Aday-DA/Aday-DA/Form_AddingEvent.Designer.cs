
namespace Aday_DA
{
    partial class Form_AddEvent
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
            this.txtBox_Title = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.txtBox_Location = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txtBox_Description = new System.Windows.Forms.TextBox();
            this.chkBox_isHighImportance = new System.Windows.Forms.CheckBox();
            this.chkBox_isAllDay = new System.Windows.Forms.CheckBox();
            this.bt_save_Event = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_Title
            // 
            this.txtBox_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtBox_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Title.Location = new System.Drawing.Point(188, 124);
            this.txtBox_Title.Name = "txtBox_Title";
            this.txtBox_Title.Size = new System.Drawing.Size(262, 22);
            this.txtBox_Title.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(134, 127);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(38, 20);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Title";
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(188, 187);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_StartDate.TabIndex = 2;
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(188, 242);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_EndDate.TabIndex = 3;
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Location = new System.Drawing.Point(59, 187);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(113, 20);
            this.lbl_startDate.TabIndex = 4;
            this.lbl_startDate.Text = "Start Date Time";
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(65, 242);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(107, 20);
            this.lbl_endDate.TabIndex = 5;
            this.lbl_endDate.Text = "End Date Time";
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(109, 303);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(66, 20);
            this.lbl_Location.TabIndex = 6;
            this.lbl_Location.Text = "Location";
            this.lbl_Location.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox_Location
            // 
            this.txtBox_Location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtBox_Location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Location.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Location.Location = new System.Drawing.Point(188, 296);
            this.txtBox_Location.Name = "txtBox_Location";
            this.txtBox_Location.Size = new System.Drawing.Size(262, 22);
            this.txtBox_Location.TabIndex = 7;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(87, 351);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(85, 20);
            this.lbl_Description.TabIndex = 6;
            this.lbl_Description.Text = "Description";
            this.lbl_Description.Click += new System.EventHandler(this.lbl_Description_Click);
            // 
            // txtBox_Description
            // 
            this.txtBox_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Description.Location = new System.Drawing.Point(188, 348);
            this.txtBox_Description.Name = "txtBox_Description";
            this.txtBox_Description.Size = new System.Drawing.Size(262, 22);
            this.txtBox_Description.TabIndex = 7;
            // 
            // chkBox_isHighImportance
            // 
            this.chkBox_isHighImportance.AutoSize = true;
            this.chkBox_isHighImportance.Location = new System.Drawing.Point(188, 400);
            this.chkBox_isHighImportance.Name = "chkBox_isHighImportance";
            this.chkBox_isHighImportance.Size = new System.Drawing.Size(143, 24);
            this.chkBox_isHighImportance.TabIndex = 8;
            this.chkBox_isHighImportance.Text = "High Importance";
            this.chkBox_isHighImportance.UseVisualStyleBackColor = true;
            // 
            // chkBox_isAllDay
            // 
            this.chkBox_isAllDay.AutoSize = true;
            this.chkBox_isAllDay.Location = new System.Drawing.Point(188, 445);
            this.chkBox_isAllDay.Name = "chkBox_isAllDay";
            this.chkBox_isAllDay.Size = new System.Drawing.Size(79, 24);
            this.chkBox_isAllDay.TabIndex = 9;
            this.chkBox_isAllDay.Text = "All Day";
            this.chkBox_isAllDay.UseVisualStyleBackColor = true;
            // 
            // bt_save_Event
            // 
            this.bt_save_Event.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_save_Event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_save_Event.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_save_Event.Location = new System.Drawing.Point(188, 493);
            this.bt_save_Event.Name = "bt_save_Event";
            this.bt_save_Event.Size = new System.Drawing.Size(239, 48);
            this.bt_save_Event.TabIndex = 10;
            this.bt_save_Event.Text = "Save Event";
            this.bt_save_Event.UseVisualStyleBackColor = false;
            this.bt_save_Event.Click += new System.EventHandler(this.bt_save_Event_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 65);
            this.panel1.TabIndex = 12;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelHeader.Location = new System.Drawing.Point(266, 10);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(151, 46);
            this.labelHeader.TabIndex = 5;
            this.labelHeader.Text = "ADAY.....";
            // 
            // Form_AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_save_Event);
            this.Controls.Add(this.chkBox_isAllDay);
            this.Controls.Add(this.chkBox_isHighImportance);
            this.Controls.Add(this.txtBox_Description);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.txtBox_Location);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.lbl_endDate);
            this.Controls.Add(this.lbl_startDate);
            this.Controls.Add(this.dateTimePicker_EndDate);
            this.Controls.Add(this.dateTimePicker_StartDate);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txtBox_Title);
            this.Name = "Form_AddEvent";
            this.Text = "Adding Event(s)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndDate;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.TextBox txtBox_Location;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txtBox_Description;
        private System.Windows.Forms.CheckBox chkBox_isHighImportance;
        private System.Windows.Forms.CheckBox chkBox_isAllDay;
        private System.Windows.Forms.Button bt_save_Event;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHeader;
    }
}