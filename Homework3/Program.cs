using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        var booksPath = @"/Users/inmos/Projects/dotNet/dotnetacademy/Homework3/books";

        var textFiles = Directory.GetFiles(booksPath, "*.txt");

        Parallel.ForEach(textFiles, ProcessFile);
    }

    static void ProcessFile(string filePath)
    {
        var content = File.ReadAllText(filePath);
        char[] wordSplitCharacters = { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' };

        var paragraphs = content.Split(new string[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

        var sentences = paragraphs.SelectMany(paragraph =>
            Regex.Split(paragraph, @"(?<=[.!?])(?:\s+(?=\S)|$)")
                .Where(sentence => !string.IsNullOrWhiteSpace(sentence)))
                .ToArray();

        var words = content.Split(wordSplitCharacters)
                                .Where(word => !string.IsNullOrWhiteSpace(word))
                                .ToArray();

        var punctuationCharacters = content.Where(char.IsPunctuation).ToArray();


        var longestSenteceByNumberOfCharacters = sentences.OrderBy(x => x.Length).LastOrDefault();

        var shortestSentenceByNumberOfWords = sentences.OrderBy(x => x.Split(wordSplitCharacters, StringSplitOptions.RemoveEmptyEntries).Length).FirstOrDefault().Trim();
        var longestWord = words.Where(w => !w.Any(char.IsPunctuation)).OrderByDescending(x => x.Length).FirstOrDefault();

        var mostCommonLetter = words
            .SelectMany(word => word.ToLower())
            .GroupBy(letter => letter)
            .OrderBy(letters => letters.Count())
            .Select(group => group.Key)
            .LastOrDefault();
        
        var wordsSortedByTheNumberOfUsesInDescendingOrder =
            string.Join("\n\r",
                words
                .Select(word => word.Trim('"'))
                .Where(word => !word.Any(char.IsPunctuation))
                .GroupBy(word => word.ToLower())
                .OrderByDescending(word => word.Count())
                .Select(group => group.Key)
                .ToArray()
                );
              

        var titlePattern = @"Title:\s*(.*?)\s*[\n\r]";
        var title = Regex.Match(content, titlePattern).Groups[1].Value;


        var outputDirectory = @"/Users/inmos/Projects/dotNet/dotnetacademy/Homework3/output-books";
        var newFilePath = Path.Combine(outputDirectory, $"{title}.txt");
        

        if (!Directory.Exists(outputDirectory))
        {
            Directory.CreateDirectory(outputDirectory);
        }

        var newFileContent =
            $"Longest sentence by number of characters: {longestSenteceByNumberOfCharacters}\n\r\n\r" +
            $"Shortest sentence by numbers of words: {shortestSentenceByNumberOfWords}\n\r\n\r" +
            $"Longest word: {longestWord}\n\r\n\r" +
            $"Most common letter: {mostCommonLetter}\n\r\n\r" +
            $"Words sorted by number of uses in descending order: \n{wordsSortedByTheNumberOfUsesInDescendingOrder}";
 
        File.WriteAllText(newFilePath, newFileContent);



        Console.WriteLine($"Processed: {Path.GetFileName(filePath)}");
    }
}
