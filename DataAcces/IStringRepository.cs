using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_book_as_udemi.DataAcces
{
    //================================StringTexualRepository================================================
    public interface IStringRepository
    {
        List<string> Read(string filePath);
        void Write(string filePath, List<string> allRecipesAsString);
    }

}
