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

        Console.WriteLine("Processing complete.");
    }

    static async Task ProcessFile(string filePath)
    {
        string content = await File.ReadAllTextAsync(filePath);

        string[] sentences = Regex.Split(content, @"(?<=[.!?])\s+");
        string[] words = content.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int punctuationCount = content.Count(char.IsPunctuation);

        if (!Directory.Exists(@"/Users/inmos/Projects/dotNet/dotnetacademy/Homework3/output-books"))
        {
            Directory.CreateDirectory(@"/Users/inmos/Projects/dotNet/dotnetacademy/Homework3/output-books");
        }


        string longestSenteceByNumberOfCharacters = sentences.OrderBy(x => x.Length).Last();
        //string shortestSentenceByNumberOfWords

        Console.WriteLine($"Processed: {Path.GetFileName(filePath)}");
    }
}
