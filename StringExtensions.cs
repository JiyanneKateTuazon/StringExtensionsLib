namespace StringExtensionsLib
{
    public static class StringExtensions
    {
        public static bool StartsWithUpperCase(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            return char.IsUpper(text[0]);
        }
    }
}