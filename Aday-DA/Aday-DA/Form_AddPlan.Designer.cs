
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
            this.bt_save_Plan = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txtBox_Title = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.bt_close_Plan_Event = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_save_Plan
            // 
            this.bt_save_Plan.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_save_Plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save_Plan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_save_Plan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_save_Plan.Location = new System.Drawing.Point(34, 355);
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
            this.lbl_Title.Location = new System.Drawing.Point(34, 125);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(38, 20);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Title";
            // 
            // txtBox_Title
            // 
            this.txtBox_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtBox_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Title.Location = new System.Drawing.Point(88, 122);
            this.txtBox_Title.Name = "txtBox_Title";
            this.txtBox_Title.Size = new System.Drawing.Size(262, 22);
            this.txtBox_Title.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 5;
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
            // bt_close_Plan_Event
            // 
            this.bt_close_Plan_Event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.bt_close_Plan_Event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_close_Plan_Event.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_close_Plan_Event.Location = new System.Drawing.Point(501, 355);
            this.bt_close_Plan_Event.Name = "bt_close_Plan_Event";
            this.bt_close_Plan_Event.Size = new System.Drawing.Size(239, 48);
            this.bt_close_Plan_Event.TabIndex = 6;
            this.bt_close_Plan_Event.Text = "Close";
            this.bt_close_Plan_Event.UseVisualStyleBackColor = false;
            this.bt_close_Plan_Event.Click += new System.EventHandler(this.bt_close_Plan_Event_Click);
            // 
            // Form_AddPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_close_Plan_Event);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txtBox_Title);
            this.Controls.Add(this.bt_save_Plan);
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
        private System.Windows.Forms.Button bt_close_Plan_Event;
    }
}