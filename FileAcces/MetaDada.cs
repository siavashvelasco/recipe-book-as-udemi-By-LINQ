//=====================================MetaDada===================================================================================

namespace recipe_book_as_udemi.FileAcces
{
    public class MetaDada
    {
        public string Name { get; }
        public Format Format { get; }
        public MetaDada(string name, Format format)
        {
            Name = name;
            Format = format;
        }


        public string path() => $"{Name}.{Format.AsFileExtension()}";

    }
}