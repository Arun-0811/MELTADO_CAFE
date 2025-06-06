using MELTADO_CAFE.StaffAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MELTADO_CAFE
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        private Form activeForm = null;

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close(); // Close the currently active form
            }

            activeForm = childForm; // Set the new active form
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(childForm);
            PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void btnOrderProcessing_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOrderProcessing(), sender);
            
        }

        private void btnTableReservation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TableReservationForm(), sender);
            
        }

        private void btnInventoryManagment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InventoryManagementForm(), sender);
            
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FeedbackForm(), sender);
            
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btnCustomerDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerDashboardForm(), sender);
            
        }

        private void btnCusDetails_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerManagmentByStaff(), sender);
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
            this.Close();
        }
    }
}
