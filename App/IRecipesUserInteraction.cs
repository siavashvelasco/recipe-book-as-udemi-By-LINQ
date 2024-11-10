using recipe_book_as_udemi.Recipes;

namespace recipe_book_as_udemi.App
{

    public interface IRecipesUserInteraction
    {
        void Exit();
        void PrintExistingrecipes(IEnumerable<Recipe> allRecipe);
        void PromptToCreatRecipe();
        IEnumerable<Ingredient> ReadIngredientsFromUser();
        void ShowMassage(string massage);
    }

}
