using System;

namespace _2._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number to calculate: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number to calculate: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operation sign to calculate: ");
            char sign = Convert.ToChar(Console.ReadLine());

            switch (sign)
            {
                case '+' :
                    Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
