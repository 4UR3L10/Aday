﻿
namespace Aday_DA
{
    partial class Form_William2
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
            this.lbl_Location = new System.Windows.Forms.Label();
            this.bt_save_Event = new System.Windows.Forms.Button();
            this.bt_close_Adding_Event = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(73, 56);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(66, 20);
            this.lbl_Location.TabIndex = 11;
            this.lbl_Location.Text = "Location";
            this.lbl_Location.Click += new System.EventHandler(this.lbl_Location_Click);
            // 
            // bt_save_Event
            // 
            this.bt_save_Event.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_save_Event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_save_Event.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_save_Event.Location = new System.Drawing.Point(84, 332);
            this.bt_save_Event.Name = "bt_save_Event";
            this.bt_save_Event.Size = new System.Drawing.Size(239, 48);
            this.bt_save_Event.TabIndex = 16;
            this.bt_save_Event.Text = "Save Event";
            this.bt_save_Event.UseVisualStyleBackColor = false;
            this.bt_save_Event.Click += new System.EventHandler(this.bt_save_Event_Click);
            // 
            // bt_close_Adding_Event
            // 
            this.bt_close_Adding_Event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.bt_close_Adding_Event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_close_Adding_Event.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_close_Adding_Event.Location = new System.Drawing.Point(537, 332);
            this.bt_close_Adding_Event.Name = "bt_close_Adding_Event";
            this.bt_close_Adding_Event.Size = new System.Drawing.Size(239, 48);
            this.bt_close_Adding_Event.TabIndex = 17;
            this.bt_close_Adding_Event.Text = "Close";
            this.bt_close_Adding_Event.UseVisualStyleBackColor = false;
            this.bt_close_Adding_Event.Click += new System.EventHandler(this.bt_close_Adding_Event_Click);
            // 
            // Form_William2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 726);
            this.Controls.Add(this.bt_close_Adding_Event);
            this.Controls.Add(this.bt_save_Event);
            this.Controls.Add(this.lbl_Location);
            this.Name = "Form_William2";
            this.Text = "Form_William2";
            this.Load += new System.EventHandler(this.Form_William2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Button bt_save_Event;
        private System.Windows.Forms.Button bt_close_Adding_Event;
    }
}