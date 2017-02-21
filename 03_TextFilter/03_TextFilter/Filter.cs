using System;
using System.Linq;

namespace _03_TextFilter
{
    class Filter
    {
        static void Main(string[] args)
        {
            var bannedWors = Console.ReadLine().Split(new []{',',' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            var text = Console.ReadLine();

            foreach (var word in bannedWors)
            {
                text=text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
