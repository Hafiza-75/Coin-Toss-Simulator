using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#   ...............Coin Toss Simulator............    #");
            Random rand = new Random();

            while (true)
            {
                Console.Write("\n Type toss to flip the coin and quit to exit: ");
                string input = Console.ReadLine().ToLower().Trim();

                if (input == "exit")
                {
                    Console.WriteLine("\nThanks  for playing! \n |GoodBye|");
                    break;
                }
                if (input != "toss")
                {
                    Console.WriteLine("\nInvalid input!");
                    continue;
                }

                string result = rand.Next(2) == 0 ? "Heads" : "Tails";
                Console.WriteLine($"Result: {result}");

            }
        }
    }
}
