using recipe_book_as_udemi.Recipes.Ingredients;
using recipe_book_as_udemi.Recipes;

namespace recipe_book_as_udemi.App
{
    public class RecipesConsoleUserInteraction : IRecipesUserInteraction
    {
        private readonly IIngredientsRegister allIngredients;

        public RecipesConsoleUserInteraction(IIngredientsRegister allIngredients)
        {
            this.allIngredients = allIngredients;
        }

        public void Exit()
        {
            Console.ReadKey();
        }

        public void PrintExistingrecipes(IEnumerable<Recipe> allRecipe)
        {
            if (allRecipe.Count() > 0)
            {
                //int counter = 1;
                var p = allRecipe.Select((recipe,index) =>
                
                    (@$"*****{index + 1}*****
{recipe}
")                 
                );
                Console.WriteLine(string.Join(Environment.NewLine, p));
                //foreach (Recipe recipe in p) ;
                //{
                //    Console.WriteLine($"*****{counter}*****");
                //    Console.WriteLine(recipe);
                //    Console.WriteLine();

                //    ;
                //}
            }
        }

        public void PromptToCreatRecipe()
        {
            Console.WriteLine("creat a new coockie recipes!. avalable ingredients are: ");
            foreach (var ingredient in allIngredients.All)
            {
                Console.WriteLine($"{ingredient.Id}.{ingredient.Name}");
            }
        }

        public IEnumerable<Ingredient> ReadIngredientsFromUser()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            bool shouldExit = false;
            while (!shouldExit)
            {
                Console.WriteLine("add an ingredients by its id, or type anything else if finished");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int id))
                {
                    var selectedIngredients = allIngredients.GetByID(id);

                    if (selectedIngredients is not null)
                    {
                        ingredients.Add(selectedIngredients);
                    }
                }

                else shouldExit = true;
            }
            return ingredients;

        }

        public void ShowMassage(string massage)
        {
            Console.WriteLine(massage);
        }




    }

}
