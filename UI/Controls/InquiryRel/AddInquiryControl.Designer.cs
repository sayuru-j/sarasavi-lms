namespace SarasaviLMS.UI.Controls.InquiryRel
{
    partial class AddInquiryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.lblInquiryDetails = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtInquiryDetails = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUserId.Location = new System.Drawing.Point(20, 20);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(64, 21);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "User ID:";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBookId.Location = new System.Drawing.Point(20, 60);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(67, 21);
            this.lblBookId.TabIndex = 1;
            this.lblBookId.Text = "Book ID:";
            // 
            // lblInquiryDetails
            // 
            this.lblInquiryDetails.AutoSize = true;
            this.lblInquiryDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblInquiryDetails.Location = new System.Drawing.Point(20, 100);
            this.lblInquiryDetails.Name = "lblInquiryDetails";
            this.lblInquiryDetails.Size = new System.Drawing.Size(113, 21);
            this.lblInquiryDetails.TabIndex = 2;
            this.lblInquiryDetails.Text = "Inquiry Details:";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserId.Location = new System.Drawing.Point(140, 17);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(200, 29);
            this.txtUserId.TabIndex = 3;
            // 
            // txtBookId
            // 
            this.txtBookId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBookId.Location = new System.Drawing.Point(140, 57);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(200, 29);
            this.txtBookId.TabIndex = 4;
            // 
            // txtInquiryDetails
            // 
            this.txtInquiryDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtInquiryDetails.Location = new System.Drawing.Point(140, 97);
            this.txtInquiryDetails.Multiline = true;
            this.txtInquiryDetails.Name = "txtInquiryDetails";
            this.txtInquiryDetails.Size = new System.Drawing.Size(200, 100);
            this.txtInquiryDetails.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Location = new System.Drawing.Point(140, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Inquiry";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(140, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddInquiryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInquiryDetails);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblInquiryDetails);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.lblUserId);
            this.Name = "AddInquiryControl";
            this.Size = new System.Drawing.Size(400, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblInquiryDetails;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtInquiryDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
