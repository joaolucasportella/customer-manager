namespace CustomerManagement
{
    public partial class MainForm : Form
    {
        private readonly Database database;
        private readonly RegisterCustomerForm registerCustomerForm;
        private readonly FetchCustomerForm fetchCustomerForm;

        public MainForm()
        {
            InitializeComponent();

            this.database = new Database();
            this.registerCustomerForm = new RegisterCustomerForm();
            this.fetchCustomerForm = new FetchCustomerForm();
        }

        private void MainLoad(object sender, EventArgs e)
        {
            // TODO: fetch sum of total customers and display to user.
        }

        private void RegisterCustomerClick(object sender, EventArgs e)
        {
            this.Hide();
            this.registerCustomerForm.ShowDialog();
            this.Show();
        }

        private void FetchCustomerClick(object sender, EventArgs e)
        {
            this.Hide();
            this.fetchCustomerForm.ShowDialog();
            this.Show();
        }
    }
}
