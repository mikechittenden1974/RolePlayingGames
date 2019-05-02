using System;

namespace dowhile_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            secondRecoveryTest();
        }

        private static void secondRecoveryTest()
        { 
            int i = 0;
            do
            {
                Console.WriteLine("The Do...While Loop runs {0} times", i);
                i++;
            }

            while (i < 1);
        }
    }
}
