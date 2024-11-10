namespace recipe_book_as_udemi.Recipes.Ingredients
{
    public class IngredientsRegister : IIngredientsRegister
    {
        public IEnumerable<Ingredient> All { get; } = new List<Ingredient> { new WheatFlour(), new CoconutFlour()
        , new Butter(), new Chocolate(), new Sugar(), new Cardamom(),
        new Cinnamon(), new CocoaPowder() };

        public Ingredient GetByID(int id)
        {
         return   All.FirstOrDefault(ingredient => ingredient.Id == id);
      
            //foreach (var ingredient in All)
            //{
            //    if (ingredient.Id == id)
            //    {
            //        return ingredient;
            //    }
            //}
            //return null;

        }
    }
}
