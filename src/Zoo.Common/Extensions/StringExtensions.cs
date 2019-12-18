namespace Zoo.Common.Extensions
{
    public static class StringExtensions
    {
        public static bool HasValue(this string src)
        {
            return !string.IsNullOrWhiteSpace(src);
        }
    }
}
