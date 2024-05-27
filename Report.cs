using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using OfficeOpenXml;


namespace Activity4_Ver2
{
    public partial class Report : Form
    {
        private Dashboard dashboardForm;
        private MySqlConnection connection;
        private DataGridView dataGridView;

        public Report()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            CreateDataGridView();
            EmbedDataGridViewIntoPanel();
            HomeIcon.Click += HomeIcon_Click;
            HomeLbl.Click += HomeLbl_Click;
        }


        private void InitializeDatabaseConnection()
        {
            string connectionString = "Server=localhost;Port=3306;Database=merchshop;Uid=root;Pwd=denn;";
            connection = new MySqlConnection(connectionString);
        }

        private void CreateDataGridView()
        {
            dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            ReportPanel.Controls.Add(dataGridView); // Assuming ReportPanel is the name of your panel control
        }

        private void EmbedDataGridViewIntoPanel()
        {
            dataGridView.Parent = ReportPanel;
        }

        private void LoadDataFromView(string viewName)
        {
            try
            {
                string query = $"SELECT * FROM {viewName};";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Set the view name as an ExtendedProperty
                dataTable.ExtendedProperties.Add("ViewName", viewName);

                DisplayData(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayData(DataTable dataTable)
        {
            dataGridView.DataSource = dataTable;
        }

        private void LowStocksBtn_Click(object sender, EventArgs e)
        {
            LoadDataFromView("lowstockalert");
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            LoadDataFromView("salesin2024");
        }

        private void TopSellingBtn_Click(object sender, EventArgs e)
        {
            LoadDataFromView("topsellingproducts");
        }

        private void GenReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)dataGridView.DataSource;

                // Set license context to non-commercial to avoid license check
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                string templatePath = @"C:\Users\DELL\OneDrive\Documents\3RD YEAR\2nd Sem\EDP\template.xlsx";
                string savePath = GetSavePath(); // Get the save path based on the view name

                using (var templatePackage = new ExcelPackage(new FileInfo(templatePath)))
                {
                    // Access the worksheet in the template
                    var worksheet = templatePackage.Workbook.Worksheets["Sheet1"];

                    // Insert DataTable into worksheet starting at cell A17
                    worksheet.Cells["A17"].LoadFromDataTable(dataTable, true);

                    // Save the modified Excel file
                    templatePackage.SaveAs(new FileInfo(savePath));

                    MessageBox.Show("Excel file generated successfully at: " + savePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Excel file: " + ex.Message);
            }
        }

        private string GetViewName(DataTable dataTable)
        {
            // Determine the view name based on the data loaded into the panel
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Check the columns or other criteria to determine the view name
                // For simplicity, let's assume the view name is based on the first row of data
                string firstColumnValue = dataTable.Rows[0][0].ToString(); // Assuming the first column contains the view name
                return firstColumnValue; // You may need to adjust this based on your actual data
            }

            // Default to "Report" if no data is loaded into the panel
            return "Report";
        }

        private string GetSavePath()
        {
            string baseDirectory = @"C:\Users\DELL\OneDrive\Desktop"; // Base directory for saving files
            // Retrieve the view name from the DataTable's ExtendedProperties
            string viewName = dataGridView.DataSource != null ?
                              ((DataTable)dataGridView.DataSource).ExtendedProperties["ViewName"].ToString() :
                              "Report";
            string filename = $"{viewName}_Report.xlsx"; // Construct filename based on view name

            // Combine base directory and filename to get the full save path
            string savePath = Path.Combine(baseDirectory, filename);

            return savePath;
        }

        public Report(Dashboard dashboardForm) : this()
        {
            this.dashboardForm = dashboardForm;
        }

        private async void HomeIcon_Click(object sender, EventArgs e)
        {
            await TransitionToDashboardForm();
        }

        private async void HomeLbl_Click(object sender, EventArgs e)
        {
            await TransitionToDashboardForm();
        }

        private async Task TransitionToDashboardForm()
        {
            if (dashboardForm == null || dashboardForm.IsDisposed)
            {
                dashboardForm = new Dashboard();
                dashboardForm.FormClosed += DashboardForm_FormClosed;
            }

            if (dashboardForm.Visible)
                return;

            dashboardForm.Opacity = 0;

            if (this.Opacity > 0)
                await FadeOut(this);

            this.Hide();
            dashboardForm.Show();
            await FadeIn(dashboardForm);
        }

        private async Task FadeOut(Form form)
        {
            while (form.Opacity > 0)
            {
                await Task.Delay(10);
                form.Opacity -= 0.05;
            }
        }

        private async Task FadeIn(Form form)
        {
            while (form.Opacity < 1)
            {
                await Task.Delay(10);
                form.Opacity += 0.05;
            }
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboardForm.Dispose();
            this.Show();
        }
        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
