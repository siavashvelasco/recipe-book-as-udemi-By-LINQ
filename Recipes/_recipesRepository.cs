using recipe_book_as_udemi.DataAcces;
using recipe_book_as_udemi.Recipes.Ingredients;

namespace recipe_book_as_udemi.Recipes
{
    public class _recipesRepository : IRecipesRepository
    {
        IStringRepository _StringRepository;
        IIngredientsRegister _IngredientsRegister;

        private const string sprator = ",";
        public _recipesRepository(IStringRepository stringRepository, IIngredientsRegister IngredientsRegister)
        {
            _StringRepository = stringRepository;
            _IngredientsRegister = IngredientsRegister;
        }



        public List<Recipe> Read(string filePath)
        {

            List<Recipe> allrecipes = new List<Recipe>();
            List<string> recipesAsString = _StringRepository.Read(filePath);
            var allrecipes2 = recipesAsString.Select(RecipeFromStrings);
            return allrecipes2.ToList();


            // گرفتن رشته آی دی همه رسپی هاو ریختن هر کدوم داخل یک رشته
            //foreach (string recipeAsString in recipesAsString)//تبدیل هر رشته از یک رسپی به یک لیست از رشته ای دی ها
            //{


            //    Recipe recipe = RecipeFromStrings(recipeAsString);
            //    allrecipes.Add(recipe);//اضافه کردن هر رسپی به همه رسپی ها
            //}
            //return allrecipes;
            ;
        }



        public Recipe RecipeFromStrings(string recipeAsString)
        {

            var ingredients = recipeAsString.Split(sprator).Select(id => int.Parse(id))
                .Select(_IngredientsRegister.GetByID)
            ;

            return new Recipe(ingredients);

        }



        public void Write(string filePath, List<Recipe> allRecipe)
        {
            //List<string> allRecipesAsString = new();

            var allRecipesAsString = allRecipe.Select(Recipe =>
            {
                var allIds =
            Recipe.ingredients.Select
            (Ingredient => Ingredient.Id);
                return string.Join(sprator, allIds);
            });

            //foreach (var recipe in allRecipe)
            //{
            //    List<int> allIds = new();

            //    foreach (var ingredient in recipe.ingredients)
            //    {
            //        allIds.Add(ingredient.Id);
            //    }
            //    allRecipesAsString.Add(string.Join(sprator, allIds));
            //_StringRepository.Write(filePath, allRecipesAsString.ToList());
            _StringRepository.Write(filePath, allRecipesAsString.ToList());

        }

    }

}

