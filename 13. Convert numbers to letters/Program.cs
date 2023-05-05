using System;

namespace _13._Convert_numbers_to_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to print Multipication of it's digits: ");
            string num = Console.ReadLine();

            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            
            for (int i = 0; i < num.Length; i++)

                Console.Write(numbers[Convert.ToInt32(num.Substring(i, 1))]+" ");

        }
    }
}
