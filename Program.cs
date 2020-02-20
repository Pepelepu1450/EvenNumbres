using System;

namespace Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                if(i % 2 == 0)
                {
                    Console.WriteLine("es par ");
                }
            }
        }
    }
}
