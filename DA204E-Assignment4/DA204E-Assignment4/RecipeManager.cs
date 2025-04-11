// Sixten Peterson (AQ9300) 2025-04-10
namespace DA204E_Assignment4
{
    /// <summary>
    /// The RecipeManager class is used for storing and managing an array of recipes.
    /// </summary>
    public class RecipeManager
    {
        private Recipe[] recipeList; // Array of recipes

        /// <summary>
        /// Constructor, initializes the recipeList array to the size provided in the param. 
        /// </summary>
        /// <param name="maxRecipes">The max amount of recipes to be stored in the array.</param>
        public RecipeManager(int maxRecipes) 
        {
            this.recipeList = new Recipe[maxRecipes];
        }

        /// <summary>
        /// Adds the provided recipe to the list if there is space for it.
        /// </summary>
        /// <param name="recipe">The recipe object to be added to the array.</param>
        /// <returns>True if successfully added, False if the array is full and the recipe could not be added.</returns>
        public bool AddRecipe(Recipe recipe)
        {
            const int NoEmptyIndex = -1; // -1 indicating something went wrong
            int emptyIndex = FindFirstEmptyRecipeIndex();

            if (emptyIndex != NoEmptyIndex)
            {
                this.recipeList[emptyIndex] = recipe;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Removes the recipe on the specified index of the array by replacing the value with null. Also moves the recipes one step to the left for better management of the array data.
        /// </summary>
        /// <param name="index">The index of the array to replace the value of.</param>
        /// <returns>True if successful, False if the index provided in the param was invalid</returns>
        public bool RemoveRecipe(int index)
        {
            if (index >= 0 && index <= this.recipeList.Length - 1)
            {
                this.recipeList[index] = null;
                this.MoveRecipesOneStepToLeft(index);
                return true;
            }

            return false; // Failed due to invalid index
        }

        /// <summary>
        /// Fetches a copy of the recipe object in the specified index of the array contianing all the recipes
        /// </summary>
        /// <param name="index">The index to fetch the recipe form</param>
        /// <returns>A copy of the recipe if it successfully found a recipe in the array. Null if no recipe was found at the index or if the index was invalid.</returns>
        public Recipe FetchRecipe(int index)
        {
            if (index >= 0 && index <= this.recipeList.Length - 1 && this.recipeList[index] != null)
            {
                return new Recipe(this.recipeList[index]);
            }

            return null; // Failed
        }

        /// <summary>
        /// Moves the recipes to avoid gaps (null values) in between recipes, copied from the assignment document.
        /// </summary>
        /// <param name="index"></param>
        private void MoveRecipesOneStepToLeft(int index)
        {
            for (int i = index + 1; i < this.recipeList.Length; i++)
            {
                this.recipeList[i - 1] = this.recipeList[i]; //move 1 step to left
                this.recipeList[i] = null; //empty its place
            }
        }

        /// <summary>
        /// Finds the first index where the value is null in the array.
        /// </summary>
        /// <returns>The first empty index.</returns>
        private int FindFirstEmptyRecipeIndex()
        {
            const int NoEmptyIndex = -1; // -1 indicating something went wrong

            for (int i = 0; i < this.recipeList.Length; i++)
            {
                if (this.recipeList[i] == null) // If the value is null then the index is free to use
                {
                    return i;
                }
            }

            return NoEmptyIndex; // No empty index found
        }
    }
}
