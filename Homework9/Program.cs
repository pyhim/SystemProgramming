namespace Homework9;

internal static class Program
{
    private static int SearchWordInFile(string filePath, string searchWord)
    {
        using var file = new StreamReader(
            new FileStream(filePath, FileMode.Open, FileAccess.Read));

        string[] tokens = file.ReadToEnd().Split([" ", ", ", ". ", "? ", "! "], StringSplitOptions.RemoveEmptyEntries);
        
        return tokens.Count(token => token.Equals(searchWord));
    }
    
    private static void Main(string[] args)
    {
        if (args.Length < 2) return;
        
        int wordOccurrences = SearchWordInFile(args[0], args[1]);
        
        Console.WriteLine(wordOccurrences);
    }
}