using System;
using System.Windows.Forms;

namespace SarasaviLMS.UI.Controls
{
    public partial class BookItemControl : UserControl
    {
        public event Action OnUpdateClicked;
        public event Action OnDeleteClicked;

        public BookItemControl(string title, string author, string isbn, string publisher)
        {
            InitializeComponent();
            lblTitle.Text = title;
            lblAuthor.Text = $"Author: {author}";
            lblISBN.Text = $"ISBN: {isbn}";
            lblPublisher.Text = $"Publisher: {publisher}";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OnUpdateClicked?.Invoke();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnDeleteClicked?.Invoke();
        }
    }
}
