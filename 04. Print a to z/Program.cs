using System;

namespace _04._Print_a_to_z
{
    class Program
    {
        static void Main()
        {
            for (int i = 97; i <= 122; ++i)
                Console.Write(Convert.ToChar(i) + " ");
            //with help of ASCII codes
        }
    }
}
