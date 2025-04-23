namespace DA204E_Assignment5
{
    partial class ContactForm
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
            grpName = new GroupBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            groupBox1 = new GroupBox();
            lblEmailPrivate = new Label();
            txtEmailPrivate = new TextBox();
            lblEmailBusiness = new Label();
            txtEmailBusiness = new TextBox();
            lblCellPhone = new Label();
            txtCellPhone = new TextBox();
            lblHomePhone = new Label();
            txtHomePhone = new TextBox();
            groupBox2 = new GroupBox();
            lblCountry = new Label();
            lblZipCode = new Label();
            txtZipCode = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblStreet = new Label();
            txtStreet = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            cmbCountry = new ComboBox();
            grpName.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // grpName
            // 
            grpName.Controls.Add(lblLastName);
            grpName.Controls.Add(txtLastName);
            grpName.Controls.Add(lblFirstName);
            grpName.Controls.Add(txtFirstName);
            grpName.Location = new Point(12, 12);
            grpName.Name = "grpName";
            grpName.Size = new Size(567, 87);
            grpName.TabIndex = 0;
            grpName.TabStop = false;
            grpName.Text = "Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(66, 48);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(61, 15);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(133, 48);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(403, 23);
            txtLastName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(65, 22);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(62, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(133, 19);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(403, 23);
            txtFirstName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblEmailPrivate);
            groupBox1.Controls.Add(txtEmailPrivate);
            groupBox1.Controls.Add(lblEmailBusiness);
            groupBox1.Controls.Add(txtEmailBusiness);
            groupBox1.Controls.Add(lblCellPhone);
            groupBox1.Controls.Add(txtCellPhone);
            groupBox1.Controls.Add(lblHomePhone);
            groupBox1.Controls.Add(txtHomePhone);
            groupBox1.Location = new Point(12, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 176);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Email and Phone";
            // 
            // lblEmailPrivate
            // 
            lblEmailPrivate.AutoSize = true;
            lblEmailPrivate.Location = new Point(44, 124);
            lblEmailPrivate.Name = "lblEmailPrivate";
            lblEmailPrivate.Size = new Size(83, 15);
            lblEmailPrivate.TabIndex = 7;
            lblEmailPrivate.Text = "E-mail, private";
            // 
            // txtEmailPrivate
            // 
            txtEmailPrivate.Location = new Point(133, 121);
            txtEmailPrivate.Name = "txtEmailPrivate";
            txtEmailPrivate.Size = new Size(403, 23);
            txtEmailPrivate.TabIndex = 6;
            // 
            // lblEmailBusiness
            // 
            lblEmailBusiness.AutoSize = true;
            lblEmailBusiness.Location = new Point(35, 95);
            lblEmailBusiness.Name = "lblEmailBusiness";
            lblEmailBusiness.Size = new Size(92, 15);
            lblEmailBusiness.TabIndex = 5;
            lblEmailBusiness.Text = "E-mail, business";
            // 
            // txtEmailBusiness
            // 
            txtEmailBusiness.Location = new Point(133, 92);
            txtEmailBusiness.Name = "txtEmailBusiness";
            txtEmailBusiness.Size = new Size(403, 23);
            txtEmailBusiness.TabIndex = 4;
            // 
            // lblCellPhone
            // 
            lblCellPhone.AutoSize = true;
            lblCellPhone.Location = new Point(63, 51);
            lblCellPhone.Name = "lblCellPhone";
            lblCellPhone.Size = new Size(64, 15);
            lblCellPhone.TabIndex = 3;
            lblCellPhone.Text = "Cell phone";
            // 
            // txtCellPhone
            // 
            txtCellPhone.Location = new Point(133, 48);
            txtCellPhone.Name = "txtCellPhone";
            txtCellPhone.Size = new Size(403, 23);
            txtCellPhone.TabIndex = 2;
            // 
            // lblHomePhone
            // 
            lblHomePhone.AutoSize = true;
            lblHomePhone.Location = new Point(50, 22);
            lblHomePhone.Name = "lblHomePhone";
            lblHomePhone.Size = new Size(77, 15);
            lblHomePhone.TabIndex = 1;
            lblHomePhone.Text = "Home phone";
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(133, 19);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(403, 23);
            txtHomePhone.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbCountry);
            groupBox2.Controls.Add(lblCountry);
            groupBox2.Controls.Add(lblZipCode);
            groupBox2.Controls.Add(txtZipCode);
            groupBox2.Controls.Add(lblCity);
            groupBox2.Controls.Add(txtCity);
            groupBox2.Controls.Add(lblStreet);
            groupBox2.Controls.Add(txtStreet);
            groupBox2.Location = new Point(12, 287);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(567, 176);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Address";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(77, 124);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 15);
            lblCountry.TabIndex = 7;
            lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(74, 95);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(53, 15);
            lblZipCode.TabIndex = 5;
            lblZipCode.Text = "Zip code";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(133, 92);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(403, 23);
            txtZipCode.TabIndex = 4;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(99, 51);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 3;
            lblCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(133, 48);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(403, 23);
            txtCity.TabIndex = 2;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(90, 22);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(37, 15);
            lblStreet.TabIndex = 1;
            lblStreet.Text = "Street";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(133, 19);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(403, 23);
            txtStreet.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(173, 487);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(109, 23);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(303, 487);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbCountry
            // 
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(133, 121);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(403, 23);
            cmbCountry.TabIndex = 8;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 525);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpName);
            Name = "ContactForm";
            Text = "ContactForm";
            grpName.ResumeLayout(false);
            grpName.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private GroupBox groupBox1;
        private Label lblCellPhone;
        private TextBox txtCellPhone;
        private Label lblHomePhone;
        private TextBox txtHomePhone;
        private Label lblEmailPrivate;
        private TextBox txtEmailPrivate;
        private Label lblEmailBusiness;
        private TextBox txtEmailBusiness;
        private GroupBox groupBox2;
        private Label lblCountry;
        private Label lblZipCode;
        private TextBox txtZipCode;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblStreet;
        private TextBox txtStreet;
        private Button btnOK;
        private Button btnCancel;
        private ComboBox cmbCountry;
    }
}