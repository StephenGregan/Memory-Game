using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class Help
    {
        public static void SomeHelp()
        {
            GameBackground.CleanBackground();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(38, 11);
            Console.WriteLine("Help\n\n");

            Console.Write(new string(' ', 6));
            Console.WriteLine("1)  At the start of the game all the cards are laid face down.");

            Console.Write(new string(' ', 6));
            Console.WriteLine("2)  Only two cards are flipped face up over each turn.");

            Console.Write(new string(' ', 6));
            Console.WriteLine("3)  The objective is to turn over pairs of matching cards.");

            Console.Write(new string(' ', 6));
            Console.WriteLine("4)  If the cards are the same, they remain flipped until the game ends.");

            Console.Write(new string(' ', 6));
            Console.WriteLine("5)  If they are not the same, they are flipped back");

            Console.WriteLine("\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(36, 22);
            Console.WriteLine("Credits:\n");

            Console.SetCursorPosition(0, 24);
            Console.Write(new string(' ', 6));
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(31, 27);
            Console.WriteLine("Current Highscores");
            HighScores
        }
    }
}
