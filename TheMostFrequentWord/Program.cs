internal class Program
{
    private static void Main(string[] args)
    {
        string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
        string[] bannedWords = {"hit"};
        string[] splitParagraph;
        char[] charsToTrim = { ' ', ',', '.', '!', '?', ';' };

        splitParagraph = paragraph.Split();

        foreach(string word in splitParagraph)
        {
            Console.WriteLine(word.Trim(charsToTrim));
        }
    }
}