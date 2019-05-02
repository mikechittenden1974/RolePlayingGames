using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The factorial  of 5 is {0}",Factorial(5));
            Console.WriteLine("What is the level");
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You need {0} experience points to reach Level {1}", experienceLeveller(m), m);
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1; //base case
            }
            else
            {
                return n * Factorial(n - 1); //recursive case
            }
        }

        //Name the recursive function experienceLeveller
        public static double experienceLeveller(int m)
        {
            //Set the base case - if m =  0 then return 0
            if (m == 0)
            {
                return 0;
            }

            //When the entered value is not zero than carry out the recursive function
            //Start from a base of 100
            //Now multiply that by 2 to the power of m-1
            //Continue with this until you reach the base case

            else
            {
                return 1000 * (Math.Pow(2, m-1));     
            }
        }
    }
}
