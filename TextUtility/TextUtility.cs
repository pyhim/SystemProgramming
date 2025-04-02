using System.Text;

namespace TextUtility;

public class TextUtility
{
    public static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;
        
        while (left < right)
        {
            if (char.ToLower(word[left]) != char.ToLower(word[right]))
                return false;
            
            left++;
            right--;
        }
        
        return true;
    }

    public static int WordCount(string text)
    {
        string[] separators = [", ", ". ", " ", "? ", "! "];
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        
        return words.Length;
    }

    public static string? Reverse(string word)
    {
        var result = new StringBuilder();
        var reversed = word.Reverse();

        foreach (char c in reversed)
        {
            result.Append(c);
        }
        
        return result.ToString();
    }
}