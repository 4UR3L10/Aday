
namespace Aday_DA
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_add_Plan = new System.Windows.Forms.Button();
            this.bt_delete_Plan_Event = new System.Windows.Forms.Button();
            this.bt_add_Event = new System.Windows.Forms.Button();
            this.bt_close_Plan_Event = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_add_Plan
            // 
            this.bt_add_Plan.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_add_Plan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_add_Plan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_add_Plan.Location = new System.Drawing.Point(1, 161);
            this.bt_add_Plan.Name = "bt_add_Plan";
            this.bt_add_Plan.Size = new System.Drawing.Size(239, 48);
            this.bt_add_Plan.TabIndex = 0;
            this.bt_add_Plan.Text = "Add Plan";
            this.bt_add_Plan.UseVisualStyleBackColor = false;
            this.bt_add_Plan.Click += new System.EventHandler(this.bt_add_Plan_Click);
            // 
            // bt_delete_Plan_Event
            // 
            this.bt_delete_Plan_Event.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_delete_Plan_Event.Enabled = false;
            this.bt_delete_Plan_Event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_delete_Plan_Event.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_delete_Plan_Event.Location = new System.Drawing.Point(589, 161);
            this.bt_delete_Plan_Event.Name = "bt_delete_Plan_Event";
            this.bt_delete_Plan_Event.Size = new System.Drawing.Size(239, 48);
            this.bt_delete_Plan_Event.TabIndex = 1;
            this.bt_delete_Plan_Event.Text = "Delete";
            this.bt_delete_Plan_Event.UseVisualStyleBackColor = false;
            // 
            // bt_add_Event
            // 
            this.bt_add_Event.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_add_Event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_add_Event.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_add_Event.Location = new System.Drawing.Point(283, 161);
            this.bt_add_Event.Name = "bt_add_Event";
            this.bt_add_Event.Size = new System.Drawing.Size(239, 48);
            this.bt_add_Event.TabIndex = 3;
            this.bt_add_Event.Text = "Add Event";
            this.bt_add_Event.UseVisualStyleBackColor = false;
            this.bt_add_Event.Click += new System.EventHandler(this.bt_add_Event_Click);
            // 
            // bt_close_Plan_Event
            // 
            this.bt_close_Plan_Event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.bt_close_Plan_Event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_close_Plan_Event.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_close_Plan_Event.Location = new System.Drawing.Point(283, 369);
            this.bt_close_Plan_Event.Name = "bt_close_Plan_Event";
            this.bt_close_Plan_Event.Size = new System.Drawing.Size(239, 48);
            this.bt_close_Plan_Event.TabIndex = 4;
            this.bt_close_Plan_Event.Text = "Close";
            this.bt_close_Plan_Event.UseVisualStyleBackColor = false;
            this.bt_close_Plan_Event.Click += new System.EventHandler(this.bt_close_Plan_Event_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 65);
            this.panel1.TabIndex = 6;
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
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_close_Plan_Event);
            this.Controls.Add(this.bt_add_Event);
            this.Controls.Add(this.bt_delete_Plan_Event);
            this.Controls.Add(this.bt_add_Plan);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_add_Plan;
        private System.Windows.Forms.Button bt_delete_Plan_Event;
        private System.Windows.Forms.Button bt_add_Event;
        private System.Windows.Forms.Button bt_close_Plan_Event;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHeader;
    }
}

