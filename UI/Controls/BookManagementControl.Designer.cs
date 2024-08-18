namespace SarasaviLMS.UI.Controls
{
    partial class BookManagementControl
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
            this.flowLayoutPanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBooks
            // 
            this.flowLayoutPanelBooks.AutoScroll = true;
            this.flowLayoutPanelBooks.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelBooks.Location = new System.Drawing.Point(20, 60);
            this.flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            this.flowLayoutPanelBooks.Size = new System.Drawing.Size(900, 459);
            this.flowLayoutPanelBooks.TabIndex = 0;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBook.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBook.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAddNewBook.Location = new System.Drawing.Point(20, 20);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(150, 30);
            this.btnAddNewBook.TabIndex = 1;
            this.btnAddNewBook.Text = "Add New Book";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.BtnAddNewBook_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.BackColor = System.Drawing.Color.MediumPurple;
            this.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSearchBar.Location = new System.Drawing.Point(633, 20);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(287, 29);
            this.txtSearchBar.TabIndex = 2;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.TxtSearchBar_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblSearch.Location = new System.Drawing.Point(564, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(63, 19);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search";
            // 
            // BookManagementControl
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::SarasaviLMS.Properties.Resources.LibraryPhotoAsset2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.flowLayoutPanelBooks);
            this.Name = "BookManagementControl";
            this.Size = new System.Drawing.Size(960, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBooks;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.TextBox txtSearchBar;

        #endregion

        private System.Windows.Forms.Label lblSearch;
    }
}
