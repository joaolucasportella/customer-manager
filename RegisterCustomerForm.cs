namespace CustomerManagement
{
    public partial class RegisterCustomerForm : Form
    {
        public RegisterCustomerForm()
        {
            InitializeComponent();
        }

        private void ReturnToHomePageClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterCustomerClick(object sender, EventArgs e)
        {
            try
            {
                Database.InsertCustomerAndAnamnese(
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

                MessageBox.Show("Cliente cadastrado com successo!");
                this.ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar realizar o cadastro! {ex.Message}");
            }
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
