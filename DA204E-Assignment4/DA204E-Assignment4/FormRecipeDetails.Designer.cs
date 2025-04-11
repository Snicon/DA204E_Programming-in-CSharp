namespace DA204E_Assignment4
{
    partial class FormRecipeDetails
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
            lblNameAmount = new Label();
            txtNameAmount = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblDescription = new Label();
            lblNumIngredients = new Label();
            lblNumIngredientsResult = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            rtxtDescription = new RichTextBox();
            lstIngredients = new ListBox();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNameAmount
            // 
            lblNameAmount.AutoSize = true;
            lblNameAmount.Location = new Point(6, 19);
            lblNameAmount.Name = "lblNameAmount";
            lblNameAmount.Size = new Size(107, 15);
            lblNameAmount.TabIndex = 0;
            lblNameAmount.Text = "Name and amount";
            // 
            // txtNameAmount
            // 
            txtNameAmount.Location = new Point(6, 37);
            txtNameAmount.Name = "txtNameAmount";
            txtNameAmount.Size = new Size(202, 23);
            txtNameAmount.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 66);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(110, 66);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(214, 66);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(333, 9);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(188, 15);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description / Cooking instructions";
            // 
            // lblNumIngredients
            // 
            lblNumIngredients.AutoSize = true;
            lblNumIngredients.Location = new Point(6, 312);
            lblNumIngredients.Name = "lblNumIngredients";
            lblNumIngredients.Size = new Size(127, 15);
            lblNumIngredients.TabIndex = 8;
            lblNumIngredients.Text = "Number of ingredients";
            // 
            // lblNumIngredientsResult
            // 
            lblNumIngredientsResult.AutoSize = true;
            lblNumIngredientsResult.BackColor = SystemColors.Control;
            lblNumIngredientsResult.Location = new Point(253, 312);
            lblNumIngredientsResult.Name = "lblNumIngredientsResult";
            lblNumIngredientsResult.Size = new Size(56, 15);
            lblNumIngredientsResult.TabIndex = 9;
            lblNumIngredientsResult.Text = "loading...";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(441, 369);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(96, 23);
            btnOk.TabIndex = 10;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(543, 369);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(333, 27);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(306, 317);
            rtxtDescription.TabIndex = 12;
            rtxtDescription.Text = "";
            // 
            // lstIngredients
            // 
            lstIngredients.FormattingEnabled = true;
            lstIngredients.ItemHeight = 15;
            lstIngredients.Location = new Point(6, 95);
            lstIngredients.Name = "lstIngredients";
            lstIngredients.Size = new Size(306, 214);
            lstIngredients.TabIndex = 13;
            lstIngredients.SelectedIndexChanged += lstIngredients_SelectedIndexChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(214, 37);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNameAmount);
            groupBox1.Controls.Add(lstIngredients);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(lblNameAmount);
            groupBox1.Controls.Add(lblNumIngredientsResult);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(lblNumIngredients);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 336);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingredients";
            // 
            // FormRecipeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 400);
            Controls.Add(groupBox1);
            Controls.Add(rtxtDescription);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lblDescription);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRecipeDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Loading recipe -- modify ingredients and description";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameAmount;
        private TextBox txtNameAmount;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblDescription;
        private Label lblNumIngredients;
        private Label lblNumIngredientsResult;
        private Button btnOk;
        private Button btnCancel;
        private RichTextBox rtxtDescription;
        private ListBox lstIngredients;
        private Button btnClear;
        private GroupBox groupBox1;
    }
}