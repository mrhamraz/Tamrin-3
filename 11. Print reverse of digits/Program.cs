using System;

namespace _11._Print_reverse_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to print reverse: ");
            string num = Console.ReadLine();

            Console.Write(num + " => ");  //just to diplay "=>"

            for (int i = num.Length - 1; i >= 0; i--)
                Console.Write($"{num[i]}");


        }
    }
}
