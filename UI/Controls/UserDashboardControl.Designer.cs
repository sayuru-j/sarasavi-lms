namespace SarasaviLMS.UI.Controls
{
    partial class UserDashboardControl
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
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.btnMyBorrowings = new System.Windows.Forms.Button();
            this.btnMyReservations = new System.Windows.Forms.Button();
            this.btnMyInquiries = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(20, 20);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(150, 40);
            this.btnBorrow.TabIndex = 0;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(20, 70);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(150, 40);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnInquiry
            // 
            this.btnInquiry.Location = new System.Drawing.Point(20, 120);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(150, 40);
            this.btnInquiry.TabIndex = 2;
            this.btnInquiry.Text = "Inquiry";
            this.btnInquiry.UseVisualStyleBackColor = true;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // btnMyBorrowings
            // 
            this.btnMyBorrowings.Location = new System.Drawing.Point(20, 170);
            this.btnMyBorrowings.Name = "btnMyBorrowings";
            this.btnMyBorrowings.Size = new System.Drawing.Size(150, 40);
            this.btnMyBorrowings.TabIndex = 3;
            this.btnMyBorrowings.Text = "My Borrowings";
            this.btnMyBorrowings.UseVisualStyleBackColor = true;
            this.btnMyBorrowings.Click += new System.EventHandler(this.btnMyBorrowings_Click);
            // 
            // btnMyReservations
            // 
            this.btnMyReservations.Location = new System.Drawing.Point(20, 220);
            this.btnMyReservations.Name = "btnMyReservations";
            this.btnMyReservations.Size = new System.Drawing.Size(150, 40);
            this.btnMyReservations.TabIndex = 4;
            this.btnMyReservations.Text = "My Reservations";
            this.btnMyReservations.UseVisualStyleBackColor = true;
            this.btnMyReservations.Click += new System.EventHandler(this.btnMyReservations_Click);
            // 
            // btnMyInquiries
            // 
            this.btnMyInquiries.Location = new System.Drawing.Point(20, 270);
            this.btnMyInquiries.Name = "btnMyInquiries";
            this.btnMyInquiries.Size = new System.Drawing.Size(150, 40);
            this.btnMyInquiries.TabIndex = 5;
            this.btnMyInquiries.Text = "My Inquiries";
            this.btnMyInquiries.UseVisualStyleBackColor = true;
            this.btnMyInquiries.Click += new System.EventHandler(this.btnMyInquiries_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(20, 320);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(150, 40);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // UserDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMyInquiries);
            this.Controls.Add(this.btnMyReservations);
            this.Controls.Add(this.btnMyBorrowings);
            this.Controls.Add(this.btnInquiry);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnBorrow);
            this.Name = "UserDashboardControl";
            this.Size = new System.Drawing.Size(960, 540);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Button btnMyBorrowings;
        private System.Windows.Forms.Button btnMyReservations;
        private System.Windows.Forms.Button btnMyInquiries;
        private System.Windows.Forms.Button btnLogOut; // Log Out button

        #endregion
    }
}
