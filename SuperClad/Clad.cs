namespace SuperClad
{
    public static class Clad
    {
        public static string ToUCase(this string input) => input.ToUpper() ?? string.Empty;
        public static string ToLCase(this string input) => input.ToLower() ?? string.Empty;

    }
}