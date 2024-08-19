using SarasaviLMS.UI.Controls;
using SarasaviLMS.UI;
using System.Windows.Forms;
using SarasaviLMS.UI.Controls.InquiryRel;
using SarasaviLMS.UI.Controls.LoanRel;

namespace SarasaviLMS.Utils
{
    public static class Navigator
    {
        public static void Navigate(Form parentForm, NavigationTarget target)
        {
            if (parentForm == null) return;

            UserControl controlToLoad = null;

            switch (target)
            {
                case NavigationTarget.AdminDashboard:
                    controlToLoad = new AdminDashboardControl
                    {
                        Dock = DockStyle.Fill
                    };
                    break;

                case NavigationTarget.UserDashboard:
                    controlToLoad = new UserDashboardControl
                    {
                        Dock = DockStyle.Fill
                    };
                    break;

                case NavigationTarget.UserManagement:
                    controlToLoad = new UserManagementControl
                    {
                        Dock = DockStyle.Fill
                    };
                    break;

                case NavigationTarget.BookManagement:
                    controlToLoad = new BookManagementControl
                    {
                        Dock = DockStyle.Fill
                    };
                    break;

                /* case NavigationTarget.LoanManagement:
                     // Assuming you have a LoanManagementControl
                     controlToLoad = new LoanManagementControl
                     {
                         Dock = DockStyle.Fill
                     };
                     break;

                 case NavigationTarget.ReservationManagement:
                     // Assuming you have a ReservationManagementControl
                     controlToLoad = new ReservationManagementControl
                     {
                         Dock = DockStyle.Fill
                     };
                     break;*/

                case NavigationTarget.MyInquiries:
                    // Assuming you have an InquiryManagementControl
                    controlToLoad = new MyInquiriesControl
                    {
                        Dock = DockStyle.Fill
                    };
                    break;

                case NavigationTarget.Borrow:
                    // Assuming you have an InquiryManagementControl
                    controlToLoad = new AddBorrowControl
                    {
                        Dock = DockStyle.Fill
                    };
                    break;

                case NavigationTarget.InquiryManagement:
                    // Assuming you have an InquiryManagementControl
                    controlToLoad = new InquiryManagementControl
                    {
                        Dock = DockStyle.Fill
                    };
                    break;

                // Add more cases as needed for other controls

                default:
                    MessageBox.Show($"Unknown navigation target: {target}", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if (controlToLoad != null)
            {
                parentForm.Controls.Clear();
                parentForm.Controls.Add(controlToLoad);
                controlToLoad.BringToFront();
            }
        }
    }
}
