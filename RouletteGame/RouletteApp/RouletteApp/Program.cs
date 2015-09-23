using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var roulette = new Roulette();
            var game = new RouletteGame(roulette);
            Console.WriteLine("Welcome to Denz Roulette Game!");

            var running = true;

            while (running)
            {
                Console.SetCursorPosition(0, 0);
                game.OpenBets();
                Console.ReadLine();
                Console.SetCursorPosition(0, 0);
                game.CloseBets();
                Console.ReadLine();
            }
        }
    }
}
