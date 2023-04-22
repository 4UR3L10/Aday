
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
            this.panelPasswordVerify = new System.Windows.Forms.Panel();
            this.pictureBoxPasswordVerify = new System.Windows.Forms.PictureBox();
            this.textBoxPasswordVerify = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.PictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            this.panelEmailVerify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmailVerify)).BeginInit();
            this.panelPasswordVerify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordVerify)).BeginInit();
            this.panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 99);
            this.panel1.TabIndex = 7;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelHeader.Location = new System.Drawing.Point(77, 27);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(456, 46);
            this.labelHeader.TabIndex = 8;
            this.labelHeader.Text = "ADAY CHANGE PASSWORD";
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.pictureBoxEmail);
            this.panelEmail.Controls.Add(this.textBoxEmail);
            this.panelEmail.Location = new System.Drawing.Point(119, 144);
            this.panelEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(338, 51);
            this.panelEmail.TabIndex = 1;
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxEmail.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmail.InitialImage")));
            this.pictureBoxEmail.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(39, 51);
            this.pictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmail.TabIndex = 5;
            this.pictureBoxEmail.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(56, 15);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(262, 22);
            this.textBoxEmail.TabIndex = 9;
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
            this.buttonSendPassword.Location = new System.Drawing.Point(169, 448);
            this.buttonSendPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSendPassword.Name = "buttonSendPassword";
            this.buttonSendPassword.Size = new System.Drawing.Size(238, 51);
            this.buttonSendPassword.TabIndex = 5;
            this.buttonSendPassword.Text = "Change Password";
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
            this.btnClose.Location = new System.Drawing.Point(169, 524);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(238, 51);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelEmailVerify
            // 
            this.panelEmailVerify.Controls.Add(this.pictureBoxEmailVerify);
            this.panelEmailVerify.Controls.Add(this.textBoxEmailVerify);
            this.panelEmailVerify.Location = new System.Drawing.Point(121, 220);
            this.panelEmailVerify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEmailVerify.Name = "panelEmailVerify";
            this.panelEmailVerify.Size = new System.Drawing.Size(334, 51);
            this.panelEmailVerify.TabIndex = 2;
            // 
            // pictureBoxEmailVerify
            // 
            this.pictureBoxEmailVerify.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxEmailVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxEmailVerify.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxEmailVerify.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEmailVerify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxEmailVerify.Name = "pictureBoxEmailVerify";
            this.pictureBoxEmailVerify.Size = new System.Drawing.Size(39, 51);
            this.pictureBoxEmailVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmailVerify.TabIndex = 5;
            this.pictureBoxEmailVerify.TabStop = false;
            // 
            // textBoxEmailVerify
            // 
            this.textBoxEmailVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBoxEmailVerify.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmailVerify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmailVerify.Location = new System.Drawing.Point(56, 15);
            this.textBoxEmailVerify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmailVerify.Name = "textBoxEmailVerify";
            this.textBoxEmailVerify.Size = new System.Drawing.Size(262, 22);
            this.textBoxEmailVerify.TabIndex = 10;
            this.textBoxEmailVerify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEmailVerify_MouseClick);
            this.textBoxEmailVerify.MouseLeave += new System.EventHandler(this.textBoxEmailVerify_MouseLeave);
            // 
            // panelPasswordVerify
            // 
            this.panelPasswordVerify.Controls.Add(this.pictureBoxPasswordVerify);
            this.panelPasswordVerify.Controls.Add(this.textBoxPasswordVerify);
            this.panelPasswordVerify.Location = new System.Drawing.Point(121, 372);
            this.panelPasswordVerify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPasswordVerify.Name = "panelPasswordVerify";
            this.panelPasswordVerify.Size = new System.Drawing.Size(334, 51);
            this.panelPasswordVerify.TabIndex = 4;
            // 
            // pictureBoxPasswordVerify
            // 
            this.pictureBoxPasswordVerify.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxPasswordVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPasswordVerify.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxPasswordVerify.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPasswordVerify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxPasswordVerify.Name = "pictureBoxPasswordVerify";
            this.pictureBoxPasswordVerify.Size = new System.Drawing.Size(39, 51);
            this.pictureBoxPasswordVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPasswordVerify.TabIndex = 5;
            this.pictureBoxPasswordVerify.TabStop = false;
            // 
            // textBoxPasswordVerify
            // 
            this.textBoxPasswordVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBoxPasswordVerify.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordVerify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPasswordVerify.Location = new System.Drawing.Point(56, 15);
            this.textBoxPasswordVerify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPasswordVerify.Name = "textBoxPasswordVerify";
            this.textBoxPasswordVerify.Size = new System.Drawing.Size(262, 22);
            this.textBoxPasswordVerify.TabIndex = 12;
            this.textBoxPasswordVerify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPasswordVerify_MouseClick);
            this.textBoxPasswordVerify.Enter += new System.EventHandler(this.textBoxPasswordVerify_Enter);
            this.textBoxPasswordVerify.MouseLeave += new System.EventHandler(this.textBoxPasswordVerify_MouseLeave);
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.PictureBoxPassword);
            this.panelPassword.Controls.Add(this.textBoxPassword);
            this.panelPassword.Location = new System.Drawing.Point(121, 296);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(334, 51);
            this.panelPassword.TabIndex = 3;
            // 
            // PictureBoxPassword
            // 
            this.PictureBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.PictureBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureBoxPassword.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxPassword.InitialImage")));
            this.PictureBoxPassword.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBoxPassword.Name = "PictureBoxPassword";
            this.PictureBoxPassword.Size = new System.Drawing.Size(39, 51);
            this.PictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxPassword.TabIndex = 5;
            this.PictureBoxPassword.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(56, 15);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(262, 22);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPassword_MouseClick);
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.MouseLeave += new System.EventHandler(this.textBoxPassword_MouseLeave);
            // 
            // Form_Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 605);
            this.Controls.Add(this.panelPasswordVerify);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelEmailVerify);
            this.Controls.Add(this.buttonSendPassword);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.panelPasswordVerify.ResumeLayout(false);
            this.panelPasswordVerify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordVerify)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPassword)).EndInit();
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
        private System.Windows.Forms.Panel panelPasswordVerify;
        private System.Windows.Forms.PictureBox pictureBoxPasswordVerify;
        private System.Windows.Forms.TextBox textBoxPasswordVerify;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.PictureBox PictureBoxPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}