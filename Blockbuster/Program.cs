using System;
using System.Collections.Generic;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {

            BlockBusterVideo bv = new BlockBusterVideo();
            bool goOn = true;
            while (goOn == true)

            {
                bv.PrintAllMovies();
                bv.Checkout();

                goOn = GetContinue("Would you like to watch another movie?");
            }
            //Added a loop to check that VHS play method was still working properly.
        }

        static bool GetContinue(string message)
        {
            Console.WriteLine(message);
            string answer = Console.ReadLine();
            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else if (answer.ToLower().StartsWith("n"))
            {
                Console.WriteLine("Have a great day!");
                return false;
            }
            else
            {
                return GetContinue("I don't understand, please answer Y or N");
            }
        }
    }
}
