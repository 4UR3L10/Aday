
namespace Aday_DA
{
    partial class Form_Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Change_Password));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonSendPassword = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelEmailVerify = new System.Windows.Forms.Panel();
            this.pictureBoxEmailVerify = new System.Windows.Forms.PictureBox();
            this.textBoxEmailVerify = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            this.panelEmailVerify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmailVerify)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 74);
            this.panel1.TabIndex = 5;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelHeader.Location = new System.Drawing.Point(8, 20);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(476, 37);
            this.labelHeader.TabIndex = 5;
            this.labelHeader.Text = "ADAY FORGOT CHANGE PASSWORD";
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.pictureBoxEmail);
            this.panelEmail.Controls.Add(this.textBoxEmail);
            this.panelEmail.Location = new System.Drawing.Point(94, 168);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(296, 38);
            this.panelEmail.TabIndex = 10;
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxEmail.Image = global::Aday_DA.Resources.PicResource.clipart162850;
            this.pictureBoxEmail.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmail.InitialImage")));
            this.pictureBoxEmail.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(34, 38);
            this.pictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmail.TabIndex = 5;
            this.pictureBoxEmail.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(49, 11);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(229, 18);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEmail_MouseClick);
            this.textBoxEmail.MouseLeave += new System.EventHandler(this.textBoxEmail_MouseLeave);
            // 
            // buttonSendPassword
            // 
            this.buttonSendPassword.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSendPassword.FlatAppearance.BorderSize = 0;
            this.buttonSendPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSendPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSendPassword.Location = new System.Drawing.Point(138, 300);
            this.buttonSendPassword.Name = "buttonSendPassword";
            this.buttonSendPassword.Size = new System.Drawing.Size(208, 38);
            this.buttonSendPassword.TabIndex = 15;
            this.buttonSendPassword.Text = "Send Password";
            this.buttonSendPassword.UseVisualStyleBackColor = false;
            this.buttonSendPassword.Click += new System.EventHandler(this.buttonSendPassword_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(138, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(208, 38);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelEmailVerify
            // 
            this.panelEmailVerify.Controls.Add(this.pictureBoxEmailVerify);
            this.panelEmailVerify.Controls.Add(this.textBoxEmailVerify);
            this.panelEmailVerify.Location = new System.Drawing.Point(96, 234);
            this.panelEmailVerify.Name = "panelEmailVerify";
            this.panelEmailVerify.Size = new System.Drawing.Size(292, 38);
            this.panelEmailVerify.TabIndex = 16;
            // 
            // pictureBoxEmailVerify
            // 
            this.pictureBoxEmailVerify.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxEmailVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxEmailVerify.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxEmailVerify.Image = global::Aday_DA.Resources.PicResource.clipart162850;
            this.pictureBoxEmailVerify.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEmailVerify.Name = "pictureBoxEmailVerify";
            this.pictureBoxEmailVerify.Size = new System.Drawing.Size(34, 38);
            this.pictureBoxEmailVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmailVerify.TabIndex = 5;
            this.pictureBoxEmailVerify.TabStop = false;
            // 
            // textBoxEmailVerify
            // 
            this.textBoxEmailVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBoxEmailVerify.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmailVerify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmailVerify.Location = new System.Drawing.Point(49, 11);
            this.textBoxEmailVerify.Name = "textBoxEmailVerify";
            this.textBoxEmailVerify.Size = new System.Drawing.Size(229, 18);
            this.textBoxEmailVerify.TabIndex = 3;
            this.textBoxEmailVerify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEmailVerify_MouseClick);
            this.textBoxEmailVerify.MouseLeave += new System.EventHandler(this.textBoxEmailVerify_MouseLeave);
            // 
            // Form_Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 454);
            this.Controls.Add(this.panelEmailVerify);
            this.Controls.Add(this.buttonSendPassword);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Change_Password";
            this.Text = "Aday Forgot Change Password";
            this.Load += new System.EventHandler(this.Form_Change_Password_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            this.panelEmailVerify.ResumeLayout(false);
            this.panelEmailVerify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmailVerify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.PictureBox pictureBoxEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonSendPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelEmailVerify;
        private System.Windows.Forms.PictureBox pictureBoxEmailVerify;
        private System.Windows.Forms.TextBox textBoxEmailVerify;
    }
}