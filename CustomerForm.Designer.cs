namespace CustomerManagement
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            TitleLabel = new Label();
            FirstCategoryLabel = new Label();
            nameLabel = new Label();
            rgLabel = new Label();
            nameInput = new TextBox();
            birthDateLabel = new Label();
            birthDateInput = new DateTimePicker();
            addressLabel = new Label();
            addressInput = new TextBox();
            cepLabel = new Label();
            cepInput = new TextBox();
            cityLabel = new Label();
            cityInput = new TextBox();
            emailLabel = new Label();
            emailInput = new TextBox();
            waLabel = new Label();
            waInput = new TextBox();
            telLabel = new Label();
            telInput = new TextBox();
            cpfLabel = new Label();
            cpfInput = new TextBox();
            rgInput = new TextBox();
            ReturnToHomePage = new Button();
            RegisterCustomer = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TitleLabel.Location = new Point(25, 20);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(162, 32);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Novo Cliente";
            // 
            // FirstCategoryLabel
            // 
            FirstCategoryLabel.AutoSize = true;
            FirstCategoryLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            FirstCategoryLabel.Location = new Point(25, 65);
            FirstCategoryLabel.Name = "FirstCategoryLabel";
            FirstCategoryLabel.Size = new Size(185, 25);
            FirstCategoryLabel.TabIndex = 1;
            FirstCategoryLabel.Text = "Informações Básicas";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(33, 115);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(43, 15);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Nome:";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Location = new Point(33, 145);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new Size(25, 15);
            rgLabel.TabIndex = 4;
            rgLabel.Text = "RG:";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(118, 110);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(200, 23);
            nameInput.TabIndex = 3;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(33, 205);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(117, 15);
            birthDateLabel.TabIndex = 8;
            birthDateLabel.Text = "Data de Nascimento:";
            // 
            // birthDateInput
            // 
            birthDateInput.Format = DateTimePickerFormat.Short;
            birthDateInput.Location = new Point(168, 200);
            birthDateInput.Name = "birthDateInput";
            birthDateInput.Size = new Size(150, 23);
            birthDateInput.TabIndex = 9;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(33, 240);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(59, 15);
            addressLabel.TabIndex = 10;
            addressLabel.Text = "Endereço:";
            // 
            // addressInput
            // 
            addressInput.Location = new Point(118, 235);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(200, 23);
            addressInput.TabIndex = 11;
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new Point(33, 275);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new Size(31, 15);
            cepLabel.TabIndex = 12;
            cepLabel.Text = "CEP:";
            // 
            // cepInput
            // 
            cepInput.Location = new Point(118, 270);
            cepInput.Name = "cepInput";
            cepInput.Size = new Size(200, 23);
            cepInput.TabIndex = 13;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(33, 305);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(47, 15);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "Cidade:";
            // 
            // cityInput
            // 
            cityInput.Location = new Point(118, 300);
            cityInput.Name = "cityInput";
            cityInput.Size = new Size(200, 23);
            cityInput.TabIndex = 15;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(33, 335);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(44, 15);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "E-mail:";
            // 
            // emailInput
            // 
            emailInput.Location = new Point(118, 330);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(200, 23);
            emailInput.TabIndex = 17;
            // 
            // waLabel
            // 
            waLabel.AutoSize = true;
            waLabel.Location = new Point(33, 365);
            waLabel.Name = "waLabel";
            waLabel.Size = new Size(65, 15);
            waLabel.TabIndex = 18;
            waLabel.Text = "WhatsApp:";
            // 
            // waInput
            // 
            waInput.Location = new Point(118, 360);
            waInput.Name = "waInput";
            waInput.Size = new Size(200, 23);
            waInput.TabIndex = 19;
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new Point(33, 395);
            telLabel.Name = "telLabel";
            telLabel.Size = new Size(79, 15);
            telLabel.TabIndex = 20;
            telLabel.Text = "Telefone Fixo:";
            // 
            // telInput
            // 
            telInput.Location = new Point(118, 390);
            telInput.Name = "telInput";
            telInput.Size = new Size(200, 23);
            telInput.TabIndex = 21;
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new Point(33, 175);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new Size(31, 15);
            cpfLabel.TabIndex = 6;
            cpfLabel.Text = "CPF:";
            // 
            // cpfInput
            // 
            cpfInput.Location = new Point(118, 170);
            cpfInput.Name = "cpfInput";
            cpfInput.Size = new Size(200, 23);
            cpfInput.TabIndex = 7;
            // 
            // rgInput
            // 
            rgInput.Location = new Point(118, 140);
            rgInput.Name = "rgInput";
            rgInput.Size = new Size(200, 23);
            rgInput.TabIndex = 5;
            // 
            // ReturnToHomePage
            // 
            ReturnToHomePage.BackColor = Color.FromArgb(52, 152, 219);
            ReturnToHomePage.FlatAppearance.BorderSize = 0;
            ReturnToHomePage.FlatStyle = FlatStyle.Flat;
            ReturnToHomePage.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ReturnToHomePage.ForeColor = Color.White;
            ReturnToHomePage.Location = new Point(33, 445);
            ReturnToHomePage.Name = "ReturnToHomePage";
            ReturnToHomePage.Size = new Size(100, 54);
            ReturnToHomePage.TabIndex = 22;
            ReturnToHomePage.Text = "Voltar";
            ReturnToHomePage.UseVisualStyleBackColor = false;
            ReturnToHomePage.Click += ReturnToHomePageClick;
            // 
            // RegisterCustomer
            // 
            RegisterCustomer.BackColor = Color.FromArgb(46, 204, 113);
            RegisterCustomer.FlatAppearance.BorderSize = 0;
            RegisterCustomer.FlatStyle = FlatStyle.Flat;
            RegisterCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            RegisterCustomer.ForeColor = Color.White;
            RegisterCustomer.Location = new Point(406, 445);
            RegisterCustomer.Name = "RegisterCustomer";
            RegisterCustomer.Size = new Size(150, 54);
            RegisterCustomer.TabIndex = 23;
            RegisterCustomer.Text = "Finalizar Cadastro";
            RegisterCustomer.UseVisualStyleBackColor = false;
            RegisterCustomer.Click += RegisterCustomerClick;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(584, 511);
            Controls.Add(RegisterCustomer);
            Controls.Add(ReturnToHomePage);
            Controls.Add(telInput);
            Controls.Add(telLabel);
            Controls.Add(waInput);
            Controls.Add(waLabel);
            Controls.Add(emailInput);
            Controls.Add(emailLabel);
            Controls.Add(cityInput);
            Controls.Add(cityLabel);
            Controls.Add(cepInput);
            Controls.Add(cepLabel);
            Controls.Add(addressInput);
            Controls.Add(addressLabel);
            Controls.Add(birthDateInput);
            Controls.Add(birthDateLabel);
            Controls.Add(cpfInput);
            Controls.Add(cpfLabel);
            Controls.Add(rgInput);
            Controls.Add(rgLabel);
            Controls.Add(nameInput);
            Controls.Add(nameLabel);
            Controls.Add(FirstCategoryLabel);
            Controls.Add(TitleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CustomerForm";
            Text = "Cadastro de Cliente";
            Load += CustomerFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label FirstCategoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label rgLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.DateTimePicker birthDateInput;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label cepLabel;
        private System.Windows.Forms.TextBox cepInput;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label waLabel;
        private System.Windows.Forms.TextBox waInput;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.TextBox telInput;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.TextBox cpfInput;
        private System.Windows.Forms.TextBox rgInput;
        private System.Windows.Forms.Button ReturnToHomePage;
        private System.Windows.Forms.Button RegisterCustomer;
    }
}
