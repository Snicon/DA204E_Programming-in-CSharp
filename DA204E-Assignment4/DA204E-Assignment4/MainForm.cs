// Sixten Peterson (AQ9300) 2025-04-10
namespace DA204E_Assignment4
{
    /// <summary>
    /// The main form and entry point of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        private const int MaxIngredients = 50; // max length of the ingredients array.
        private const int MaxRecipes = 200;    // max length of the recipes array.

        private RecipeManager recipeManager;    // Instance of recipe manager, will be set in the constructor.

        private Recipe currentRecipe = new Recipe(MaxIngredients); // An instance of the recipe class, this object represents the recipe activley being added or edited.

        /// <summary>
        /// Constructor, does what is needed for the designer as well as initalizes the GUI in code and lastly creates a new instance of recipemanager and assigns it to the private field.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitalizeGUI();

            recipeManager = new RecipeManager(MaxRecipes);
        }

        /// <summary>
        /// Initalization of the GUI, very barebones just calls the PopulateFoodCategory to populate the combo box.
        /// </summary>
        private void InitalizeGUI()
        {
            PopulateFoodCategories();
        }

        /// <summary>
        /// Populates the category combo box with all the food categories from the FoodCategory enum.
        /// </summary>
        private void PopulateFoodCategories()
        {
            string[] foodCategories = Enum.GetNames(typeof(FoodCategory)); // Get all enum names and store them in an array
            cmbCategory.Items.AddRange(foodCategories);
            cmbCategory.SelectedIndex = (int)FoodCategory.Meat;
        }

        /// <summary>
        /// Clears the all the windows forms components.
        /// </summary>
        private void Clear()
        {
            txtRecipeName.Clear();
            cmbCategory.SelectedIndex = (int)FoodCategory.Meat;
            this.currentRecipe = new Recipe(MAX_INGREDIENTS);
            lstRecipes.ClearSelected();
            rtxtDescription.Text = String.Empty;
            picRecipeImage.Image = null;
        }

        /// <summary>
        /// Event handler for pressing the clear button. Clears the user interface inputs.
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        /// <summary>
        /// Reads the name text box, validates it and sets it if valid and warns if invalid.
        /// </summary>
        /// <returns>True if valid input has been inputted, False if the input was invalid.</returns>
        private bool ReadName()
        {
            string name = txtRecipeName.Text;

            if (String.IsNullOrEmpty(name))
            {
                ValidationUtility.WarnUser("You must specify a name for your new recipe!");
                return false;
            }
            else
            {
                this.currentRecipe.Name = name;
                return true;
            }
        }

        /// <summary>
        /// Reads the selected food category by checking which indes is selected in the combobox and converting it to an enum value. Then sets the selected food category to the current recipe object.
        /// </summary>
        private void ReadCategory()
        {
            FoodCategory category = (FoodCategory)cmbCategory.SelectedIndex;
            this.currentRecipe.Category = category;
        }

        /// <summary>
        /// Reads all (textbox and combobox) inputs for creating new recipes in the MainForm by calling each "Read-method".
        /// </summary>
        /// <returns>True, if all inputs are valid. False if at least one input was invalid.</returns>
        private bool ReadInput()
        {
            bool validName = ReadName();
            ReadCategory();

            return validName;
        }

        /// <summary>
        /// Opens the recipe details form and stores the new data if the form closes with DialogResult.OK, ignoring the new data if the user closes the window or presses cancel.
        /// </summary>
        private void OpenRecipeDetails()
        {
            Recipe tempRecipe = new Recipe(this.currentRecipe);

            FormRecipeDetails recipeDetails = new FormRecipeDetails(tempRecipe);
            if (recipeDetails.ShowDialog() == DialogResult.OK && recipeDetails.Recipe != null)
            {
                currentRecipe = new Recipe(recipeDetails.Recipe);
            }
        }

        /// <summary>
        /// Checks if the current recipe has any ingredients.
        /// </summary>
        /// <returns>True if the current recipe has ingredients, False if not.</returns>
        private bool CheckForIngredients()
        {
            if (!this.currentRecipe.HasIngredients())
            {
                ValidationUtility.WarnUser("You have not added any ingredients to the recipe yet, please do before adding the recipe.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if the current recipe has a description that is not null or empty.
        /// </summary>
        /// <returns>True if there is a valid description, Flase if there is not.</returns>
        private bool CheckForDescription()
        {
            if (String.IsNullOrEmpty(this.currentRecipe.Description))
            {
                ValidationUtility.WarnUser("You have not added a description/instrcutions to the recipe yet, please do before adding the recipe.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Adds a new recipe to the recipe manager and GUI if all recipe data that is required is valid. Lastly it clears the input.
        /// </summary>
        private void AddRecipe()
        {
            bool validInput = this.ReadInput(); // Running this makes sure to validate and that all state is up to date (user may edit recipe name after adding ingredients for instance)
            bool hasIngredients = this.CheckForIngredients();
            bool hasDescription = this.CheckForDescription();

            if (validInput && hasIngredients && hasDescription)
            {
                this.recipeManager.AddRecipe(currentRecipe);
                lstRecipes.Items.Add(currentRecipe.ToString());
                this.Clear();
            }
        }

        /// <summary>
        /// Deletes the selected recipe if found, warns if no recipe was deleted.
        /// </summary>
        private void DeleteRecipe()
        {
            int index = lstRecipes.SelectedIndex;

            if (index >= 0 && index <= MAX_RECIPES)
            {
                bool successfulRemoval = this.recipeManager.RemoveRecipe(index);
                
                if (successfulRemoval)
                {
                    lstRecipes.Items.RemoveAt(index);
                    this.Clear();
                }
            }
            else
            {
                ValidationUtility.WarnUser("Something went wrong during selection of recipe. Have you selected a recipe?");
            }
        }

        /// <summary>
        /// Changes/edits the currently selected recipe with the new data specified in the currentRecipe object.
        /// </summary>
        private void ChangeRecipe()
        {
            int index = lstRecipes.SelectedIndex;

            Recipe recipe = this.recipeManager.FetchRecipe(index);
            recipe.Name = txtRecipeName.Text.Trim(); // TODO: Move out to its own method
            recipe.Category = (FoodCategory)cmbCategory.SelectedIndex;

            // Make sure the list is updated with the modified data, also takes care of any edited ingredients/descriptions
            lstRecipes.Items[index] = recipe.ToString();
        }

        /// <summary>
        /// Opens the FormRecipeDetails form if the input name and food category is set (and valid).
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnAddIngredientsInstructions_Click(object sender, EventArgs e)
        {
            if (this.ReadInput())
            {
                this.OpenRecipeDetails();
            }
        }

        /// <summary>
        /// Event handler for pressing the add recipe button. Adds a new recipe if possible.
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            this.AddRecipe();
        }

        /// <summary>
        /// Event handler for pressing the delete button. Deletes the selected recipe if a recipe has been selected.
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DeleteRecipe();
        }

        /// <summary>
        /// Event handler for pressing the change button. Updates/changes the currently selected recipe according to new data specified by the user.
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            this.ChangeRecipe();
        }

        /// <summary>
        /// Reads the inputs and sets them in the current recipe object.
        /// </summary>
        private void UpdateGUICurrentRecipe()
        {
            txtRecipeName.Text = this.currentRecipe.Name;
            cmbCategory.SelectedIndex = (int)this.currentRecipe.Category;
        }

        /// <summary>
        /// This method is responsible for handling change of selection for the recipe list, upon changing selection values such as descripton and image must be set to display them in the GUI.
        /// </summary>
        private void HandleSelectionChange()
        {
            int index = this.lstRecipes.SelectedIndex;

            if (index >= 0)
            {
                Recipe recipe = this.recipeManager.FetchRecipe(index);

                string wholeDescription = "INGREDIENTS\n";

                for (int i = 0; i < recipe.Ingredients.Length; i++)
                {
                    if (recipe.Ingredients[i] != null)
                    {
                        wholeDescription += recipe.Ingredients[i] + ", ";
                    }
                }

                const int StartIndex = 0;
                const int LastTwoChars = 2;
                wholeDescription = wholeDescription.Substring(StartIndex, wholeDescription.Length - LastTwoChars); // Remove the last unnessecary ", " from the string
                wholeDescription += "\n\nINSTRUCTIONS\n";
                wholeDescription += recipe.Description;

                rtxtDescription.Text = wholeDescription;

                picRecipeImage.Image = recipe.Image;

                this.currentRecipe = recipe; // Needed for changing stuff
                this.UpdateGUICurrentRecipe();
            }
            else
            {
                rtxtDescription.Text = ""; // Is this fine?
            }
        }

        /// <summary>
        /// Event handler for when the selected index of the recipe list box changes. Basically updates the GUI to reflect the data of the new selection.
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandleSelectionChange();
        }

        private void AddImage()
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog(); // Open dialog for picking a file
                fileDialog.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png"; // Apply filters allowing the user to find jpgs and pngs

                if (fileDialog.ShowDialog() == DialogResult.OK) // The dialog closes with DialogResult OK (indicating that an image selection was successfully made)
                {
                    Image selectedImage = Image.FromFile(fileDialog.FileName); // Stores the image from the selected image file in a variable
                    this.currentRecipe.Image = selectedImage;                       // Sets the image in the GUI
                    picRecipeImage.Image = this.currentRecipe.Image;                // Sets the image in the currentRecipe object 
                }
            }
            catch (Exception exception) // Now we don't want any craches. While I'm positive one shouldn't get any exceptions I opted to use try catch just in case.
            {
                ValidationUtility.WarnUser("Something went wrong and an exception occured... For more details see the following message: " + exception.Message);
            }
        }

        /// <summary>
        /// Sets the image of the recipe
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            this.AddImage();
        }
    }
}
