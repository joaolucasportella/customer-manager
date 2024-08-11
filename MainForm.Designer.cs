namespace CustomerManagement
{
    partial class MainForm : Form
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            RegisterCustomer = new Button();
            mainTitle = new Label();
            FetchCustomer = new Button();
            SuspendLayout();
            //
            // RegisterCustomer
            //
            RegisterCustomer.BackColor = Color.FromArgb(52, 152, 219);
            RegisterCustomer.FlatAppearance.BorderSize = 0;
            RegisterCustomer.FlatStyle = FlatStyle.Flat;
            RegisterCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            RegisterCustomer.ForeColor = Color.White;
            RegisterCustomer.Location = new Point(200, 100);
            RegisterCustomer.Name = "RegisterCustomer";
            RegisterCustomer.Size = new Size(180, 40);
            RegisterCustomer.TabIndex = 0;
            RegisterCustomer.Text = "Cadastrar Cliente";
            RegisterCustomer.UseVisualStyleBackColor = false;
            RegisterCustomer.Click += RegisterCustomerClick;
            //
            // mainTitle
            //
            mainTitle.AutoSize = true;
            mainTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            mainTitle.ForeColor = Color.FromArgb(44, 62, 80);
            mainTitle.Location = new Point(114, 18);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(375, 45);
            mainTitle.TabIndex = 1;
            mainTitle.Text = "Gerenciador de Clientes";
            //
            // FetchCustomer
            //
            FetchCustomer.BackColor = Color.FromArgb(46, 204, 113);
            FetchCustomer.FlatAppearance.BorderSize = 0;
            FetchCustomer.FlatStyle = FlatStyle.Flat;
            FetchCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FetchCustomer.ForeColor = Color.White;
            FetchCustomer.Location = new Point(200, 160);
            FetchCustomer.Name = "FetchCustomer";
            FetchCustomer.Size = new Size(180, 40);
            FetchCustomer.TabIndex = 2;
            FetchCustomer.Text = "Consultar Cliente";
            FetchCustomer.UseVisualStyleBackColor = false;
            FetchCustomer.Click += FetchCustomerClick;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(584, 254);
            Controls.Add(FetchCustomer);
            Controls.Add(mainTitle);
            Controls.Add(RegisterCustomer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button RegisterCustomer;
        private Label mainTitle;
        private Button FetchCustomer;
    }
}
