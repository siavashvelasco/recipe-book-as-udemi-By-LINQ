namespace recipe_book_as_udemi.DataAcces
{
    public class StringTexualRepository : StringRepository
    {
        string sprator = Environment.NewLine;


        protected override string StringToText(List<string> allRecipesAsString)
        {
            return string.Join(sprator, allRecipesAsString);

        }

        protected override List<string> TextToString(string fileAsString)
        {
            return fileAsString.Split(sprator).ToList();
        }
    }

}
