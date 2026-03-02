namespace CustomerListApp
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 20);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(13, 49);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(35, 107);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(40, 78);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(85, 12);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(209, 23);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(85, 41);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(209, 23);
            txtLastName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(85, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(85, 99);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(209, 23);
            txtPhone.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(219, 128);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(138, 128);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 173);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhone;
        private Label lblEmail;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnSave;
        private Button btnCancel;
    }
}