namespace recipe_book_as_udemi.DataAcces
{
    public abstract class StringRepository : IStringRepository
    {


        public void Write(string filePath, List<string> allRecipesAsString)
        {
            File.WriteAllText(filePath, StringToText(allRecipesAsString));
        }

        protected abstract string StringToText(List<string> allRecipesAsString);





        public List<string> Read(string filePath)
        {

            if (File.Exists(filePath))
            {

                var fileAsString = File.ReadAllText(filePath);
                return TextToString(fileAsString);
                ;
            }
            return new List<string>();
        }

        protected abstract List<string> TextToString(string fileAsString);
    }

}
