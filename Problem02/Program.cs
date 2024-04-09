using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        string input = Console.ReadLine();

        
        string[] words = input.Split(' ');

        
        Dictionary<string, int> wordCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        
        foreach (string word in words)
        {
            string lowercaseWord = word.ToLower();
            if (wordCounts.ContainsKey(lowercaseWord))
            {
                wordCounts[lowercaseWord]++;
            }
            else
            {
                wordCounts[lowercaseWord] = 1;
            }
        }

        
        List<string> result = new List<string>();
        foreach (var pair in wordCounts)
        {
            if (pair.Value % 2 != 0)
            {
                result.Add(pair.Key);
            }
        }

        
        
        Console.WriteLine(string.Join(" ", result));
    }
}
