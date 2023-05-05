using System;

namespace _3._Even_or_Odd__Ternary_Operator_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check Even or Odd: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string result = (num % 2 == 0) ? "Even!" : "Odd!";
            Console.WriteLine(result);

        }
    }
}
