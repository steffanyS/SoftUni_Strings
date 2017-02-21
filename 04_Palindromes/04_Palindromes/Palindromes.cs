using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new [] {',',' ','.','!','?'},StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> palindromes= new List<string>();

            foreach (var word in input)
            {
                if (IsPalindrome(word))
                {
                    if (!palindromes.Contains(word))
                    {
                        palindromes.Add(word);
                    }
                }
            }
            var result = palindromes.OrderBy(w => w);
            Console.Write(string.Join(", ",result));
        }

        public static bool IsPalindrome(string word)
        {
            bool palindrome = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    palindrome = false;
                    break;
                }
            }

            return palindrome;
        }
    }
}
