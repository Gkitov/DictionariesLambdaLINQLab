using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
       
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

       
        Dictionary<int, int> occurrences = new Dictionary<int, int>();
        foreach (int number in numbers)
        {
            if (occurrences.ContainsKey(number))
            {
                occurrences[number]++;
            }
            else
            {
                occurrences[number] = 1;
            }
        }

        
        var sortedOccurrences = occurrences.OrderBy(kv => kv.Key);

        
        foreach (var entry in sortedOccurrences)
        {
            Console.WriteLine($"{entry.Key} -> {entry.Value}");
        }
    }
}
