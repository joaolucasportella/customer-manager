namespace CustomerManagement
{
    public partial class Main : Form
    {
        private readonly CustomerForm customerForm;
        private readonly Database database;

        public Main()
        {
            InitializeComponent();

            this.customerForm = new CustomerForm();
            this.database = new Database();
        }

        private void MainLoad(object sender, EventArgs e)
        {
            // TODO: fetch sum of total customers and display to user.
        }

        private void RegisterCustomerClick(object sender, EventArgs e)
        {
            this.Hide();
            this.customerForm.ShowDialog();
            this.Show();
        }
    }
}
