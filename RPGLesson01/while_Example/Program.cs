using System;

namespace while_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileTest();
            DoWhileTest();
        }

        private static void WhileTest()
        {
            Console.WriteLine("While");
            int i = 0;
            while (i < 0)
            {

                Console.WriteLine("\tThe While Test returns a value of {0} times", i);
                i++;
            }
        }

        private static void DoWhileTest()
        {
            Console.WriteLine("\nDo..While");
            int i = 0;
            do
            {

                Console.WriteLine("\tThe Do...While Test returns a value of {0} then terminates\n", i);
                i++;
            }
            while (i < 0);
        }
    }
}
