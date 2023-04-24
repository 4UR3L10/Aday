
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.bt_add_Plan = new System.Windows.Forms.Button();
            this.bt_add_Event = new System.Windows.Forms.Button();
            this.bt_close_Main = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonViewCalendar = new System.Windows.Forms.Button();
            this.timerGlobal = new System.Windows.Forms.Timer(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_add_Plan
            // 
            this.bt_add_Plan.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_add_Plan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_add_Plan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_add_Plan.Location = new System.Drawing.Point(26, 152);
            this.bt_add_Plan.Name = "bt_add_Plan";
            this.bt_add_Plan.Size = new System.Drawing.Size(239, 48);
            this.bt_add_Plan.TabIndex = 0;
            this.bt_add_Plan.Text = "Add Plan";
            this.bt_add_Plan.UseVisualStyleBackColor = false;
            this.bt_add_Plan.Click += new System.EventHandler(this.bt_add_Plan_Click);
            // 
            // bt_add_Event
            // 
            this.bt_add_Event.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_add_Event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_add_Event.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_add_Event.Location = new System.Drawing.Point(322, 152);
            this.bt_add_Event.Name = "bt_add_Event";
            this.bt_add_Event.Size = new System.Drawing.Size(239, 48);
            this.bt_add_Event.TabIndex = 3;
            this.bt_add_Event.Text = "Add Event";
            this.bt_add_Event.UseVisualStyleBackColor = false;
            this.bt_add_Event.Click += new System.EventHandler(this.bt_add_Event_Click);
            // 
            // bt_close_Main
            // 
            this.bt_close_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.bt_close_Main.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_close_Main.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_close_Main.Location = new System.Drawing.Point(496, 261);
            this.bt_close_Main.Name = "bt_close_Main";
            this.bt_close_Main.Size = new System.Drawing.Size(239, 48);
            this.bt_close_Main.TabIndex = 4;
            this.bt_close_Main.Text = "Close";
            this.bt_close_Main.UseVisualStyleBackColor = false;
            this.bt_close_Main.Click += new System.EventHandler(this.bt_close_Plan_Event_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 65);
            this.panel1.TabIndex = 6;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelHeader.Location = new System.Drawing.Point(334, 6);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(214, 46);
            this.labelHeader.TabIndex = 5;
            this.labelHeader.Text = "ADAY MAIN";
            // 
            // buttonViewCalendar
            // 
            this.buttonViewCalendar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonViewCalendar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonViewCalendar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonViewCalendar.Location = new System.Drawing.Point(629, 152);
            this.buttonViewCalendar.Name = "buttonViewCalendar";
            this.buttonViewCalendar.Size = new System.Drawing.Size(239, 48);
            this.buttonViewCalendar.TabIndex = 7;
            this.buttonViewCalendar.Text = "View Calendar";
            this.buttonViewCalendar.UseVisualStyleBackColor = false;
            this.buttonViewCalendar.Click += new System.EventHandler(this.buttonViewCalendar_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(150, 261);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(239, 48);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 338);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonViewCalendar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_close_Main);
            this.Controls.Add(this.bt_add_Event);
            this.Controls.Add(this.bt_add_Plan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_add_Plan;
        private System.Windows.Forms.Button bt_add_Event;
        private System.Windows.Forms.Button bt_close_Main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonViewCalendar;
        private System.Windows.Forms.Timer timerGlobal;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Timer timer1;
    }
}

