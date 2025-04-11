// Sixten Peterson (AQ9300) 2025-04-10
namespace DA204E_Assignment4
{
    /// <summary>
    /// Form for managing ingredients and description of a recipe.
    /// </summary>
    public partial class FormRecipeDetails : Form
    {
        private Recipe recipe; // Field for keeping track of the recipe data

        /// <summary>
        /// Property to get the recipe object, this is used to set the currentRecipe in the MainForm
        /// </summary>
        public Recipe Recipe
        {
            get { return this.recipe; }
        }
        
        /// <summary>
        /// Constructor, takes in a recipe and sets the recipe field to a copy of the provided recipe
        /// </summary>
        /// <param name="currentRecipe">The recipe to copy</param>
        public FormRecipeDetails(Recipe currentRecipe)
        {
            InitializeComponent();
            this.recipe = new Recipe(currentRecipe);
            InitGUI();
        }

        /// <summary>
        /// Initillization of the GUI
        /// </summary>
        private void InitGUI()
        {
            InitTitle();
            InitRecipeData();
            UpdateNumIngredients();
        }

        /// <summary>
        /// Handles setting the title of the form
        /// </summary>
        private void InitTitle()
        {
            const string TITLE_SUFFIX = " -- modify ingredients and description";
            this.Text = this.recipe.Name + TITLE_SUFFIX;
        }

        /// <summary>
        /// Makes sure to set any ingredients or description that already exists for the recipe in the GUI
        /// </summary>
        private void InitRecipeData()
        {
            // Init ingredients
            if (this.recipe.HasIngredients())
            {
                for (int i = 0; i < this.recipe.Ingredients.Length; i++)
                {
                    if (this.recipe.Ingredients[i] != null)
                    {
                        lstIngredients.Items.Add(this.recipe.Ingredients[i]);
                    }
                }
            }

            // Init description
            if (!String.IsNullOrEmpty(this.recipe.Description))
            {
                rtxtDescription.Text = this.recipe.Description;
            }
        }

