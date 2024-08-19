namespace SarasaviLMS.UI.Controls.InquiryRel
{
    partial class MyInquiriesControl
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
            this.flowLayoutPanelInquiries = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNewInquiry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelInquiries
            // 
            this.flowLayoutPanelInquiries.AutoScroll = true;
            this.flowLayoutPanelInquiries.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelInquiries.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelInquiries.Name = "flowLayoutPanelInquiries";
            this.flowLayoutPanelInquiries.Size = new System.Drawing.Size(800, 400);
            this.flowLayoutPanelInquiries.TabIndex = 0;
            // 
            // btnAddNewInquiry
            // 
            this.btnAddNewInquiry.Location = new System.Drawing.Point(10, 410);
            this.btnAddNewInquiry.Name = "btnAddNewInquiry";
            this.btnAddNewInquiry.Size = new System.Drawing.Size(120, 30);
            this.btnAddNewInquiry.TabIndex = 1;
            this.btnAddNewInquiry.Text = "Add New Inquiry";
            this.btnAddNewInquiry.UseVisualStyleBackColor = true;
            this.btnAddNewInquiry.Click += new System.EventHandler(this.btnAddNewInquiry_Click);
            // 
            // MyInquiriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddNewInquiry);
            this.Controls.Add(this.flowLayoutPanelInquiries);
            this.Name = "MyInquiriesControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInquiries;
        private System.Windows.Forms.Button btnAddNewInquiry;
    }
}
