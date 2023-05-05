using System;

namespace _5._Multiplication_table__Full_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate mutipication from 1 to it:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)

             //Console.WriteLine("{0} * {1} = {2}", num, i, (num * i));
               Console.WriteLine($"{i} * {num} = {i * num}");
            
        }
    }
}
