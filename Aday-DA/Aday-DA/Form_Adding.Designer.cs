
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
            this.SuspendLayout();
            // 
            // txtBox_Title
            // 
            this.txtBox_Title.Location = new System.Drawing.Point(213, 27);
            this.txtBox_Title.Name = "txtBox_Title";
            this.txtBox_Title.Size = new System.Drawing.Size(125, 27);
            this.txtBox_Title.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(159, 30);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(38, 20);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Title";
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(213, 90);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_StartDate.TabIndex = 2;
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(213, 145);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_EndDate.TabIndex = 3;
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Location = new System.Drawing.Point(84, 90);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(113, 20);
            this.lbl_startDate.TabIndex = 4;
            this.lbl_startDate.Text = "Start Date Time";
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(90, 145);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(107, 20);
            this.lbl_endDate.TabIndex = 5;
            this.lbl_endDate.Text = "End Date Time";
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(134, 206);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(66, 20);
            this.lbl_Location.TabIndex = 6;
            this.lbl_Location.Text = "Location";
            this.lbl_Location.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox_Location
            // 
            this.txtBox_Location.Location = new System.Drawing.Point(213, 199);
            this.txtBox_Location.Name = "txtBox_Location";
            this.txtBox_Location.Size = new System.Drawing.Size(125, 27);
            this.txtBox_Location.TabIndex = 7;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(112, 254);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(85, 20);
            this.lbl_Description.TabIndex = 6;
            this.lbl_Description.Text = "Description";
            this.lbl_Description.Click += new System.EventHandler(this.lbl_Description_Click);
            // 
            // txtBox_Description
            // 
            this.txtBox_Description.Location = new System.Drawing.Point(213, 251);
            this.txtBox_Description.Name = "txtBox_Description";
            this.txtBox_Description.Size = new System.Drawing.Size(125, 27);
            this.txtBox_Description.TabIndex = 7;
            // 
            // chkBox_isHighImportance
            // 
            this.chkBox_isHighImportance.AutoSize = true;
            this.chkBox_isHighImportance.Location = new System.Drawing.Point(213, 303);
            this.chkBox_isHighImportance.Name = "chkBox_isHighImportance";
            this.chkBox_isHighImportance.Size = new System.Drawing.Size(143, 24);
            this.chkBox_isHighImportance.TabIndex = 8;
            this.chkBox_isHighImportance.Text = "High Importance";
            this.chkBox_isHighImportance.UseVisualStyleBackColor = true;
            // 
            // chkBox_isAllDay
            // 
            this.chkBox_isAllDay.AutoSize = true;
            this.chkBox_isAllDay.Location = new System.Drawing.Point(213, 348);
            this.chkBox_isAllDay.Name = "chkBox_isAllDay";
            this.chkBox_isAllDay.Size = new System.Drawing.Size(79, 24);
            this.chkBox_isAllDay.TabIndex = 9;
            this.chkBox_isAllDay.Text = "All Day";
            this.chkBox_isAllDay.UseVisualStyleBackColor = true;
            // 
            // Form_AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Adding";
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
    }
}