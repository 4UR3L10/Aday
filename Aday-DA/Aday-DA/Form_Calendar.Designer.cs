
namespace Aday_DA
{
    partial class Form_Calendar
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanelPlans = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_close_Calendar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.timerGlobal = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPlans
            // 
            this.flowLayoutPanelPlans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPlans.Location = new System.Drawing.Point(21, 83);
            this.flowLayoutPanelPlans.Name = "flowLayoutPanelPlans";
            this.flowLayoutPanelPlans.Size = new System.Drawing.Size(776, 753);
            this.flowLayoutPanelPlans.TabIndex = 1;
            // 
            // bt_close_Calendar
            // 
            this.bt_close_Calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.bt_close_Calendar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_close_Calendar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_close_Calendar.Location = new System.Drawing.Point(268, 925);
            this.bt_close_Calendar.Name = "bt_close_Calendar";
            this.bt_close_Calendar.Size = new System.Drawing.Size(239, 48);
            this.bt_close_Calendar.TabIndex = 5;
            this.bt_close_Calendar.Text = "Close";
            this.bt_close_Calendar.UseVisualStyleBackColor = false;
            this.bt_close_Calendar.Click += new System.EventHandler(this.bt_close_Calendar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 65);
            this.panel1.TabIndex = 7;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelHeader.Location = new System.Drawing.Point(310, 7);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(161, 46);
            this.labelHeader.TabIndex = 5;
            this.labelHeader.Text = "Calendar";
            // 
            // timerGlobal
            // 
            this.timerGlobal.Tick += new System.EventHandler(this.timerGlobal_Tick);
            // 
            // Form_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 985);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_close_Calendar);
            this.Controls.Add(this.flowLayoutPanelPlans);
            this.Name = "Form_Calendar";
            this.Text = "Form_Calendar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPlans;
        private System.Windows.Forms.Button bt_close_Calendar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Timer timerGlobal;
    }
}