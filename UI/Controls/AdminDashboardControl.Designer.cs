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
            this.SuspendLayout();
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.Location = new System.Drawing.Point(20, 20);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(150, 40);
            this.btnManageBooks.TabIndex = 0;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(20, 70);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(150, 40);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageLoans
            // 
            this.btnManageLoans.Location = new System.Drawing.Point(20, 120);
            this.btnManageLoans.Name = "btnManageLoans";
            this.btnManageLoans.Size = new System.Drawing.Size(150, 40);
            this.btnManageLoans.TabIndex = 2;
            this.btnManageLoans.Text = "Manage Loans";
            this.btnManageLoans.UseVisualStyleBackColor = true;
            this.btnManageLoans.Click += new System.EventHandler(this.btnManageLoans_Click);
            // 
            // btnManageReservations
            // 
            this.btnManageReservations.Location = new System.Drawing.Point(20, 170);
            this.btnManageReservations.Name = "btnManageReservations";
            this.btnManageReservations.Size = new System.Drawing.Size(150, 40);
            this.btnManageReservations.TabIndex = 3;
            this.btnManageReservations.Text = "Manage Reservations";
            this.btnManageReservations.UseVisualStyleBackColor = true;
            this.btnManageReservations.Click += new System.EventHandler(this.btnManageReservations_Click);
            // 
            // btnManageInquiries
            // 
            this.btnManageInquiries.Location = new System.Drawing.Point(20, 220);
            this.btnManageInquiries.Name = "btnManageInquiries";
            this.btnManageInquiries.Size = new System.Drawing.Size(150, 40);
            this.btnManageInquiries.TabIndex = 4;
            this.btnManageInquiries.Text = "Manage Inquiries";
            this.btnManageInquiries.UseVisualStyleBackColor = true;
            this.btnManageInquiries.Click += new System.EventHandler(this.btnManageInquiries_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(20, 270);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(150, 40);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // AdminDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnManageInquiries);
            this.Controls.Add(this.btnManageReservations);
            this.Controls.Add(this.btnManageLoans);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageBooks);
            this.Name = "AdminDashboardControl";
            this.Size = new System.Drawing.Size(960, 540);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageLoans;
        private System.Windows.Forms.Button btnManageReservations;
        private System.Windows.Forms.Button btnManageInquiries;
        private System.Windows.Forms.Button btnLogOut; // Log Out button

        #endregion
    }
}
