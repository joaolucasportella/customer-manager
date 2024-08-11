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

            anamnesePositiveInput1.Checked = Convert.ToBoolean(selectedRow["previousEstheticTreatment"].ToString());
            anamneseNegativeInput1.Checked = !Convert.ToBoolean(selectedRow["previousEstheticTreatment"].ToString());
            anamneseTextInput1.Text = selectedRow["specifyPreviousEstheticTreatment"].ToString();

            anamnesePositiveInput2.Checked = Convert.ToBoolean(selectedRow["allergies"].ToString());
            anamneseNegativeInput2.Checked = !Convert.ToBoolean(selectedRow["allergies"].ToString());
            anamneseTextInput2.Text = selectedRow["specifyAllergies"].ToString();

            anamnesePositiveInput3.Checked = Convert.ToBoolean(selectedRow["regularIntestinalFunction"].ToString());
            anamneseNegativeInput3.Checked = !Convert.ToBoolean(selectedRow["regularIntestinalFunction"].ToString());
            anamneseTextInput3.Text = selectedRow["specifyRegularIntestinalFunction"].ToString();

            anamnesePositiveInput4.Checked = Convert.ToBoolean(selectedRow["practiceSports"].ToString());
            anamneseNegativeInput4.Checked = !Convert.ToBoolean(selectedRow["practiceSports"].ToString());
            anamneseTextInput4.Text = selectedRow["specifyPracticeSports"].ToString();

            anamnesePositiveInput5.Checked = Convert.ToBoolean(selectedRow["balancedDiet"].ToString());
            anamneseNegativeInput5.Checked = !Convert.ToBoolean(selectedRow["balancedDiet"].ToString());
            anamneseTextInput5.Text = selectedRow["specifyBalancedDiet"].ToString();

            anamnesePositiveInput6.Checked = Convert.ToBoolean(selectedRow["medicalTreatment"].ToString());
            anamneseNegativeInput6.Checked = !Convert.ToBoolean(selectedRow["medicalTreatment"].ToString());
            anamneseTextInput6.Text = selectedRow["specifyMedicalTreatment"].ToString();

            anamnesePositiveInput7.Checked = Convert.ToBoolean(selectedRow["useMedications"].ToString());
            anamneseNegativeInput7.Checked = !Convert.ToBoolean(selectedRow["useMedications"].ToString());
            anamneseTextInput7.Text = selectedRow["specifyUseMedications"].ToString();

            anamnesePositiveInput8.Checked = Convert.ToBoolean(selectedRow["pacemaker"].ToString());
            anamneseNegativeInput8.Checked = !Convert.ToBoolean(selectedRow["pacemaker"].ToString());
            anamneseTextInput8.Text = selectedRow["specifyPacemaker"].ToString();

            anamnesePositiveInput9.Checked = Convert.ToBoolean(selectedRow["metalProstheses"].ToString());
            anamneseNegativeInput9.Checked = !Convert.ToBoolean(selectedRow["metalProstheses"].ToString());
            anamneseTextInput9.Text = selectedRow["specifyMetalProstheses"].ToString();

            anamnesePositiveInput10.Checked = Convert.ToBoolean(selectedRow["heartProblems"].ToString());
            anamneseNegativeInput10.Checked = !Convert.ToBoolean(selectedRow["heartProblems"].ToString());
            anamneseTextInput10.Text = selectedRow["specifyHeartProblems"].ToString();

            anamnesePositiveInput11.Checked = Convert.ToBoolean(selectedRow["oncologicalHistory"].ToString());
            anamneseNegativeInput11.Checked = !Convert.ToBoolean(selectedRow["oncologicalHistory"].ToString());
            anamneseTextInput11.Text = selectedRow["specifyOncologicalHistory"].ToString();

            anamnesePositiveInput12.Checked = Convert.ToBoolean(selectedRow["menstrualCycle"].ToString());
            anamneseNegativeInput12.Checked = !Convert.ToBoolean(selectedRow["menstrualCycle"].ToString());
            anamneseTextInput12.Text = selectedRow["specifyMenstrualCycle"].ToString();

            anamnesePositiveInput13.Checked = Convert.ToBoolean(selectedRow["contraceptiveMethod"].ToString());
            anamneseNegativeInput13.Checked = !Convert.ToBoolean(selectedRow["contraceptiveMethod"].ToString());
            anamneseTextInput13.Text = selectedRow["specifyContraceptiveMethod"].ToString();

            anamnesePositiveInput14.Checked = Convert.ToBoolean(selectedRow["dailyCareProducts"].ToString());
            anamneseNegativeInput14.Checked = !Convert.ToBoolean(selectedRow["dailyCareProducts"].ToString());
            anamneseTextInput14.Text = selectedRow["specifyDailyCareProducts"].ToString();

            anamnesePositiveInput15.Checked = Convert.ToBoolean(selectedRow["pregnant"].ToString());
            anamneseNegativeInput15.Checked = !Convert.ToBoolean(selectedRow["pregnant"].ToString());

            anamnesePositiveInput16.Checked = Convert.ToBoolean(selectedRow["hasChildren"].ToString());
            anamneseNegativeInput16.Checked = !Convert.ToBoolean(selectedRow["hasChildren"].ToString());

            anamneseIntegerInput1.Value = Convert.ToInt16(selectedRow["childrenQuantity"].ToString());

            anamnesePositiveInput17.Checked = Convert.ToBoolean(selectedRow["smoke"].ToString());
            anamneseNegativeInput17.Checked = !Convert.ToBoolean(selectedRow["smoke"].ToString());

            anamnesePositiveInput18.Checked = Convert.ToBoolean(selectedRow["epilepsy"].ToString());
            anamneseNegativeInput18.Checked = !Convert.ToBoolean(selectedRow["epilepsy"].ToString());

            anamnesePositiveInput19.Checked = Convert.ToBoolean(selectedRow["diabetes"].ToString());
            anamneseNegativeInput19.Checked = !Convert.ToBoolean(selectedRow["diabetes"].ToString());

            anamnesePositiveInput20.Checked = Convert.ToBoolean(selectedRow["dentalProsthesis"].ToString());
            anamneseNegativeInput20.Checked = !Convert.ToBoolean(selectedRow["dentalProsthesis"].ToString());

            anamnesePositiveInput21.Checked = Convert.ToBoolean(selectedRow["sunExposure"].ToString());
            anamneseNegativeInput21.Checked = !Convert.ToBoolean(selectedRow["sunExposure"].ToString());

            anamnesePositiveInput22.Checked = Convert.ToBoolean(selectedRow["hypertensive"].ToString());
            anamneseNegativeInput22.Checked = !Convert.ToBoolean(selectedRow["hypertensive"].ToString());
        }
    }
}
