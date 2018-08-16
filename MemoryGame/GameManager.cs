using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class GameManager
    {
        static int level = 1;

        public static void Menu()
        {
            const int menuItemCount = 3;
            int menuSwitchPosition = 0;
            int position = 0;

            for (int row = 0; row < menuItemCount; row++)
            {
                GameBackground.MenuBackGround(row, ConsoleColor.Black, ConsoleColor.Red);
            }

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key.Equals(ConsoleKey.UpArrow))
                    {
                        if (menuSwitchPosition > 0)
                        {
                            menuSwitchPosition--;
                        }
                    }
                    if (keyInfo.Key.Equals(ConsoleKey.DownArrow))
                    {
                        menuSwitchPosition++;
                    }
                    if (keyInfo.Key.Equals(ConsoleKey.Enter))
                    {
                        break;
                    }
                }
                GameBackground.MenuBackGround(position, ConsoleColor.Black, ConsoleColor.Red);
                position = menuSwitchPosition % menuItemCount;
                GameBackground.MenuBackGround(position, ConsoleColor.Cyan, ConsoleColor.Blue);
                System.Threading.Thread.Sleep(400);
            }
            GameBackground.CleanBackground();
            switch (position)
            {
                case 0:
                    NewGame(level);
                    break;
                case 1:
                    LoadGame();
                    break;
                case 2:
                    Help.SomeHelp();
                    break;
            }
        }

        public static void NewGame(int level)
        {

        }

        public static void LoadGame()
        {

        }

        public static void ExitGame()
        {

        }

        public static void WinGame()
        {

        }

        public static void SaveGame(CardBack[,] cardBack, CardFace[,] cardFace, Player player, List<CardPosition> list, int level)
        {

        }

        public static void SaveScore(Player player)
        {

        }
    }
}
