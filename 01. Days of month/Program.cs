using System;

namespace _1._Days_of_month
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of order of a month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                   Console.WriteLine("31");
                   break;
                case 2:
                    Console.WriteLine("31");
                    break;
                case 3:
                    Console.WriteLine("31");
                    break;
                case 4:
                    Console.WriteLine("31");
                    break;
                case 5:
                    Console.WriteLine("31");
                    break;
                case 6:
                    Console.WriteLine("31");
                    break;
                case 7:
                    Console.WriteLine("30");
                    break;
                case 8:
                    Console.WriteLine("30");
                    break;
                case 9:
                    Console.WriteLine("30");
                    break;
                case 10:
                    Console.WriteLine("30");
                    break;
                case 11:
                    Console.WriteLine("30");
                    break;
                case 12:
                    Console.WriteLine("29");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;



            }
        }
    }
}
