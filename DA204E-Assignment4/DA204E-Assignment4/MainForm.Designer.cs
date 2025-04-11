namespace DA204E_Assignment4
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
            grpAddNewRecipe = new GroupBox();
            btnAddIngredientsInstructions = new Button();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            txtRecipeName = new TextBox();
            lblRecipeName = new Label();
            btnAddRecipe = new Button();
            lstRecipes = new ListBox();
            btnChange = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            rtxtDescription = new RichTextBox();
            picRecipeImage = new PictureBox();
            btnAddImage = new Button();
            grpAddNewRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRecipeImage).BeginInit();
            SuspendLayout();
            // 
            // grpAddNewRecipe
            // 
            grpAddNewRecipe.Controls.Add(btnAddIngredientsInstructions);
            grpAddNewRecipe.Controls.Add(cmbCategory);
            grpAddNewRecipe.Controls.Add(lblCategory);
            grpAddNewRecipe.Controls.Add(txtRecipeName);
            grpAddNewRecipe.Controls.Add(lblRecipeName);
            grpAddNewRecipe.Location = new Point(12, 12);
            grpAddNewRecipe.Name = "grpAddNewRecipe";
            grpAddNewRecipe.Size = new Size(341, 152);
            grpAddNewRecipe.TabIndex = 0;
            grpAddNewRecipe.TabStop = false;
            grpAddNewRecipe.Text = "Add New Recipe";
            // 
            // btnAddIngredientsInstructions
            // 
            btnAddIngredientsInstructions.Location = new Point(6, 103);
            btnAddIngredientsInstructions.Name = "btnAddIngredientsInstructions";
            btnAddIngredientsInstructions.Size = new Size(329, 39);
            btnAddIngredientsInstructions.TabIndex = 4;
            btnAddIngredientsInstructions.Text = "Add Ingredients and Instructions";
            btnAddIngredientsInstructions.UseVisualStyleBackColor = true;
            btnAddIngredientsInstructions.Click += btnAddIngredientsInstructions_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(116, 64);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(219, 23);
            cmbCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(6, 64);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(116, 28);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(219, 23);
            txtRecipeName.TabIndex = 1;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(6, 31);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(75, 15);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe name";
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Location = new Point(66, 220);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(226, 44);
            btnAddRecipe.TabIndex = 1;
            btnAddRecipe.Text = "Add Recipe";
            btnAddRecipe.UseVisualStyleBackColor = true;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // lstRecipes
            // 
            lstRecipes.FormattingEnabled = true;
            lstRecipes.ItemHeight = 15;
            lstRecipes.Location = new Point(12, 299);
            lstRecipes.Name = "lstRecipes";
            lstRecipes.Size = new Size(341, 304);
            lstRecipes.TabIndex = 2;
            lstRecipes.SelectedIndexChanged += lstRecipes_SelectedIndexChanged;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(12, 618);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(115, 32);
            btnChange.TabIndex = 3;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(133, 618);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 32);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(254, 618);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 32);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear Input";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // rtxtDescription
            // 
            rtxtDescription.ForeColor = SystemColors.MenuHighlight;
            rtxtDescription.Location = new Point(383, 299);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.ReadOnly = true;
            rtxtDescription.Size = new Size(405, 304);
            rtxtDescription.TabIndex = 6;
            rtxtDescription.Text = "";
            // 
            // picRecipeImage
            // 
            picRecipeImage.BorderStyle = BorderStyle.FixedSingle;
            picRecipeImage.Location = new Point(447, 13);
            picRecipeImage.Name = "picRecipeImage";
            picRecipeImage.Size = new Size(263, 201);
            picRecipeImage.TabIndex = 7;
            picRecipeImage.TabStop = false;
            // 
            // btnAddImage
            // 
            btnAddImage.Location = new Point(447, 220);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(263, 44);
            btnAddImage.TabIndex = 8;
            btnAddImage.Text = "Add Image (optional)";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 661);
            Controls.Add(btnAddImage);
            Controls.Add(picRecipeImage);
            Controls.Add(rtxtDescription);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(lstRecipes);
            Controls.Add(btnAddRecipe);
            Controls.Add(grpAddNewRecipe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "APU Cookbook by Sixten Peterson";
            grpAddNewRecipe.ResumeLayout(false);
            grpAddNewRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRecipeImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAddNewRecipe;
        private Label lblRecipeName;
        private Label lblCategory;
        private TextBox txtRecipeName;
        private ComboBox cmbCategory;
        private Button btnAddIngredientsInstructions;
        private Button btnAddRecipe;
        private ListBox lstRecipes;
        private Button btnChange;
        private Button btnDelete;
        private Button btnClear;
        private RichTextBox rtxtDescription;
        private PictureBox picRecipeImage;
        private Button btnAddImage;
    }
}
