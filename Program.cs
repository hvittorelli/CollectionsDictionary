using System;
using System.Collections.Generic;

namespace CollectionsDictionary
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Dictionary<string, string> BookShelf = new Dictionary<string, string>();
            BookShelf.Add("Harry Potter and the Deathly Hallow", "J.K. Rowling");
            BookShelf.Add("Living Untethered", "Michael Singer");
            BookShelf.Add("Surrender Experiment", "Michael Singer");
            BookShelf.Add("Atomic Habits", "James Clear");
            BookShelf.Add("Harry Potter and the Sorcerer's Stone", "J.K. Rowling");

            Console.WriteLine("Book titles: ");
            Dictionary <string, string>.KeyCollection titles = BookShelf.Keys;
            foreach (string t in titles) 
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Authors: ");
            Dictionary <string, string>.ValueCollection authors = BookShelf.Values;
            foreach (string a in authors) 
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Titles & Authors: ");
            foreach (KeyValuePair <string, string> kvp in BookShelf)
            {
                Console.WriteLine($"Title: {kvp.Key} -- Author: {kvp.Value}");
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Which book should we remove from the shelf? (Enter Title)");
            string answer = Console.ReadLine();
            if (BookShelf.ContainsKey(answer)) 
            {
                BookShelf.Remove(answer);
            }
            else
            {
                Console.WriteLine("The shelf doesn't contain that book!");
            }
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"The book self has {BookShelf.Count} books, here they are: ");
            foreach (KeyValuePair<string, string> kvp in BookShelf)
            {
                Console.WriteLine($"Title: {kvp.Key} -- Author: {kvp.Value}");
            }
        }
    }
}