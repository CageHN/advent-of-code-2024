public class LineReader
{
    public static IEnumerable<string> ReadLines(string inputFile)
    {
        using StreamReader sr = new(inputFile);
        string? line;
        while ((line = sr.ReadLine()) != null)
        {
            yield return line;
        }
    }
}