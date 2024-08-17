namespace SarasaviLMS.UI
{
    partial class RegisterForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.text_AlreadyHaveAnAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(352, 207);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.BackColor = System.Drawing.Color.Transparent;
            this.lblNIC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblNIC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNIC.Location = new System.Drawing.Point(352, 250);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(32, 17);
            this.lblNIC.TabIndex = 2;
            this.lblNIC.Text = "NIC";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblSex.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSex.Location = new System.Drawing.Point(352, 290);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(28, 17);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "Sex";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddress.Location = new System.Drawing.Point(352, 330);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 17);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Black;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtName.Location = new System.Drawing.Point(483, 207);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtNIC
            // 
            this.txtNIC.BackColor = System.Drawing.Color.Black;
            this.txtNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNIC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNIC.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNIC.Location = new System.Drawing.Point(483, 246);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(150, 22);
            this.txtNIC.TabIndex = 6;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.Black;
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSex.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSex.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSex.Location = new System.Drawing.Point(483, 285);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(150, 22);
            this.txtSex.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Black;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAddress.Location = new System.Drawing.Point(483, 326);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 22);
            this.txtAddress.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnRegister.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnRegister.Location = new System.Drawing.Point(355, 375);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(278, 32);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.BackColor = System.Drawing.Color.Transparent;
            this.text1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.text1.ForeColor = System.Drawing.SystemColors.Control;
            this.text1.Location = new System.Drawing.Point(349, 124);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(271, 32);
            this.text1.TabIndex = 10;
            this.text1.Text = "Create an account.";
            // 
            // text_AlreadyHaveAnAccount
            // 
            this.text_AlreadyHaveAnAccount.AutoSize = true;
            this.text_AlreadyHaveAnAccount.BackColor = System.Drawing.Color.Transparent;
            this.text_AlreadyHaveAnAccount.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline);
            this.text_AlreadyHaveAnAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.text_AlreadyHaveAnAccount.Location = new System.Drawing.Point(352, 165);
            this.text_AlreadyHaveAnAccount.Name = "text_AlreadyHaveAnAccount";
            this.text_AlreadyHaveAnAccount.Size = new System.Drawing.Size(156, 16);
            this.text_AlreadyHaveAnAccount.TabIndex = 11;
            this.text_AlreadyHaveAnAccount.Text = "Already have an account?";
            this.text_AlreadyHaveAnAccount.Click += new System.EventHandler(this.text_AlreadyHaveAnAccount_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SarasaviLMS.Properties.Resources.Gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.text_AlreadyHaveAnAccount);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblNIC);
            this.Controls.Add(this.lblName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text_AlreadyHaveAnAccount;

        #endregion
    }
}
