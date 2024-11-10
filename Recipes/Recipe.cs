

namespace recipe_book_as_udemi.Recipes
{
    public class Recipe
    {
        public IEnumerable<Ingredient> ingredients;

        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }
        public override string ToString()


        {
            List<Ingredient> pack = new List<Ingredient>();
            var pack2 = ingredients.Select(ingredient => ingredient);

            //foreach (Ingredient ingredient in ingredients)
            //{
            //    pack.Add(ingredient);
            //}
            return string.Join(Environment.NewLine, pack2);
        }
    
    }


}

