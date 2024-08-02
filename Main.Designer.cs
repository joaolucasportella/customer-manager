using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomerManagement
{
    partial class Main : Form
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
            RegisterCustomer = new Button();
            label1 = new Label();
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
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(114, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 45);
            label1.TabIndex = 1;
            label1.Text = "Gerenciador de Clientes";
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
            //
            // Main
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(584, 254);
            Controls.Add(FetchCustomer);
            Controls.Add(label1);
            Controls.Add(RegisterCustomer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            Text = "Gerenciador de Clientes";
            Load += MainLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button RegisterCustomer;
        private Label label1;
        private Button FetchCustomer;
    }
}
