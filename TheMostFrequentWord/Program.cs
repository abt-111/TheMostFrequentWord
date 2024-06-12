using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
        string[] bannedWords = {"hit"};
        string[] splitParagraph;
        char[] charsToTrim = { ' ', ',', '.', '!', '?', ';' };

        splitParagraph = paragraph.Split();

        int i = 0;
        string test = "ball";

        // Comptage avec valeurs fixes pour test
        foreach(string word in splitParagraph)
        {
            if(String.Equals(test, word.Trim(charsToTrim), StringComparison.OrdinalIgnoreCase))
            {
                i++;
            }
        }

        Console.WriteLine(i);
    }
}