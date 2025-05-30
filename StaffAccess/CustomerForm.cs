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
    }
}
