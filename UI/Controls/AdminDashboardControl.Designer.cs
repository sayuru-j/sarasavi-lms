namespace SarasaviLMS.UI.Controls
{
    partial class AdminDashboardControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageLoans = new System.Windows.Forms.Button();
            this.btnManageReservations = new System.Windows.Forms.Button();
            this.btnManageInquiries = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBooks.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBooks.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnManageBooks.Location = new System.Drawing.Point(615, 122);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(90, 90);
            this.btnManageBooks.TabIndex = 0;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.Click += new System.EventHandler(this.BtnManageBooks_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnManageUsers.Location = new System.Drawing.Point(711, 122);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(90, 90);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageLoans
            // 
            this.btnManageLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageLoans.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageLoans.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnManageLoans.Location = new System.Drawing.Point(615, 237);
            this.btnManageLoans.Name = "btnManageLoans";
            this.btnManageLoans.Size = new System.Drawing.Size(282, 50);
            this.btnManageLoans.TabIndex = 2;
            this.btnManageLoans.Text = "Manage Loans";
            this.btnManageLoans.UseVisualStyleBackColor = true;
            this.btnManageLoans.Click += new System.EventHandler(this.btnManageLoans_Click);
            // 
            // btnManageReservations
            // 
            this.btnManageReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageReservations.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageReservations.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnManageReservations.Location = new System.Drawing.Point(615, 302);
            this.btnManageReservations.Name = "btnManageReservations";
            this.btnManageReservations.Size = new System.Drawing.Size(282, 50);
            this.btnManageReservations.TabIndex = 3;
            this.btnManageReservations.Text = "Manage Reservations";
            this.btnManageReservations.UseVisualStyleBackColor = true;
            this.btnManageReservations.Click += new System.EventHandler(this.btnManageReservations_Click);
            // 
            // btnManageInquiries
            // 
            this.btnManageInquiries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageInquiries.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageInquiries.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnManageInquiries.Location = new System.Drawing.Point(807, 122);
            this.btnManageInquiries.Name = "btnManageInquiries";
            this.btnManageInquiries.Size = new System.Drawing.Size(90, 90);
            this.btnManageInquiries.TabIndex = 4;
            this.btnManageInquiries.Text = "Manage Inquiries";
            this.btnManageInquiries.UseVisualStyleBackColor = true;
            this.btnManageInquiries.Click += new System.EventHandler(this.btnManageInquiries_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogOut.Location = new System.Drawing.Point(711, 422);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(90, 43);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(609, 63);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(279, 32);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Librarian Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SarasaviLMS.Properties.Resources.LibraryPhotoAsset3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 540);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AdminDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnManageInquiries);
            this.Controls.Add(this.btnManageReservations);
            this.Controls.Add(this.btnManageLoans);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageBooks);
            this.Name = "AdminDashboardControl";
            this.Size = new System.Drawing.Size(960, 540);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageLoans;
        private System.Windows.Forms.Button btnManageReservations;
        private System.Windows.Forms.Button btnManageInquiries;
        private System.Windows.Forms.Button btnLogOut; // Log Out button

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
