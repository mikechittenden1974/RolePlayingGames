using System;

namespace Whle_and_DoWhile_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileTest();
            DoWhileTest();
        }

        public static void WhileTest()
        {
            Console.WriteLine("While");
            int i = 5;

            while (i > 3)
            {
                Console.WriteLine("The value of i is {0}", i);
                i++;
            }
            Console.WriteLine("\n");
        }

        public static void DoWhileTest()
        {
            Console.WriteLine("Do While");
            int i = 0;
            do
            {
                Console.WriteLine("The value of i is {0}", i);
                i++;
            }
            while (i < 0);
        }
    }
}
