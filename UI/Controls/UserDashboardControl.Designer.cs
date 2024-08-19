using System;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnBorrow.Location = new System.Drawing.Point(42, 134);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(90, 90);
            this.btnBorrow.TabIndex = 0;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnReserve.Location = new System.Drawing.Point(138, 134);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(90, 90);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnInquiry
            // 
            this.btnInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInquiry.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInquiry.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnInquiry.Location = new System.Drawing.Point(234, 134);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(90, 90);
            this.btnInquiry.TabIndex = 2;
            this.btnInquiry.Text = "Inquiry";
            this.btnInquiry.UseVisualStyleBackColor = true;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // btnMyBorrowings
            // 
            this.btnMyBorrowings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyBorrowings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyBorrowings.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnMyBorrowings.Location = new System.Drawing.Point(42, 240);
            this.btnMyBorrowings.Name = "btnMyBorrowings";
            this.btnMyBorrowings.Size = new System.Drawing.Size(139, 40);
            this.btnMyBorrowings.TabIndex = 3;
            this.btnMyBorrowings.Text = "My Borrowings";
            this.btnMyBorrowings.UseVisualStyleBackColor = true;
            this.btnMyBorrowings.Click += new System.EventHandler(this.btnMyBorrowings_Click);
            // 
            // btnMyReservations
            // 
            this.btnMyReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyReservations.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyReservations.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnMyReservations.Location = new System.Drawing.Point(183, 240);
            this.btnMyReservations.Name = "btnMyReservations";
            this.btnMyReservations.Size = new System.Drawing.Size(141, 40);
            this.btnMyReservations.TabIndex = 4;
            this.btnMyReservations.Text = "My Reservations";
            this.btnMyReservations.UseVisualStyleBackColor = true;
            this.btnMyReservations.Click += new System.EventHandler(this.btnMyReservations_Click);
            // 
            // btnMyInquiries
            // 
            this.btnMyInquiries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyInquiries.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyInquiries.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnMyInquiries.Location = new System.Drawing.Point(42, 295);
            this.btnMyInquiries.Name = "btnMyInquiries";
            this.btnMyInquiries.Size = new System.Drawing.Size(282, 40);
            this.btnMyInquiries.TabIndex = 5;
            this.btnMyInquiries.Text = "My Inquiries";
            this.btnMyInquiries.UseVisualStyleBackColor = true;
            this.btnMyInquiries.Click += new System.EventHandler(this.BtnMyInquiries_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogOut.Location = new System.Drawing.Point(138, 394);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(105, 40);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(36, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 32);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Welcome!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SarasaviLMS.Properties.Resources.LibraryPhotoAsset;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(367, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 540);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UserDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMyInquiries);
            this.Controls.Add(this.btnMyReservations);
            this.Controls.Add(this.btnMyBorrowings);
            this.Controls.Add(this.btnInquiry);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnBorrow);
            this.Name = "UserDashboardControl";
            this.Size = new System.Drawing.Size(960, 540);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Button btnMyBorrowings;
        private System.Windows.Forms.Button btnMyReservations;
        private System.Windows.Forms.Button btnMyInquiries;
        private System.Windows.Forms.Button btnLogOut; // Log Out button

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
