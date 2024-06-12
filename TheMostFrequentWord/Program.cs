using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        bool isBanned = false;
        int maxFrequency = 0, counter = 0;
        string mostFrequentWord ="";
        string paragraph = "Bob hit a ball, the hit BALL flew The tHE far after thE it was hit.";
        string[] bannedWords = {"hit"};
        string[] splitParagraph;
        char[] charsToTrim = { ' ', ',', '.', '!', '?', ';' };

        splitParagraph = paragraph.Split();

        // On parcourt chaque mot du paragraph
        foreach(string word in splitParagraph)
        {
            isBanned = false;
            // On vérifie que le mot n'est pas interdit
            if (bannedWords.Contains(word.Trim(charsToTrim)))
            {
                isBanned = true;
            }

            if(!isBanned)
            {
                counter = 0;

                foreach (string wordBis in splitParagraph)
                {
                    // On compare le mot à chaque mot du paragraphe en ne tenant pas compte de la "case"
                    if (String.Equals(word.Trim(charsToTrim), wordBis.Trim(charsToTrim), StringComparison.OrdinalIgnoreCase))
                    {
                        counter++;
                    }
                }
                if(maxFrequency < counter)
                {
                    mostFrequentWord = word.Trim(charsToTrim);
                    maxFrequency = counter;
                }
            }
        }
        Console.WriteLine(mostFrequentWord);
    }
}