
namespace Aday_DA
{
    partial class Form_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Delete));
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.labelPlanEv = new System.Windows.Forms.Label();
            this.labelPlan = new System.Windows.Forms.Label();
            this.comboBoxPlan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEvent = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.bt_close_Adding_Event = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelHeader.Location = new System.Drawing.Point(307, 6);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(136, 46);
            this.labelHeader.TabIndex = 5;
            this.labelHeader.Text = "DELETE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 65);
            this.panel1.TabIndex = 7;
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(262, 84);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(262, 28);
            this.comboBoxDate.TabIndex = 22;
            this.comboBoxDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate_SelectedIndexChanged);
            // 
            // labelPlanEv
            // 
            this.labelPlanEv.AutoSize = true;
            this.labelPlanEv.Location = new System.Drawing.Point(212, 139);
            this.labelPlanEv.Name = "labelPlanEv";
            this.labelPlanEv.Size = new System.Drawing.Size(37, 20);
            this.labelPlanEv.TabIndex = 21;
            this.labelPlanEv.Text = "Plan";
            // 
            // labelPlan
            // 
            this.labelPlan.AutoSize = true;
            this.labelPlan.Location = new System.Drawing.Point(205, 87);
            this.labelPlan.Name = "labelPlan";
            this.labelPlan.Size = new System.Drawing.Size(41, 20);
            this.labelPlan.TabIndex = 20;
            this.labelPlan.Text = "Date";
            // 
            // comboBoxPlan
            // 
            this.comboBoxPlan.FormattingEnabled = true;
            this.comboBoxPlan.Location = new System.Drawing.Point(262, 136);
            this.comboBoxPlan.Name = "comboBoxPlan";
            this.comboBoxPlan.Size = new System.Drawing.Size(262, 28);
            this.comboBoxPlan.TabIndex = 19;
            this.comboBoxPlan.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Event";
            // 
            // comboBoxEvent
            // 
            this.comboBoxEvent.FormattingEnabled = true;
            this.comboBoxEvent.Location = new System.Drawing.Point(262, 186);
            this.comboBoxEvent.Name = "comboBoxEvent";
            this.comboBoxEvent.Size = new System.Drawing.Size(262, 28);
            this.comboBoxEvent.TabIndex = 23;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(274, 255);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(239, 48);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // bt_close_Adding_Event
            // 
            this.bt_close_Adding_Event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.bt_close_Adding_Event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_close_Adding_Event.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_close_Adding_Event.Location = new System.Drawing.Point(274, 322);
            this.bt_close_Adding_Event.Name = "bt_close_Adding_Event";
            this.bt_close_Adding_Event.Size = new System.Drawing.Size(239, 48);
            this.bt_close_Adding_Event.TabIndex = 26;
            this.bt_close_Adding_Event.Text = "Close";
            this.bt_close_Adding_Event.UseVisualStyleBackColor = false;
            this.bt_close_Adding_Event.Click += new System.EventHandler(this.bt_close_Adding_Event_Click);
            // 
            // Form_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.bt_close_Adding_Event);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEvent);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.labelPlanEv);
            this.Controls.Add(this.labelPlan);
            this.Controls.Add(this.comboBoxPlan);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Delete";
            this.Text = "Form_Delete";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.Label labelPlanEv;
        private System.Windows.Forms.Label labelPlan;
        private System.Windows.Forms.ComboBox comboBoxPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEvent;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button bt_close_Adding_Event;
    }
}