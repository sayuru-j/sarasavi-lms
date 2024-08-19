namespace SarasaviLMS.UI.Controls.LoanRel
{
    partial class AddBorrowControl
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
            this.comboBoxBookTitle = new System.Windows.Forms.ComboBox();
            this.comboBoxCopyNumber = new System.Windows.Forms.ComboBox();
            this.datePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblCopyNumber = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxBookTitle
            // 
            this.comboBoxBookTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBookTitle.FormattingEnabled = true;
            this.comboBoxBookTitle.Location = new System.Drawing.Point(150, 30);
            this.comboBoxBookTitle.Name = "comboBoxBookTitle";
            this.comboBoxBookTitle.Size = new System.Drawing.Size(200, 21);
            this.comboBoxBookTitle.TabIndex = 0;
            this.comboBoxBookTitle.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookTitle_SelectedIndexChanged);
            // 
            // comboBoxCopyNumber
            // 
            this.comboBoxCopyNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCopyNumber.FormattingEnabled = true;
            this.comboBoxCopyNumber.Location = new System.Drawing.Point(150, 70);
            this.comboBoxCopyNumber.Name = "comboBoxCopyNumber";
            this.comboBoxCopyNumber.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCopyNumber.TabIndex = 1;
            // 
            // datePickerDueDate
            // 
            this.datePickerDueDate.Location = new System.Drawing.Point(150, 110);
            this.datePickerDueDate.Name = "datePickerDueDate";
            this.datePickerDueDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerDueDate.TabIndex = 2;
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Location = new System.Drawing.Point(150, 150);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(200, 30);
            this.btnBorrowBook.TabIndex = 3;
            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(30, 30);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(58, 13);
            this.lblBookTitle.TabIndex = 4;
            this.lblBookTitle.Text = "Book Title:";
            // 
            // lblCopyNumber
            // 
            this.lblCopyNumber.AutoSize = true;
            this.lblCopyNumber.Location = new System.Drawing.Point(30, 70);
            this.lblCopyNumber.Name = "lblCopyNumber";
            this.lblCopyNumber.Size = new System.Drawing.Size(74, 13);
            this.lblCopyNumber.TabIndex = 5;
            this.lblCopyNumber.Text = "Copy Number:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(30, 110);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "Due Date:";
            // 
            // AddBorrowControl
            // 
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblCopyNumber);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.datePickerDueDate);
            this.Controls.Add(this.comboBoxCopyNumber);
            this.Controls.Add(this.comboBoxBookTitle);
            this.Name = "AddBorrowControl";
            this.Size = new System.Drawing.Size(400, 200);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxBookTitle;
        private System.Windows.Forms.ComboBox comboBoxCopyNumber;
        private System.Windows.Forms.DateTimePicker datePickerDueDate;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblCopyNumber;
        private System.Windows.Forms.Label lblDueDate;

        #endregion
    }
}
