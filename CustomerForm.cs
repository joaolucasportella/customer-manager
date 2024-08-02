using ClosedXML.Excel;

namespace CustomerManagement
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerFormLoad(object sender, EventArgs e)
        {

        }

        private void ReturnToHomePageClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterCustomerClick(object sender, EventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook(Constants.DataFilePath))
                {
                    var worksheet = workbook.Worksheet("Clientes");
                    var lastRow = worksheet.LastRowUsed().RowNumber();
                    var newRow = lastRow + 1;
                    var customerId = lastRow - 1;

                    worksheet.Cell(newRow, 1).Value = customerId;
                    worksheet.Cell(newRow, 2).Value = nameInput.Text;
                    worksheet.Cell(newRow, 3).Value = rgInput.Text;
                    worksheet.Cell(newRow, 4).Value = cpfInput.Text;
                    worksheet.Cell(newRow, 5).Value = birthDateInput.Value.ToShortDateString();
                    worksheet.Cell(newRow, 6).Value = addressInput.Text;
                    worksheet.Cell(newRow, 7).Value = cepInput.Text;
                    worksheet.Cell(newRow, 8).Value = cityInput.Text;
                    worksheet.Cell(newRow, 9).Value = emailInput.Text;
                    worksheet.Cell(newRow, 10).Value = waInput.Text;
                    worksheet.Cell(newRow, 11).Value = telInput.Text;

                    workbook.Save();
                }

                MessageBox.Show("Cadastro feito com sucesso!");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show($"Erro ao tentar realizar o cadastro. Verifique se o arquivo {Constants.DataFilePath} não está aberto e tente novamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar realizar o cadastro! {ex.Message}");
            }
            finally
            {
                this.ClearInputs();
            }
        }

        private void ClearInputs()
        {
            nameInput.Clear();
            rgInput.Clear();
            cpfInput.Clear();
            birthDateInput.Value = DateTime.Now;
            addressInput.Clear();
            cepInput.Clear();
            cityInput.Clear();
            emailInput.Clear();
            waInput.Clear();
            telInput.Clear();
        }
    }
}
