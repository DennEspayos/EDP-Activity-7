using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4_Ver2
{
        public partial class Dashboard : Form
        {
            private Admin AdminForm;
            private Report ReportForm;


        public Dashboard()
            {
                InitializeComponent();
                AdminIconBtn.Click += AdminIconBtn_Click;
                ReportIconBtn.Click += ReportIconBtn_Click;


        }

        private void AdminIconBtn_Click(object sender, EventArgs e)
            {
                this.Hide();

                // Check if the Admin form is already open
                Admin adminForm = Application.OpenForms.OfType<Admin>().FirstOrDefault();

                if (adminForm != null)
                {
                    // If the Admin form is open, bring it to the front
                    adminForm.Show();
                }
                else
                {
                    // If the Admin form is not open, create and show a new instance
                    Admin newAdminForm = new Admin();
                    newAdminForm.Show();
                }
            }

            private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
            {
                // Show the DashboardForm when AdminForm is closed
                this.Show();
            }

        private void ReportIconBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Check if the Report form is already open
            ReportForm = Application.OpenForms.OfType<Report>().FirstOrDefault();

            if (ReportForm != null)
            {
                // If the Report form is open, bring it to the front
                ReportForm.Show();
            }
            else
            {
                // If the Report form is not open, create and show a new instance
                ReportForm = new Report();
                ReportForm.FormClosed += ReportForm_FormClosed; // Handle the FormClosed event
                ReportForm.Show();
            }
        }

        private void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the DashboardForm when ReportForm is closed
            this.Show();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
            {

            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void panel2_Paint(object sender, PaintEventArgs e)
            {

            }
        }
    }
