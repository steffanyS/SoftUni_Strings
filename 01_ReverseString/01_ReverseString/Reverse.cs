using System;

namespace _01_ReverseString
{
    class Reverse
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = "";

            for (int i = input.Length-1; i >=0; i--)
            {
                result += input[i];
            }

            Console.WriteLine(result);
        }
    }
}
