//=====================================MetaDada===================================================================================

namespace recipe_book_as_udemi.FileAcces
{
    public static class FileFormatExtension
    {
        public static string AsFileExtension(this Format format) => format == Format.txt ? "txt" : "json";
    }
}