using System;

namespace _10._Multipication_of_digits_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to print Multipication of it's digits: ");
            string num = Console.ReadLine();

            int multi = 1;

            for (int i = 0; i < num.Length ; i++)

                multi *= Convert.ToInt32(num.Substring(i, 1));

            //Console.WriteLine(multi);

            //just to display every digits: like 1 * 2 * ...
            for (int i = 0; i < (num.Length - 1); i++)
             
                Console.Write($"{num[i]} * ");
            
            Console.WriteLine($"{num[num.Length-1]} = {multi}");
        }
    }
}
