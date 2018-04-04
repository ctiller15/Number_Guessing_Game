using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randNum = rnd.Next(100);
            Console.WriteLine("Pick a number, between 1 and 100");
            int answer = Convert.ToInt32(Console.ReadLine());
            while (answer != randNum)
            {
                if (answer < randNum)
                {
                    Console.WriteLine("Higher!");
                }
                else
                {
                    Console.WriteLine("Lower!");
                }
                Console.WriteLine("Pick a number, between 1 and 100");
                answer = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Great Job! You guessed the correct number! It was {randNum}");
            Console.ReadLine();

        }
    }
}
