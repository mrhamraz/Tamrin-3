using System;

namespace _12._Do_multipication_with_sum__like_elementry_school_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers to print Multipication of them (with suming multiple times): ");
            int num1 =Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());


            int sum = 0;
            for (int i = 1; i <= num2; i++)
                sum += num1;

            Console.WriteLine($"{num1} * {num2} = {sum}");
        }
    }
}
