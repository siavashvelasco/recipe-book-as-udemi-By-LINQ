using recipe_book_as_udemi.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_book_as_udemi.App;

public class RecipeBookApp
{
    IRecipesUserInteraction _recipesUserInteraction;
    IRecipesRepository _recipesRepository;

    public RecipeBookApp(IRecipesUserInteraction recipesUserInteraction, IRecipesRepository recipesRepository)
    {
        _recipesUserInteraction = recipesUserInteraction;
        _recipesRepository = recipesRepository;
    }

    public void Run(string filePath)
    {
        var allRecipe = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintExistingrecipes(allRecipe);
        _recipesUserInteraction.PromptToCreatRecipe();
        var ingedients = _recipesUserInteraction.ReadIngredientsFromUser();
        if (ingedients.Count() > 0)
        {
            var recipe = new Recipe(ingedients);
            allRecipe.Add(recipe);


            _recipesRepository.Write(filePath, allRecipe);
            _recipesUserInteraction.ShowMassage("recipe added:");
            _recipesUserInteraction.ShowMassage(recipe.ToString());

        }
        else
        {
            _recipesUserInteraction.ShowMassage("no ingredients have been selected. recipe will not be saves.");
        }
        _recipesUserInteraction.Exit();
    }
}
