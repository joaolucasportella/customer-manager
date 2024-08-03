namespace CustomerManagement
{
    public partial class CustomerForm : Form
    {
        private readonly Database database;

        public CustomerForm()
        {
            InitializeComponent();

            this.database = new Database();
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
                this.database.InsertCustomer(
                    name: nameInput.Text,
                    rg: rgInput.Text,
                    cpf: cpfInput.Text,
                    address: addressInput.Text,
                    cep: cepInput.Text,
                    city: cityInput.Text,
                    email: emailInput.Text,
                    phone1: waInput.Text,
                    phone2: telInput.Text,
                    birthDate: birthDateInput.Text
                );
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
