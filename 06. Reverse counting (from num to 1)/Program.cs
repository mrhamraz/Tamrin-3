using System;

namespace _6._Reverse_counting__from_num_to_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to reverse count from 1 to it:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = num; i > 0; --i)
                Console.WriteLine(i);
        }
    }
}
