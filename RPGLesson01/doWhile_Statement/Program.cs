using System;

namespace doWhile_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            secondRecoveryTest();
        }

        private static void secondRecoveryTest()
        {
            Console.WriteLine("Do While Loop");
            int i = 0;
            do
            {
                Console.WriteLine("It will take {0} hours to recover {0} health", i);
                i++;
            }

            while (i <= 12);
        }
    }
}
