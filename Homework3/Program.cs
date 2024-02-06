using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string booksPath = @"/Users/inmos/Projects/dotNet/dotnetacademy/Homework3/books";

        string[] textFiles = Directory.GetFiles(booksPath, "*.txt");

        Task[] tasks = textFiles.Select(file => ProcessFile(file)).ToArray();

        await Task.WhenAll(tasks);
    }

    static async Task ProcessFile(string filePath)
    {
        string content = await File.ReadAllTextAsync(filePath);
        char[] wordSplitCharacters = { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' };

        string[] sentences = Regex.Split(content, @"(?<=[.!?])\s+")
                                .Where(sentence => !string.IsNullOrWhiteSpace(sentence))
                                .ToArray();

        string[] words = content.Split(wordSplitCharacters)
                                .Where(word => !string.IsNullOrWhiteSpace(word))
                                .ToArray();

        int punctuationCount = content.Count(char.IsPunctuation);

        if (!Directory.Exists(@"/Users/inmos/Projects/dotNet/dotnetacademy/Homework3/output-books"))
        {
            Directory.CreateDirectory(@"/Users/inmos/Projects/dotNet/dotnetacademy/Homework3/output-books");
        }


        string longestSenteceByNumberOfCharacters = sentences.OrderBy(x => x.Length).Last();

        string shortestSentenceByNumberOfWords = sentences.OrderBy(x => x.Split(wordSplitCharacters).Length).First();

        string longestWord = words.OrderBy(x => x.Length).Last();

        char mostCommonLetter = words
            .SelectMany(word => word.ToLower())
            .GroupBy(letter => letter)
            .OrderBy(letters => letters.Count())
            .Select(group => group.Key)
            .Last();

        string[] wordsSortedByTheNumberOfUsesInDescendingOrder =
            words
                .GroupBy(word => word.ToLower())
                .OrderByDescending(word => word.Count())
                .Select(group => group.Key)
                .ToArray();

        Console.WriteLine($"Processed: {Path.GetFileName(filePath)}");
    }
}