        /// <summary>
        /// Handles validation for ingredient input, making sure that the value of inte ingredient textbox is not empty or null.
        /// </summary>
        /// <returns>True if valid, False if invalid</returns>
        private bool ValidateNotEmptyIngredientInput()
        {
            string ingredientInput = txtNameAmount.Text.Trim();

            if (String.IsNullOrEmpty(ingredientInput))
            {
                ValidationUtility.WarnUser("You must input an ingredient (and amount) to add or edit an ingredient.");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method for handling the additon of a new ingreident. It validates and then adds the new ingredient to the GUI and ingredient array in the recipe object.
        /// </summary>
        /// <returns>True if the ingredient was successfully added. False if it failed to add the ingredient (validation failed)</returns>
        private bool AddIngredient()
        {
            string ingredientInput = txtNameAmount.Text.Trim();

            bool isNotEmpty = this.ValidateNotEmptyIngredientInput();

            if (isNotEmpty)
            {
                bool valid = this.recipe.AddIngredient(ingredientInput);

                if (valid)
                {
                    lstIngredients.Items.Add(ingredientInput);
                    txtNameAmount.Text = ""; // Clear the text box because the addition of information succeeded
                    return true;
                }
                else
                {
                    // Something went wrong while trying to add the ingredient to the array, most likley the array is full.
                    ValidationUtility.WarnUser("You have reached the maximum amount of ingredients. Please delete an ingredient to add another one.");
                }
            }

            return false; // Failed to add the new ingredient
        }

        /// <summary>
        /// Edits the selected ingredient with the help of the ingredient textbox and listbox.
        /// </summary>
        /// <returns>True if successfully edited the ingredient, False if the validation failed at any stage.</returns>
        private bool EditIngredient()
        {
            string ingredientInput = txtNameAmount.Text.Trim();
            int index = lstIngredients.SelectedIndex;

            bool isNotEmpty = this.ValidateNotEmptyIngredientInput();

            if (isNotEmpty)
            {
                bool valid = this.recipe.EditIngredient(index, ingredientInput);

                if (valid)
                {
                    lstIngredients.Items[lstIngredients.SelectedIndex] = ingredientInput; // edit
                    return true;
                }
                else
                {
                    ValidationUtility.WarnUser("Failed to edit ingredient... Please make sure you have selected an ingredient.");
                }
            }

            return false;
        }

        /// <summary>
        /// Deletes the selected ingredient.
        /// </summary>
        private void DeleteIngredient()
        {
            int index = lstIngredients.SelectedIndex;
            bool removed = this.recipe.RemoveIngredient(index);

            if (removed)
            {
                lstIngredients.Items.RemoveAt(index);
            }
            else
            {
                ValidationUtility.WarnUser("Failed to remove ingredient. The selected index was invalid, please make sure you selected an ingredient.");
            }
        }

        /// <summary>
        /// Updates the GUI with the current amount of ingredients
        /// </summary>
        private void UpdateNumIngredients()
        {
            int amount = this.recipe.AmountOfIngredients();
            lblNumIngredientsResult.Text = amount.ToString();
        }

        /// <summary>
        /// Reads the description written in the ritch text box, validates and sets the description in the recipe object is valid.
        /// </summary>
        /// <returns>True if the description was valid and therefor was set for the recipe object, False if the validation failed at any stage.</returns>
        private bool ReadDescription()
        {
            string description = rtxtDescription.Text.Trim();

            if (String.IsNullOrEmpty(description)) // Failing validation
            {
                DialogResult result = ValidationUtility.AskUser("Your recipe don't have a description, which is required, do you want to add one?");

                if (result == DialogResult.No)
                {
                    this.DialogResult = DialogResult.OK;
                } else if (result == DialogResult.No)
                {
                    this.DialogResult = DialogResult.None;
                }

                return false;
            }
            else // Succeeding
            {
                this.recipe.Description = description;
                return true;
            }
        }

        /// <summary>
        /// Handles the ingredient selection (if an ingredient is selected the ingredient textbox is set to the selected ingredient for better UX and ease of editing)
        /// </summary>
        private void HandleIngredientSelection()
        {
            int index = lstIngredients.SelectedIndex;

            if (index >= 0)
            {
                string ingredient = this.recipe.Ingredients[index];
                txtNameAmount.Text = ingredient;
            }
        }

        /// <summary>
        /// Clears the ingredient input and the listbox of ingredients
        /// </summary>
        private void ClearIngredientInput()
        {
            txtNameAmount.Text = "";
            lstIngredients.ClearSelected();
        }

        /// <summary>
        /// Takes care of validation and setting the data for the recipe object.
        /// </summary>
        private void HandleOK()
        {
            bool hasIngredients = this.recipe.HasIngredients();
            bool validDescription = this.ReadDescription();

            if (!hasIngredients) // No ingredients so we want to let the user know that they should add some.
            {
                DialogResult result = ValidationUtility.AskUser("A recipe isn't much without a couple of ingredients, do you want to add some?");

                if (result == DialogResult.No)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
                else if (result == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.None;
                }
            }

            if (hasIngredients && validDescription)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Event handler for pressing the add button. Tries to add the new ingredient and then updates the amount of ingredients in the GUI.
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddIngredient();
            this.UpdateNumIngredients();
        }

        /// <summary>
        /// Event handler for pressing the edit button. Tries to edit the selected ingredient.
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.EditIngredient();
        }

        /// <summary>
        /// Event handler for pressing the delete button. Tries to delete the ingreident, clears the input and then updates the amount of ingredients.
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DeleteIngredient();
            this.ClearIngredientInput();
            this.UpdateNumIngredients();
        }

        /// <summary>
        /// Event handler for pressing the ok button. Sets the data of the recipe object as long as the values are valid.
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.HandleOK();
        }

        /// <summary>
        /// Event handler for changing the slected index in the ingredients listbox
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandleIngredientSelection();
        }

        /// <summary>
        /// Event handler for pressing hte clear button. Clears the ingredient input and selected index in the ingredient listbox.
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearIngredientInput();
        }

        /// <summary>
        /// Event handler for pressing the cancel button. Sets the DialogResult of the form to Cancel.
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
