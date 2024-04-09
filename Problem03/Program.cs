﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

        for (int i = 0; i < n; i++)
        {
            string word = Console.ReadLine();
            string synonym = Console.ReadLine();

            if (!synonyms.ContainsKey(word))
            {
                synonyms[word] = new List<string>();
            }

            synonyms[word].Add(synonym);
        }

      
        foreach (var pair in synonyms)
        {
            string word = pair.Key;
            List<string> synonymList = pair.Value;
            string synonymsStr = string.Join(", ", synonymList);
            Console.WriteLine($"{word} - {synonymsStr}");
        }
    }
}


