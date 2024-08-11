namespace CustomerManagement
{
    public partial class MainForm : Form
    {
        private readonly RegisterCustomerForm registerCustomerForm;
        private readonly FetchCustomerForm fetchCustomerForm;

        public MainForm()
        {
            InitializeComponent();
            Database.CreateDatabaseIfNotExists();

            this.registerCustomerForm = new RegisterCustomerForm();
            this.fetchCustomerForm = new FetchCustomerForm();
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
