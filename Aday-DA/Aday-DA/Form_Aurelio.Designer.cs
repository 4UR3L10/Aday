
namespace Aday_DA
{
    partial class Form_Aurelio
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
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPlanDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(269, 212);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.ShowUpDown = true;
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(262, 27);
            this.dateTimePicker_StartDate.TabIndex = 3;
            // 
            // dateTimePickerPlanDate
            // 
            this.dateTimePickerPlanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPlanDate.Location = new System.Drawing.Point(269, 170);
            this.dateTimePickerPlanDate.Name = "dateTimePickerPlanDate";
            this.dateTimePickerPlanDate.Size = new System.Drawing.Size(262, 27);
            this.dateTimePickerPlanDate.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Aurelio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerPlanDate);
            this.Controls.Add(this.dateTimePicker_StartDate);
            this.Name = "Form_Aurelio";
            this.Text = "Form_Aurelio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_StartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPlanDate;
        private System.Windows.Forms.Button button1;
    }
}