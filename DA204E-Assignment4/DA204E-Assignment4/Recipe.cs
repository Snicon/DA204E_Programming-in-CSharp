// Sixten Peterson (AQ9300) 2025-04-10
namespace DA204E_Assignment4
{
    /// <summary>
    /// The Recipe class is responsible for representing a recipe in the application. It contians name, description, ingredients list(array), category and image.
    /// </summary>
    public class Recipe
    {
        private string name;            // Name of the recipe
        private string description;     // Description of the recipe (may include instructions or other information
        private string[] ingredients;   // List of ingredients
        private FoodCategory category;  // The category of the recipe
        private Image image;            // An image (may be null if none is provided)

        /// <summary>
        /// Property for getting and setting the name of the recipe. Basic validation is done to make sure the string is not null or empty upon setting.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set
            { 
                if(!String.IsNullOrEmpty(value))
                {
                    this.name = value.Trim();
                }
            }
        }

        /// <summary>
        /// Property for getting and setting the description. Basic validation is done to make sure the string is not null or empty upon setting.
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set {
                if (!String.IsNullOrEmpty(value))
                {
                    this.description = value.Trim();
                }
            }
        }

        /// <summary>
        /// Property for getting the ingredients array. One can not set the array,
        /// however using AddIngredient, EditIngredient or RemoveIngredient method
        /// allows for modification of the array.
        /// </summary>
        public string[] Ingredients
        {
            get { return this.ingredients; }
        }

        /// <summary>
        /// Property for getting and setting the category.
        /// </summary>
        public FoodCategory Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        /// <summary>
        /// Property for getting and setting the Image of the recipe.
        /// </summary>
        public Image Image
        {
            get { return this.image; }
            set { this.image = value; }
        }

        /// <summary>
        /// Constructor, initializes a new array of strings representing the ingredients. The length of the array is determined by the maxIngredients param.
        /// </summary>
        /// <param name="maxIngredients">The maximum amount of ingredients</param>
        public Recipe(int maxIngredients) // "Normal" constructor
        {
            this.ingredients = new string[maxIngredients]; // Initializing the array storing ingredients
        }

        /// <summary>
        /// Copy constructor used to copy/clone a recipe object into a new object
        /// </summary>
        /// <param name="existingRecipe"></param>
        public Recipe(Recipe existingRecipe) // Copy constructor
        {
            // Setting all feilds with the help of the properties below.
            this.name = existingRecipe.Name;
            this.description = existingRecipe.Description;
            this.ingredients = (string[])existingRecipe.Ingredients.Clone(); // Doing a shallow copy of the array (C# strings should be immutable if C# is anything like Java) to avoid using the same object which causes any new ingredients added to reamin when the user presses X or cancel on the FormRecipeDetails form... I may have had quite the challange with this at first...
            this.category = existingRecipe.Category;
        }

        /// <summary>
        /// Finds the first empty index in the ingredients list where empty is null.
        /// </summary>
        /// <returns>The index of the first occuring null value. -1 if no null value was found.</returns>
        private int FindFirstEmptyIngredientIndex()
        {
            const int NoEmptyIndex = -1; // -1 indicating something went wrong

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (this.ingredients[i] == null) // If the value is null then the index is free to use
                {
                    return i;
                }
            }

            return NoEmptyIndex;
        }

        /// <summary>
        /// Checks if the recipe currently contains any ingredients. The use-case for this method is to validate that there are indeed ingredients in the recipe before adding a new recipe.
        /// </summary>
        /// <returns>True if there are ingredients, False if there are no ingredients.</returns>
        public bool HasIngredients()
        {
            int index = this.FindFirstEmptyIngredientIndex();

            return !(index == 0); // True if index isnt 0 (indicating there are ingredients) and false if index is 0 (indicating there are no ingredients)
        }

        /// <summary>
        /// Adds a new ingredient to the ingredient field by finding an empty index and then setting the new value based on the provided ingredient data.
        /// </summary>
        /// <param name="ingredientData">A string representing an ingredient.</param>
        /// <returns>False if no free index was found and true if an empty index was found and the array was updated with the new data.</returns>
        public bool AddIngredient(string ingredientData)
        {
            const int NoEmptyIndex = -1; // -1 indicating something went wrong
            int freeIndex = this.FindFirstEmptyIngredientIndex();

            if(freeIndex != NoEmptyIndex) // A free index was found
            {
                ingredients[freeIndex] = ingredientData; // Setting the new value
                return true;
            }

            return false; // No free index was found
        }

        /// <summary>
        /// Edits an ingredient in the ingredients array field.
        /// </summary>
        /// <param name="ingredientIndex">The index of the ingredients array to edit/update.</param>
        /// <param name="ingredientData">The new value that will be replacing the old one.</param>
        /// <returns></returns>
        public bool EditIngredient(int ingredientIndex, string ingredientData)
        {
            if (ingredientIndex > (this.ingredients.Length - 1) || ingredientIndex < 0) // The index is too big or small
            {
                return false;
            }

            this.ingredients[ingredientIndex] = ingredientData; // Since the index is neither too small or too big we can set the new data
            return true;
        }

        /// <summary>
        /// Removes an ingredient from the ingredients array field by replacing the old value with null.
        /// </summary>
        /// <param name="ingredientIndex">The index of the ingredients array that will be replaced with null</param>
        /// <returns>True if successful, false if unsuccessful (due to invalid index)</returns>
        public bool RemoveIngredient(int ingredientIndex)
        {
            if (ingredientIndex > (this.ingredients.Length - 1) || ingredientIndex < 0) // The index is too big or small
            {
                return false;
            }

            this.ingredients[ingredientIndex] = null; // Replacing the old value
            MoveIngredientsOneStepToLeft(ingredientIndex); // Moving all the data to avoid "data gaps". This way its easier to manage the data in the array.

            return true; // Success
        }

        /// <summary>
        /// Calculates the amount of ingredients in the array. Probably not the most effective way of handling this but accurate.
        /// This could for instance easily be improved by stopping the loop upon the first null value or having a feild keeping
        /// track of the state and updating it in the AddIngredient and RemoveIngredient methods. 
        /// Either way this suffices for an assignment like this.
        /// </summary>
        /// <returns>An int representing the amount of ingredients stored in the array.</returns>
        public int AmountOfIngredients()
        {
            int ingredientsAmount = 0; // Keeping track of the ingredients amount

            for (int i = 0; i < this.ingredients.Length; i++) // Looping through the array to check each value
            {
                if (this.ingredients[i] != null)
                {
                    ingredientsAmount++; // +1 for amount of ingredietns if the value in the array is not null.
                }
            }

            return ingredientsAmount; // Retuning the amount of ingredients
        }

        /// <summary>
        /// Moves the ingredients one step to left, usually called upon removing a value. The code is copied from the assignment tips in the assignment document.
        /// </summary>
        /// <param name="index">The index that was removed (i.e. the "null gap" we are trying to remove)</param>
        private void MoveIngredientsOneStepToLeft(int index)
        {
            for (int i = index + 1; i < this.ingredients.Length; i++)
            {
                this.ingredients[i - 1] = this.ingredients[i]; // Move 1 step to left
                this.ingredients[i] = null; // Empty its place
            }
        }

        /// <summary>
        /// A nicley formatted string used in the listbox.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0,-25} {1,-25} {2,-25}", this.Name, this.Category, this.AmountOfIngredients());
        }
    }
}
