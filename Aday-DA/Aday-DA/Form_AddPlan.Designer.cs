
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
            this.SuspendLayout();
            // 
            // bt_save_Plan
            // 
            this.bt_save_Plan.Location = new System.Drawing.Point(231, 362);
            this.bt_save_Plan.Name = "bt_save_Plan";
            this.bt_save_Plan.Size = new System.Drawing.Size(94, 29);
            this.bt_save_Plan.TabIndex = 0;
            this.bt_save_Plan.Text = "Save Plan";
            this.bt_save_Plan.UseVisualStyleBackColor = true;
            this.bt_save_Plan.Click += new System.EventHandler(this.bt_save_Plan_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(177, 72);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(38, 20);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Title";
            // 
            // txtBox_Title
            // 
            this.txtBox_Title.Location = new System.Drawing.Point(231, 69);
            this.txtBox_Title.Name = "txtBox_Title";
            this.txtBox_Title.Size = new System.Drawing.Size(125, 27);
            this.txtBox_Title.TabIndex = 2;
            // 
            // Form_AddPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txtBox_Title);
            this.Controls.Add(this.bt_save_Plan);
            this.Name = "Form_AddPlan";
            this.Text = "Add Plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_save_Plan;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txtBox_Title;
    }
}