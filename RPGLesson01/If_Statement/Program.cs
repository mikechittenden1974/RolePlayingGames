using System;

namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set an integer variable called baseExp with a value of 0
            int baseExp = 0;

            //Set an integer variable called currentExp with a value of 2000
            int currentExp = 2000;

            //Compare currentExp to baseExp
            //If currentExp is bigger, output the message in the braces
            //Otherwise terminate the program
            if (currentExp > baseExp)
            {
                Console.WriteLine("Level Up! Your current experience is bigger than the starting experience");
            }
        }
    }
}
