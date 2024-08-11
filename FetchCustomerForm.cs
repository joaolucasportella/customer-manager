using System.Data;

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
            if (!searchBox.Visible)
            {
                return;
            }

            DataRow selectedRow = ((DataRowView)searchBox.SelectedItem).Row;

            try
            {
                Database.UpdateCustomerAndAnamnese(
                    id: Convert.ToInt16(selectedRow["customerId"].ToString()),
                    name: nameInput.Text,
                    rg: rgInput.Text,
                    cpf: cpfInput.Text,
                    address: addressInput.Text,
                    cep: cepInput.Text,
                    city: cityInput.Text,
                    email: emailInput.Text,
                    phone1: waInput.Text,
                    phone2: telInput.Text,
                    birthDate: birthDateInput.Text,
                    previousEstheticTreatment: anamnesePositiveInput1.Checked,
                    specifyPreviousEstheticTreatment: anamneseTextInput1.Text,
                    allergies: anamnesePositiveInput2.Checked,
                    specifyAllergies: anamneseTextInput2.Text,
                    regularIntestinalFunction: anamnesePositiveInput3.Checked,
                    specifyRegularIntestinalFunction: anamneseTextInput3.Text,
                    practiceSports: anamnesePositiveInput4.Checked,
                    specifyPracticeSports: anamneseTextInput4.Text,
                    balancedDiet: anamnesePositiveInput5.Checked,
                    specifyBalancedDiet: anamneseTextInput5.Text,
                    medicalTreatment: anamnesePositiveInput6.Checked,
                    specifyMedicalTreatment: anamneseTextInput6.Text,
                    useMedications: anamnesePositiveInput7.Checked,
                    specifyUseMedications: anamneseTextInput7.Text,
                    pacemaker: anamnesePositiveInput8.Checked,
                    specifyPacemaker: anamneseTextInput8.Text,
                    metalProstheses: anamnesePositiveInput9.Checked,
                    specifyMetalProstheses: anamneseTextInput9.Text,
                    heartProblems: anamnesePositiveInput10.Checked,
                    specifyHeartProblems: anamneseTextInput10.Text,
                    oncologicalHistory: anamnesePositiveInput11.Checked,
                    specifyOncologicalHistory: anamneseTextInput11.Text,
                    menstrualCycle: anamnesePositiveInput12.Checked,
                    specifyMenstrualCycle: anamneseTextInput12.Text,
                    contraceptiveMethod: anamnesePositiveInput13.Checked,
                    specifyContraceptiveMethod: anamneseTextInput13.Text,
                    dailyCareProducts: anamnesePositiveInput14.Checked,
                    specifyDailyCareProducts: anamneseTextInput14.Text,
                    pregnant: anamnesePositiveInput15.Checked,
                    hasChildren: anamnesePositiveInput16.Checked,
                    smoke: anamnesePositiveInput17.Checked,
                    epilepsy: anamnesePositiveInput18.Checked,
                    diabetes: anamnesePositiveInput19.Checked,
                    dentalProsthesis: anamnesePositiveInput20.Checked,
                    sunExposure: anamnesePositiveInput21.Checked,
                    hypertensive: anamnesePositiveInput22.Checked,
                    childrenQuantity: (int)anamneseIntegerInput1.Value
                );

                MessageBox.Show("Cliente atualizado com successo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    text: $"Erro ao tentar atualizar o cadastro! {ex.Message}",
                    caption: "Erro",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning
                );
            }
        }

        private void DeleteCustomerClick(object sender, EventArgs e)
        {
            if (!searchBox.Visible)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                text: $"Esta ação é irreversível! Você tem certeza de que deseja continuar?",
                caption: "Atenção",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }

            DataRow selectedRow = ((DataRowView)searchBox.SelectedItem).Row;

            try
            {
                Database.DeleteCustomerAndAnamnese(Convert.ToInt16(selectedRow["customerId"].ToString()));

                MessageBox.Show("Cliente removido com successo!");

                searchInput.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    text: $"Erro ao tentar remover o cadastro! {ex.Message}",
                    caption: "Erro",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning
                );
            }
        }

        private void SearchInputTextChanged(object sender, EventArgs e)
        {
            string filter = searchInput.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(filter))
            {
                DataView view = new DataView(Database.customersTable);
                view.RowFilter = $"name LIKE '%{filter}%'";

                searchBox.DataSource = view;
                searchBox.DisplayMember = "name";
                searchBox.ValueMember = "id";

                if (view.Count > 0)
                {
                    searchBox.Show();
                }
                else
                {
                    ClearInputs();
                }
            }
            else
            {
                searchBox.Hide();
                ClearInputs();
            }
        }

        private void SearchBoxSelectedIndexChanged(object sender, EventArgs e)
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

        private void ClearInputs()
        {
            nameInput.Clear();
            rgInput.Clear();
            cpfInput.Clear();
            addressInput.Clear();
            cepInput.Clear();
            cityInput.Clear();
            emailInput.Clear();
            waInput.Clear();
            telInput.Clear();
            birthDateInput.Value = DateTime.Now;
            anamneseNegativeInput1.Checked = true;
            anamneseTextInput1.Text = "";
            anamneseNegativeInput2.Checked = true;
            anamneseTextInput2.Text = "";
            anamneseNegativeInput3.Checked = true;
            anamneseTextInput3.Text = "";
            anamneseNegativeInput4.Checked = true;
            anamneseTextInput4.Text = "";
            anamneseNegativeInput5.Checked = true;
            anamneseTextInput5.Text = "";
            anamneseNegativeInput6.Checked = true;
            anamneseTextInput6.Text = "";
            anamneseNegativeInput7.Checked = true;
            anamneseTextInput7.Text = "";
            anamneseNegativeInput8.Checked = true;
            anamneseTextInput8.Text = "";
            anamneseNegativeInput9.Checked = true;
            anamneseTextInput9.Text = "";
            anamneseNegativeInput10.Checked = true;
            anamneseTextInput10.Text = "";
            anamneseNegativeInput11.Checked = true;
            anamneseTextInput11.Text = "";
            anamneseNegativeInput12.Checked = true;
            anamneseTextInput12.Text = "";
            anamneseNegativeInput13.Checked = true;
            anamneseTextInput13.Text = "";
            anamneseNegativeInput14.Checked = true;
            anamneseTextInput14.Text = "";
            anamneseNegativeInput15.Checked = true;
            anamneseNegativeInput16.Checked = true;
            anamneseNegativeInput17.Checked = true;
            anamneseNegativeInput18.Checked = true;
            anamneseNegativeInput19.Checked = true;
            anamneseNegativeInput20.Checked = true;
            anamneseNegativeInput21.Checked = true;
            anamneseNegativeInput22.Checked = true;
            anamneseIntegerInput1.Value = 0;
        }
    }
}
