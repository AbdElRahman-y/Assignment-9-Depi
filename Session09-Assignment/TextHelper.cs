namespace Session09Assignment;

// ---------------- Q9: Extension Methods ----------------
public static class TextHelper
{
    public static bool IsShorterThan(this string value, int length) => value.Length < length;

    public static string Repeat(this string value, int times)
    {
        if (times <= 0) return string.Empty;

        var result = new System.Text.StringBuilder();
        for (int i = 0; i < times; i++)
            result.Append(value);
        return result.ToString();
    }
}
