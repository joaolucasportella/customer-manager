using ClosedXML.Excel;

namespace CustomerManagement
{
    public partial class Main : Form
    {

        private readonly CustomerForm customerForm;

        public Main()
        {
            InitializeComponent();

            this.customerForm = new CustomerForm();
        }

        private void MainLoad(object sender, EventArgs e)
        {
            CreateDataDirectory();
            CreateDataFile();
        }

        private void CreateDataDirectory()
        {
            try
            {
                if (!Directory.Exists(Constants.DataDirectoryPath))
                {
                    Directory.CreateDirectory(Constants.DataDirectoryPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating DATA directory: {ex.Message}");
            }
        }

        private void CreateDataFile()
        {
            try
            {
                if (!File.Exists(Constants.DataFilePath))
                {
                    using (var workbook = new XLWorkbook())
                    {
                        foreach (var sheet in Constants.worksheetsMapping)
                        {
                            var worksheet = workbook.Worksheets.Add(sheet.Key);

                            for (int i = 0; i < sheet.Value.Length; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = sheet.Value[i];
                            }
                        }

                        workbook.SaveAs(Constants.DataFilePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating DATA directory: {ex.Message}");
            }
        }

        private void RegisterCustomerClick(object sender, EventArgs e)
        {
            this.Hide();
            this.customerForm.ShowDialog();
            this.Show();
        }
    }
}
