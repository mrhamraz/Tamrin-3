using System;

namespace _16._Method__Print_hello_with_input_and_out_put_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ur name: ");
            string name = Console.ReadLine();
            Console.WriteLine(Sayhello(name));
        }

        static string Sayhello(string name)
        {
            return "Hello " + name;
        }
    }
}
