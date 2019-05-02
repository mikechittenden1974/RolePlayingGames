using System;

namespace switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What character class do you intend to be? (Fighter, Wizard, Barbarian or Thief)");
            string profChoice = Console.ReadLine();
            Console.WriteLine("What is your Strength score?");
            int str = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is your Constitution score?");
            int con = Int32.Parse(Console.ReadLine());
            testSwitch(str, con, profChoice);
        }

        public static void testSwitch(int str, int con, string profChoice)
        {
            double result;
            switch (profChoice)
            {
                case "Fighter":
                case "fighter":
                case "FIGHTER":
                    result = str + con;
                    break;

                case "Wizard":
                case "WIZARD":
                case "wizard":
                    result = str - con;
                    break;

                case "Barbarian":
                case "BARBARIAN":
                case "barbarian":
                    result = str * con;
                    break;

                case "Thief":
                case "THIEF":
                case "thief":
                    result = str / con;
                    break;

                default:
                    Console.WriteLine("Unknown profession");
                    return;
            }

            if((profChoice == "Barbarian") || (profChoice == "barbarian") || (profChoice == "BARBARIAN"))
                {
                    Console.WriteLine("Your beserker physical attack damage modifer will be {0}", result);
                    return;
                }
            else
            {
                Console.WriteLine("Your physical attack damage modifer will be {0}", result);
                return;
            }
        }
    }
}

