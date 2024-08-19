namespace SarasaviLMS.UI.Controls
{
    partial class InquiryManagementControl
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
            this.SuspendLayout();
            // 
            // flowLayoutPanelInquiries
            // 
            this.flowLayoutPanelInquiries.AutoScroll = true;
            this.flowLayoutPanelInquiries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelInquiries.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelInquiries.Name = "flowLayoutPanelInquiries";
            this.flowLayoutPanelInquiries.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanelInquiries.TabIndex = 0;
            // 
            // InquiryManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelInquiries);
            this.Name = "InquiryManagementControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInquiries;
    }
}
