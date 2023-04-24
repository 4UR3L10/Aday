
namespace Aday_DA
{
    partial class Form_AddPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddPlan));
            this.bt_save_Plan = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txtBox_Title = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.bt_close_Add_Plan = new System.Windows.Forms.Button();
            this.dateTimePickerPlanDate = new System.Windows.Forms.DateTimePicker();
            this.labelPlan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_save_Plan
            // 
            this.bt_save_Plan.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_save_Plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save_Plan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_save_Plan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_save_Plan.Location = new System.Drawing.Point(94, 243);
            this.bt_save_Plan.Name = "bt_save_Plan";
            this.bt_save_Plan.Size = new System.Drawing.Size(239, 48);
            this.bt_save_Plan.TabIndex = 0;
            this.bt_save_Plan.Text = "Save Plan";
            this.bt_save_Plan.UseVisualStyleBackColor = false;
            this.bt_save_Plan.Click += new System.EventHandler(this.bt_save_Plan_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(33, 187);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(38, 20);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Title";
            // 
            // txtBox_Title
            // 
            this.txtBox_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtBox_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Title.Location = new System.Drawing.Point(87, 178);
            this.txtBox_Title.Name = "txtBox_Title";
            this.txtBox_Title.Size = new System.Drawing.Size(262, 29);
            this.txtBox_Title.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 65);
            this.panel1.TabIndex = 5;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelHeader.Location = new System.Drawing.Point(122, 10);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(193, 46);
            this.labelHeader.TabIndex = 5;
            this.labelHeader.Text = "ADD PLAN";
            // 
            // bt_close_Add_Plan
            // 
            this.bt_close_Add_Plan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.bt_close_Add_Plan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_close_Add_Plan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_close_Add_Plan.Location = new System.Drawing.Point(94, 326);
            this.bt_close_Add_Plan.Name = "bt_close_Add_Plan";
            this.bt_close_Add_Plan.Size = new System.Drawing.Size(239, 48);
            this.bt_close_Add_Plan.TabIndex = 6;
            this.bt_close_Add_Plan.Text = "Close";
            this.bt_close_Add_Plan.UseVisualStyleBackColor = false;
            this.bt_close_Add_Plan.Click += new System.EventHandler(this.bt_close_Plan_Event_Click);
            // 
            // dateTimePickerPlanDate
            // 
            this.dateTimePickerPlanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPlanDate.Location = new System.Drawing.Point(87, 115);
            this.dateTimePickerPlanDate.Name = "dateTimePickerPlanDate";
            this.dateTimePickerPlanDate.Size = new System.Drawing.Size(262, 27);
            this.dateTimePickerPlanDate.TabIndex = 7;
            // 
            // labelPlan
            // 
            this.labelPlan.AutoSize = true;
            this.labelPlan.Location = new System.Drawing.Point(33, 122);
            this.labelPlan.Name = "labelPlan";
            this.labelPlan.Size = new System.Drawing.Size(41, 20);
            this.labelPlan.TabIndex = 8;
            this.labelPlan.Text = "Date";
            // 
            // Form_AddPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 408);
            this.Controls.Add(this.labelPlan);
            this.Controls.Add(this.dateTimePickerPlanDate);
            this.Controls.Add(this.bt_close_Add_Plan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txtBox_Title);
            this.Controls.Add(this.bt_save_Plan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AddPlan";
            this.Text = "Add Plan";
            this.Load += new System.EventHandler(this.Form_AddPlan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_save_Plan;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txtBox_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button bt_close_Add_Plan;
        private System.Windows.Forms.DateTimePicker dateTimePickerPlanDate;
        private System.Windows.Forms.Label labelPlan;
    }
}