namespace SarasaviLMS.UI
{
    partial class LoginForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.text_DontHaveAnAccount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(582, 220);
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
            this.lblNIC.Location = new System.Drawing.Point(582, 263);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(32, 17);
            this.lblNIC.TabIndex = 2;
            this.lblNIC.Text = "NIC";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Black;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtName.Location = new System.Drawing.Point(713, 220);
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
            this.txtNIC.Location = new System.Drawing.Point(713, 259);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(150, 22);
            this.txtNIC.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnLogin.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnLogin.Location = new System.Drawing.Point(585, 313);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(278, 32);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.BackColor = System.Drawing.Color.Transparent;
            this.text1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.text1.ForeColor = System.Drawing.SystemColors.Control;
            this.text1.Location = new System.Drawing.Point(579, 137);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(91, 32);
            this.text1.TabIndex = 10;
            this.text1.Text = "Login.";
            // 
            // text_DontHaveAnAccount
            // 
            this.text_DontHaveAnAccount.AutoSize = true;
            this.text_DontHaveAnAccount.BackColor = System.Drawing.Color.Transparent;
            this.text_DontHaveAnAccount.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline);
            this.text_DontHaveAnAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.text_DontHaveAnAccount.Location = new System.Drawing.Point(582, 363);
            this.text_DontHaveAnAccount.Name = "text_DontHaveAnAccount";
            this.text_DontHaveAnAccount.Size = new System.Drawing.Size(143, 16);
            this.text_DontHaveAnAccount.TabIndex = 11;
            this.text_DontHaveAnAccount.Text = "Don\'t have an account?";
            this.text_DontHaveAnAccount.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SarasaviLMS.Properties.Resources.LoginInfoPhoto;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 540);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SarasaviLMS.Properties.Resources.Gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_DontHaveAnAccount);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNIC);
            this.Controls.Add(this.lblName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text_DontHaveAnAccount;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
