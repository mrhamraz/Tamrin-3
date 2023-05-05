using System;

namespace _09._Print_first_and_last_digit_of_a_4_digit_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to print first and last digit of it: ");
            string num = Console.ReadLine();

            Console.WriteLine($"{num[0]} and {num[num.Length-1]}");


        }
    }
}
