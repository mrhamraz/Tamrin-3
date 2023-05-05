using System;

namespace _8._Sum_of_1_to_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate sum 0 to that number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i <= num; i++)
                sum += i;

            Console.WriteLine($"0 + 1 + ... + {num} = {sum}");
        }
    }
}
