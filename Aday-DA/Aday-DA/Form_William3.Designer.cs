
namespace Aday_DA
{
    partial class Form_William3
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
            this.bt_save_Event = new System.Windows.Forms.Button();
            this.bt_close_Adding_Event = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_save_Event
            // 
            this.bt_save_Event.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_save_Event.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_save_Event.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_save_Event.Location = new System.Drawing.Point(54, 289);
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
            this.bt_close_Adding_Event.Location = new System.Drawing.Point(440, 289);
            this.bt_close_Adding_Event.Name = "bt_close_Adding_Event";
            this.bt_close_Adding_Event.Size = new System.Drawing.Size(239, 48);
            this.bt_close_Adding_Event.TabIndex = 17;
            this.bt_close_Adding_Event.Text = "Close";
            this.bt_close_Adding_Event.UseVisualStyleBackColor = false;
            this.bt_close_Adding_Event.Click += new System.EventHandler(this.bt_close_Adding_Event_Click);
            // 
            // Form_William3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_close_Adding_Event);
            this.Controls.Add(this.bt_save_Event);
            this.Name = "Form_William3";
            this.Text = "Form_William3";
            this.Load += new System.EventHandler(this.Form_William3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_save_Event;
        private System.Windows.Forms.Button bt_close_Adding_Event;
    }
}