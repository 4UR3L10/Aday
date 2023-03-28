
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
            this.listViewPlans = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewPlans
            // 
            this.listViewPlans.HideSelection = false;
            this.listViewPlans.Location = new System.Drawing.Point(63, 208);
            this.listViewPlans.Name = "listViewPlans";
            this.listViewPlans.Size = new System.Drawing.Size(705, 214);
            this.listViewPlans.TabIndex = 0;
            this.listViewPlans.UseCompatibleStateImageBehavior = false;
            // 
            // Form_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewPlans);
            this.Name = "Form_Calendar";
            this.Text = "Form_Calendar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPlans;
    }
}