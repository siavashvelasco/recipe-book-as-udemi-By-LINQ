using recipe_book_as_udemi.Recipes;
using System.Collections.Generic;
using System.Threading.Channels;
using System.Text.Json;
using recipe_book_as_udemi.Recipes.Ingredients;
using recipe_book_as_udemi.FileAcces;
using recipe_book_as_udemi.DataAcces;
using recipe_book_as_udemi.App;

    var ingredientsRegister = new IngredientsRegister();
    Format format = Format.json;
        ;
    string fileName = "file";
    var md = new MetaDada(fileName, format);

    IStringRepository StringRepository = format == Format.txt ? new StringTexualRepository() : new StringJsonRepository();

    var recipeBook = new RecipeBookApp
        (
        new RecipesConsoleUserInteraction(ingredientsRegister
        ),
        new _recipesRepository
        (
            StringRepository, ingredientsRegister)
        );
    recipeBook.Run(md.path());

