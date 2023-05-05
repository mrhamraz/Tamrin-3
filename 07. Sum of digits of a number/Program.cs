using System;

namespace _7._Sum_of_digits_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate sum of it's digits:");
            string num = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < (num.Length) ; i++)
              
                sum += Convert.ToInt32(num.Substring(i,1));
              
            Console.WriteLine(sum);


        }
    }
}
