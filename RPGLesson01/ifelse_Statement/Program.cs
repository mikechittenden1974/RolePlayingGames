using System;

namespace ifelse_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use Console.WriteLine method to pull information from the user
            Console.WriteLine("What is your current experience total?");

            //Set a variable called exp which has to be converted to an integer using ther Int32.Parse Method
            //Also pull this information into memory using the Console.ReadLine() method
            int exp = Int32.Parse(Console.ReadLine());

            //Call the testExperience method, passing exp as a parameter
            testExperience(exp);
        }

        public static void testExperience(int exp)
        {
            //Set that is exp is less then 2000, output the first message
            if (exp < 2000)
            {
                Console.WriteLine("You are Level 1 - toughen up!");
            }
            //Set that is exp is less then 4000 but more than 2040, output the second message
            else if (exp < 4000)
            {
                Console.WriteLine("You are Level 2 - looking better");
            }
            //Set that is exp is less then 8000 but more than 4000, output the second message
            else if (exp < 8000)
            {
                Console.WriteLine("Welcome to Level 3, Adventurer!");
            }
            //Set that is exp is less then 4000 but more than 200, output the second message
            //Terminate the if...if else decision structure by making the last branch an else
            else
            {
                Console.WriteLine("You now need to strive for Level 4!");
            }
            //Terminate the program
        }
    }
}



