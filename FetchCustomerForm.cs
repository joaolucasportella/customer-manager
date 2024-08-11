using System.Data;
using System.Windows.Forms;

namespace CustomerManagement
{
    public partial class FetchCustomerForm : Form
    {
        public FetchCustomerForm()
        {
            InitializeComponent();
            searchBox.Hide();
        }

        private void ReturnToHomePageClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateCustomerClick(object sender, EventArgs e)
        {

        }

        private void DeleteCustomerClick(object sender, EventArgs e)
        {

        }

        private void searchInputTextChanged(object sender, EventArgs e)
        {
            string filter = searchInput.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(filter))
            {
                DataView view = new DataView(Database.customersTable);
                view.RowFilter = $"name LIKE '%{filter}%'";

                searchBox.DataSource = view;
                searchBox.DisplayMember = "name";
                searchBox.ValueMember = "id";
                searchBox.Show();
            }
            else
            {
                searchBox.Hide();
            }
        }

        private void searchBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow selectedRow = ((DataRowView)searchBox.SelectedItem).Row;

            nameInput.Text = selectedRow["name"].ToString();
            rgInput.Text = selectedRow["rg"].ToString();
            cpfInput.Text = selectedRow["cpf"].ToString();
            addressInput.Text = selectedRow["address"].ToString();
            cepInput.Text = selectedRow["cep"].ToString();
            cityInput.Text = selectedRow["city"].ToString();
            emailInput.Text = selectedRow["email"].ToString();
            waInput.Text = selectedRow["phone1"].ToString();
            telInput.Text = selectedRow["phone2"].ToString();
            birthDateInput.Text = selectedRow["birthDate"].ToString();
        }
    }
}
