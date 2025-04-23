namespace DA204E_Assignment5
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstCustomerRegistry = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblId = new Label();
            lblName = new Label();
            lblOfficePhone = new Label();
            lblOfficeEMail = new Label();
            lblContactDetails = new Label();
            rtxtContactDetails = new RichTextBox();
            SuspendLayout();
            // 
            // lstCustomerRegistry
            // 
            lstCustomerRegistry.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCustomerRegistry.FormattingEnabled = true;
            lstCustomerRegistry.ItemHeight = 15;
            lstCustomerRegistry.Location = new Point(12, 48);
            lstCustomerRegistry.Name = "lstCustomerRegistry";
            lstCustomerRegistry.Size = new Size(618, 304);
            lstCustomerRegistry.TabIndex = 0;
            lstCustomerRegistry.SelectedIndexChanged += lstCustomerRegistry_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(11, 369);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 37);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(248, 369);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(151, 37);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(478, 369);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 37);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(17, 21);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 5;
            lblId.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(41, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(156, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Name (Surname, first name)";
            // 
            // lblOfficePhone
            // 
            lblOfficePhone.AutoSize = true;
            lblOfficePhone.Location = new Point(225, 21);
            lblOfficePhone.Name = "lblOfficePhone";
            lblOfficePhone.Size = new Size(76, 15);
            lblOfficePhone.TabIndex = 7;
            lblOfficePhone.Text = "Office Phone";
            // 
            // lblOfficeEMail
            // 
            lblOfficeEMail.AutoSize = true;
            lblOfficeEMail.Location = new Point(363, 21);
            lblOfficeEMail.Name = "lblOfficeEMail";
            lblOfficeEMail.Size = new Size(76, 15);
            lblOfficeEMail.TabIndex = 8;
            lblOfficeEMail.Text = "Office E-Mail";
            // 
            // lblContactDetails
            // 
            lblContactDetails.AutoSize = true;
            lblContactDetails.Location = new Point(636, 21);
            lblContactDetails.Name = "lblContactDetails";
            lblContactDetails.Size = new Size(87, 15);
            lblContactDetails.TabIndex = 9;
            lblContactDetails.Text = "Contact Details";
            // 
            // rtxtContactDetails
            // 
            rtxtContactDetails.BorderStyle = BorderStyle.FixedSingle;
            rtxtContactDetails.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtContactDetails.ForeColor = Color.SteelBlue;
            rtxtContactDetails.Location = new Point(636, 48);
            rtxtContactDetails.Name = "rtxtContactDetails";
            rtxtContactDetails.ReadOnly = true;
            rtxtContactDetails.Size = new Size(303, 304);
            rtxtContactDetails.TabIndex = 10;
            rtxtContactDetails.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 422);
            Controls.Add(rtxtContactDetails);
            Controls.Add(lblContactDetails);
            Controls.Add(lblOfficeEMail);
            Controls.Add(lblOfficePhone);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lstCustomerRegistry);
            Name = "MainForm";
            Text = "Customer Registry By Sixten Peterson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCustomerRegistry;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblId;
        private Label lblName;
        private Label lblOfficePhone;
        private Label lblOfficeEMail;
        private Label lblContactDetails;
        private RichTextBox rtxtContactDetails;
    }
}
