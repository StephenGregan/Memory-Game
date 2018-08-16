using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class ConsoleInput
    {
        public static string GetInput()
        {
            Console.SetCursorPosition(34, 8);
            Console.WriteLine("Enter your name below please.");

            Console.SetCursorPosition(37, 11);
            string input = Console.ReadLine();

            while (CheckInput(input) != true)
            {
                GameBackground.CleanBackground();

                Console.SetCursorPosition(27, 8);
                Console.WriteLine("The name you entereed is too short.  Please try again.");

                Console.SetCursorPosition(37, 11);
                input = Console.ReadLine();
            }
            GameBackground.CleanBackground();
            return input;
        }

        public static bool CheckInput(string input)
        {
            if (input.Length != 0)
            {
                return true;
            }
            return false;
        }
    }
}
