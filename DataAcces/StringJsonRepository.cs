using System.Text.Json;

namespace recipe_book_as_udemi.DataAcces
{
    //================================StringJsonRepository================================================
    public class StringJsonRepository : StringRepository
    {



        protected override string StringToText(List<string> allRecipesAsString)
        {
            return JsonSerializer.Serialize(allRecipesAsString);
        }

        protected override List<string> TextToString(string fileAsString)
        {
            return JsonSerializer.Deserialize<List<string>>(fileAsString);
        }
    }

}
