
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
            this.SuspendLayout();
            // 
            // bt_add_Plan
            // 
            this.bt_add_Plan.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_add_Plan.Location = new System.Drawing.Point(21, 53);
            this.bt_add_Plan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_add_Plan.Name = "bt_add_Plan";
            this.bt_add_Plan.Size = new System.Drawing.Size(154, 64);
            this.bt_add_Plan.TabIndex = 0;
            this.bt_add_Plan.Text = "Add Plan";
            this.bt_add_Plan.UseVisualStyleBackColor = true;
            this.bt_add_Plan.Click += new System.EventHandler(this.bt_add_Plan_Click);
            // 
            // bt_delete_Plan_Event
            // 
            this.bt_delete_Plan_Event.Enabled = false;
            this.bt_delete_Plan_Event.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_delete_Plan_Event.Location = new System.Drawing.Point(427, 53);
            this.bt_delete_Plan_Event.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_delete_Plan_Event.Name = "bt_delete_Plan_Event";
            this.bt_delete_Plan_Event.Size = new System.Drawing.Size(132, 64);
            this.bt_delete_Plan_Event.TabIndex = 1;
            this.bt_delete_Plan_Event.Text = "Delete";
            this.bt_delete_Plan_Event.UseVisualStyleBackColor = true;
            // 
            // bt_add_Event
            // 
            this.bt_add_Event.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_add_Event.Location = new System.Drawing.Point(211, 53);
            this.bt_add_Event.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_add_Event.Name = "bt_add_Event";
            this.bt_add_Event.Size = new System.Drawing.Size(166, 64);
            this.bt_add_Event.TabIndex = 3;
            this.bt_add_Event.Text = "Add Event";
            this.bt_add_Event.UseVisualStyleBackColor = true;
            this.bt_add_Event.Click += new System.EventHandler(this.bt_add_Event_Click);
            // 
            // bt_close_Plan_Event
            // 
            this.bt_close_Plan_Event.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_close_Plan_Event.Location = new System.Drawing.Point(211, 193);
            this.bt_close_Plan_Event.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_close_Plan_Event.Name = "bt_close_Plan_Event";
            this.bt_close_Plan_Event.Size = new System.Drawing.Size(142, 41);
            this.bt_close_Plan_Event.TabIndex = 4;
            this.bt_close_Plan_Event.Text = "Close";
            this.bt_close_Plan_Event.UseVisualStyleBackColor = true;
            this.bt_close_Plan_Event.Click += new System.EventHandler(this.bt_close_Plan_Event_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 376);
            this.Controls.Add(this.bt_close_Plan_Event);
            this.Controls.Add(this.bt_add_Event);
            this.Controls.Add(this.bt_delete_Plan_Event);
            this.Controls.Add(this.bt_add_Plan);
            this.Name = "Form_Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_add_Plan;
        private System.Windows.Forms.Button bt_delete_Plan_Event;
        private System.Windows.Forms.Button bt_add_Event;
        private System.Windows.Forms.Button bt_close_Plan_Event;
    }
}

