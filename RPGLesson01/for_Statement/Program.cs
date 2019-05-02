using System;

namespace for_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            forTest();
            hpTest();
        }

        private static void forTest()
        {
            for(int i = 1; i<= 5; i++)
            {
                Console.WriteLine("The Value if i is {0}", i);
            }
        }

        private static void hpTest()
        {
            Console.WriteLine("\nTest what happens when Hit Points (HP) decrement to 0");
            for (int j = 16; j >= 0; j--)
            {
                if (j > 0)
                {
                    Console.WriteLine(j);
                }
                else
                {
                    Console.WriteLine("You have no hit points - You are dead");
                }
            }
        }
    }
}
