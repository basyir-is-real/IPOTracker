namespace IPOTracker
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SignOutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.StoreLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LibraryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CommunityLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UsernameLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 681);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.usernameLabel2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usernameLabel2
            // 
            this.usernameLabel2.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.usernameLabel2.AutoSize = true;
            this.usernameLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameLabel2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.usernameLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.usernameLabel2.LinkColor = System.Drawing.Color.Black;
            this.usernameLabel2.Location = new System.Drawing.Point(53, 90);
            this.usernameLabel2.Name = "usernameLabel2";
            this.usernameLabel2.Size = new System.Drawing.Size(75, 21);
            this.usernameLabel2.TabIndex = 18;
            this.usernameLabel2.TabStop = true;
            this.usernameLabel2.Text = "John Doe";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(38, 116);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 17);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "User Description";
            // 
            // SignOutLinkLabel
            // 
            this.SignOutLinkLabel.ActiveLinkColor = System.Drawing.Color.DarkOrange;
            this.SignOutLinkLabel.AutoSize = true;
            this.SignOutLinkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutLinkLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SignOutLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.SignOutLinkLabel.LinkColor = System.Drawing.Color.DodgerBlue;
            this.SignOutLinkLabel.Location = new System.Drawing.Point(1100, 52);
            this.SignOutLinkLabel.Name = "SignOutLinkLabel";
            this.SignOutLinkLabel.Size = new System.Drawing.Size(71, 21);
            this.SignOutLinkLabel.TabIndex = 21;
            this.SignOutLinkLabel.TabStop = true;
            this.SignOutLinkLabel.Text = "Sign Out";
            this.SignOutLinkLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SignOutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignOutLinkLabel_LinkClicked);
            // 
            // StoreLinkLabel
            // 
            this.StoreLinkLabel.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.StoreLinkLabel.AutoSize = true;
            this.StoreLinkLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreLinkLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.StoreLinkLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StoreLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.StoreLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.StoreLinkLabel.Location = new System.Drawing.Point(236, 36);
            this.StoreLinkLabel.Name = "StoreLinkLabel";
            this.StoreLinkLabel.Size = new System.Drawing.Size(94, 37);
            this.StoreLinkLabel.TabIndex = 17;
            this.StoreLinkLabel.TabStop = true;
            this.StoreLinkLabel.Text = "STORE";
            // 
            // LibraryLinkLabel
            // 
            this.LibraryLinkLabel.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.LibraryLinkLabel.AutoSize = true;
            this.LibraryLinkLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryLinkLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.LibraryLinkLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LibraryLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LibraryLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.LibraryLinkLabel.Location = new System.Drawing.Point(361, 36);
            this.LibraryLinkLabel.Name = "LibraryLinkLabel";
            this.LibraryLinkLabel.Size = new System.Drawing.Size(115, 37);
            this.LibraryLinkLabel.TabIndex = 18;
            this.LibraryLinkLabel.TabStop = true;
            this.LibraryLinkLabel.Text = "LIBRARY";
            // 
            // CommunityLinkLabel
            // 
            this.CommunityLinkLabel.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.CommunityLinkLabel.AutoSize = true;
            this.CommunityLinkLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommunityLinkLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.CommunityLinkLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CommunityLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.CommunityLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.CommunityLinkLabel.Location = new System.Drawing.Point(509, 36);
            this.CommunityLinkLabel.Name = "CommunityLinkLabel";
            this.CommunityLinkLabel.Size = new System.Drawing.Size(177, 37);
            this.CommunityLinkLabel.TabIndex = 19;
            this.CommunityLinkLabel.TabStop = true;
            this.CommunityLinkLabel.Text = "COMMUNITY";
            // 
            // UsernameLinkLabel
            // 
            this.UsernameLinkLabel.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.UsernameLinkLabel.AutoSize = true;
            this.UsernameLinkLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLinkLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.UsernameLinkLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UsernameLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.UsernameLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.UsernameLinkLabel.Location = new System.Drawing.Point(728, 36);
            this.UsernameLinkLabel.Name = "UsernameLinkLabel";
            this.UsernameLinkLabel.Size = new System.Drawing.Size(155, 37);
            this.UsernameLinkLabel.TabIndex = 20;
            this.UsernameLinkLabel.TabStop = true;
            this.UsernameLinkLabel.Text = "USERNAME";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SignOutLinkLabel);
            this.Controls.Add(this.UsernameLinkLabel);
            this.Controls.Add(this.CommunityLinkLabel);
            this.Controls.Add(this.LibraryLinkLabel);
            this.Controls.Add(this.StoreLinkLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "DashboardForm";
            this.Text = "IPO Tracker | Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel usernameLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel SignOutLinkLabel;
        private System.Windows.Forms.LinkLabel StoreLinkLabel;
        private System.Windows.Forms.LinkLabel LibraryLinkLabel;
        private System.Windows.Forms.LinkLabel CommunityLinkLabel;
        private System.Windows.Forms.LinkLabel UsernameLinkLabel;
    }
}